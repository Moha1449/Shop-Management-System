using ClientSideBusinessLayer.DTOs.SaleDetailsDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace ClientSideBusinessLayer.Businesses.Server
{
    public class clsSaleDetail
    {
        public int DetailID { get; set; }

        public int SaleID { get; set; }

        public short EnteredByID { get; set; }

        public short StockID { get; set; }

        public string StockName { get; set; }

        public string EnteredByName { get; set; }

        public int Quantity { get; set; }

        public double Cost { get; set; }

        public clsReturnResult.enReturnResult State { get; private set; }

        public clsClassModes.enClassMode Mode { get; private set; }


        public clsSaleDetail( int saleID, short enteredByID, short stockID,string stockName,string enterByName,  int quantity, double cost)
        {
            DetailID = -1;
            SaleID = saleID;
            EnteredByID = enteredByID;
            StockID = stockID;
            EnteredByName = enterByName;
            StockName = stockName;
            Quantity = quantity;
            Cost = cost;
            State = clsReturnResult.enReturnResult.None;
            Mode = clsClassModes.enClassMode.Add;
        }

        private clsSaleDetail(clsSaleDetailsDTO SaleDetails, clsReturnResult.enReturnResult State)
        {
            this.DetailID = SaleDetails.DetailID;
            this.SaleID = SaleDetails.SaleID;
            this.StockID = SaleDetails.StockID;
            this.EnteredByID = SaleDetails.EnteredByID;
            this.EnteredByName = SaleDetails.EnteredByName;
            this.Quantity = SaleDetails.Quantity;
            this.Cost = SaleDetails.Cost;
            this.StockName = SaleDetails.StockName;
            this.State = State;
            Mode = clsClassModes.enClassMode.Update;
        }

        public static async Task<(clsReturnResult.enReturnResult, List<clsSaleDetail>)> GetSaleDetailsBySeLeID(int ID)
        {
            List<clsSaleDetail> SaleDetails = new List<clsSaleDetail>();

            if (ID <= 0)
                return (clsReturnResult.enReturnResult.InvalidInputs, SaleDetails);

            try
            {
                HttpResponseMessage Response = await clsRequestSettings.Request.GetAsync(clsRequestPaths.GetSaleDetailsBySaleID + $@"/{ID}");

                if (Response.IsSuccessStatusCode)
                {
                    string SaleDetailsAsJson = await Response.Content.ReadAsStringAsync();

                    SaleDetails = JsonConvert.DeserializeObject<List<clsSaleDetailsDTO>>(SaleDetailsAsJson)
                        .Select(D => new clsSaleDetail(D, clsReturnResult.enReturnResult.Found)).ToList();

                    return (clsReturnResult.enReturnResult.Success, SaleDetails);
                }

                return (clsRequestSettings.ConvertToReturnResult(Response.StatusCode), SaleDetails);
            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return (clsReturnResult.enReturnResult.Exception, SaleDetails);
            }
        }


        public async Task<clsReturnResult> UpdateAmount()
        {
            if (Mode != clsClassModes.enClassMode.Update)
                return new clsReturnResult(clsReturnResult.enReturnResult.None);

            if (this.Quantity <= 0 || this.StockID <= 0 || this.DetailID <= 0 || this.SaleID <= 0)
                return new clsReturnResult(clsReturnResult.enReturnResult.InvalidInputs);

            try
            {
                string ContentAsJson = JsonConvert.SerializeObject(new clsUpdateAmountDTO(DetailID, SaleID, StockID, Quantity));
                StringContent Content = new StringContent(ContentAsJson, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage Response = await clsRequestSettings.Request.PutAsync(clsRequestPaths.UpdateAmount, Content);

                if (Response.IsSuccessStatusCode)
                {
                    return new clsReturnResult(clsReturnResult.enReturnResult.Success);
                }

                var UpdateResult = clsRequestSettings.ConvertToReturnResult(Response.StatusCode);

                if (UpdateResult == clsReturnResult.enReturnResult.Found)
                    return new clsReturnResult(UpdateResult);

                string Body = await Response.Content.ReadAsStringAsync();

                return new clsReturnResult(UpdateResult, Body);

            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return new clsReturnResult(clsReturnResult.enReturnResult.Exception);
            }
        }


        public static async Task<clsReturnResult.enReturnResult> DeleteSaleDetailByID(int ID)
        {
            if (ID <= 0)
                return clsReturnResult.enReturnResult.InvalidInputs;

            try
            {
                HttpResponseMessage Response = await clsRequestSettings.Request.DeleteAsync(clsRequestPaths.DeleteSaleDetail + $@"/{ID}");

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

        public async Task<clsReturnResult.enReturnResult> AddNewItemToBuyerList()
        {
            if (Mode != clsClassModes.enClassMode.Add)
                return clsReturnResult.enReturnResult.None;

            if (this.Quantity <= 0 || this.StockID <= 0 || this.SaleID <= 0 || this.Cost <=0 ||EnteredByID <=0 )
                return clsReturnResult.enReturnResult.InvalidInputs;

            try
            {
                string ContentAsJson = JsonConvert.SerializeObject(
                    new clsAddItemToBuyerListDTO(this.SaleID, this.EnteredByID, this.StockID, this.Quantity, this.Cost));

                StringContent Content = new StringContent(ContentAsJson, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage Response = await clsRequestSettings.Request.PostAsync(clsRequestPaths.AddItemToBuyerList, Content);

                if (Response.IsSuccessStatusCode)
                {
                    this.DetailID = JsonConvert.DeserializeObject<int>(
                        await  Response.Content.ReadAsStringAsync() );  
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


        public static List<clsAddItemToBuyerListUsingSaleDTO> TheBuyerListMaker(Dictionary<short, int> Amounts, Dictionary<short, double> Prices)
        {
            return Amounts.Select(D => new clsAddItemToBuyerListUsingSaleDTO(D.Key, D.Value, Prices[D.Key])).ToList();
        }
    }
}
