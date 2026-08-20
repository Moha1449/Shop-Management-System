using ClientSideBusinessLayer.Businesses.Client;
using ClientSideBusinessLayer.DTOs.SaleDetailsDTO;
using ClientSideBusinessLayer.DTOs.SellDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace ClientSideBusinessLayer.Businesses.Server
{
    public class clsSell
    {
        public int ID { get; set; }

        public double TotalPrice { get; set; }

        public DateTime PayDate { get; set; }

        public short DoneByID { get; set; }

        public string DoneByName { get; set; }

        public clsReturnResult.enReturnResult State { get; private set; }

        public clsClassModes.enClassMode Mode { get; private set; }


        public clsSell(double totalPrice, short doneByID,string doneByName)
        {
            this.TotalPrice = totalPrice;
            this.DoneByID = doneByID;
            this.DoneByName = doneByName;
            this.PayDate = DateTime.Now;
            Mode = clsClassModes.enClassMode.Add;
            State = clsReturnResult.enReturnResult.None;
        }

        private clsSell(int iD, double totalPrice, DateTime payDate, short doneByID, string doneByName, clsReturnResult.enReturnResult state)
        {
            ID = iD;
            TotalPrice = totalPrice;
            PayDate = payDate;
            DoneByID = doneByID;
            DoneByName = doneByName;
            State = state;
            Mode = clsClassModes.enClassMode.Update;
        }

        private clsSell(clsSaleDTO SellDTO, clsReturnResult.enReturnResult State)
        {
            this.ID = SellDTO.ID;
            this.TotalPrice = SellDTO.TotalPrice;
            this.State = State;
            this.DoneByName = SellDTO.DoneByName;
            Mode = clsClassModes.enClassMode.Update;
            this.PayDate = SellDTO.PayDate;
        }

        public static async Task<(clsReturnResult.enReturnResult, List<clsSell>)> GetSellsPaged(short PageNumber, short RowsPerPage)
        {
            List<clsSell> Sells = new List<clsSell>();

            if (PageNumber <= 0 || RowsPerPage <= 0)
                return (clsReturnResult.enReturnResult.InvalidInputs, Sells);

            try
            {
                HttpResponseMessage Response = await clsRequestSettings.Request.GetAsync(clsRequestPaths.GetSellsPaged + $@"/{PageNumber}/{RowsPerPage}");

                if (Response.IsSuccessStatusCode)
                {
                    string SellsAsJson = await Response.Content.ReadAsStringAsync();

                    Sells = JsonConvert.DeserializeObject<List<clsSaleDTO>>(SellsAsJson)
                        .Select(DTO => new clsSell(DTO, clsReturnResult.enReturnResult.Found))
                        .ToList();

                    return (clsReturnResult.enReturnResult.Success, Sells);
                }

                return (clsRequestSettings.ConvertToReturnResult(Response.StatusCode), Sells);
            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return (clsReturnResult.enReturnResult.Exception, Sells);
            }
        }

        public static async Task<clsSell> GetSellBySellID(int ID)
        {
            if (ID <= 0)
                return InvalidSellInstance(clsReturnResult.enReturnResult.InvalidInputs);

            try
            {
                HttpResponseMessage Response = await clsRequestSettings.Request.GetAsync(clsRequestPaths.GetSell + $@"/{ID}");

                if (Response.IsSuccessStatusCode)
                {
                    clsSaleDTO StockData = JsonConvert.DeserializeObject<clsSaleDTO>(await Response.Content.ReadAsStringAsync());
                    return new clsSell(StockData, clsReturnResult.enReturnResult.Found);
                }

                return InvalidSellInstance(clsReturnResult.enReturnResult.NotFound);
            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return InvalidSellInstance(clsReturnResult.enReturnResult.Exception);
            }

        }

        public async Task<clsReturnResult> AddNewSell(List<clsAddItemToBuyerListUsingSaleDTO> BuyerList)
        {
            if (Mode != clsClassModes.enClassMode.Add)
                return new clsReturnResult(clsReturnResult.enReturnResult.None);

            if (this.TotalPrice <= 0 || this.DoneByID <= 0 || BuyerList == null || BuyerList.Count == 0)
            {
                this.State = clsReturnResult.enReturnResult.InvalidInputs;
                return new clsReturnResult(clsReturnResult.enReturnResult.InvalidInputs);
            }

            try
            {
                string SaleDataAsJson = JsonConvert.SerializeObject(new clsAddSellDTO(this.TotalPrice, this.DoneByID, BuyerList));
                StringContent Content = new StringContent(SaleDataAsJson, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage Response = await clsRequestSettings.Request.PostAsync(clsRequestPaths.AddSale, Content);

                var AddResult = clsRequestSettings.ConvertToReturnResult(Response.StatusCode);

                string Body = await Response.Content.ReadAsStringAsync();

                if (Response.IsSuccessStatusCode)
                {
                    this.ID = JsonConvert.DeserializeObject<short>(Body);
                    return new clsReturnResult(AddResult);
                }

                return new clsReturnResult(AddResult, Body);
            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return new clsReturnResult(clsReturnResult.enReturnResult.Exception, "");
            }

        }

        
        public static async Task<clsReturnResult.enReturnResult> DeleteSaleBySaleID(int ID)
        {
            if (ID <= 0)
                return clsReturnResult.enReturnResult.InvalidInputs;

            try
            {

                HttpResponseMessage Response = await clsRequestSettings.Request.DeleteAsync(clsRequestPaths.DeleteSale+ $"/{ID}");

                if (Response.IsSuccessStatusCode)
                {
                    return clsReturnResult.enReturnResult.Success;
                }

                return clsRequestSettings.ConvertToReturnResult(Response.StatusCode);
            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return clsReturnResult.enReturnResult.Exception;
            }

        }

        private static clsSell InvalidSellInstance(clsReturnResult.enReturnResult Result)
        {
            return new clsSell(-1, 0d, DateTime.Now, -1, string.Empty, Result);
        }

    }
}
