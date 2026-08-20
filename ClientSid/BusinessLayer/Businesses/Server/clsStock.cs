using ClientSideBusinessLayer.DTOs.StockDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientSideBusinessLayer.Businesses.Server
{
    public class clsStock
    {
        public short ID { get; set; }

        public string Name { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

        public double Cost { get; set; }

        public short AddedBy { get; set; }

        public clsReturnResult.enReturnResult State { get; private set; }

        public clsClassModes.enClassMode Mode { get; private set; }



        private clsStock(short id, string name, int amount, double price, double cost, short addedBy, clsReturnResult.enReturnResult state)
        {
            ID = id;
            Name = name;
            Amount = amount;
            Price = price;
            Cost = cost;
            AddedBy = addedBy;
            State = state;
            Mode = clsClassModes.enClassMode.Update;
        }

        private clsStock(clsStockDTO StockData, clsReturnResult.enReturnResult returnResult)
        {
            ID = StockData.ID;
            Name = StockData.Name;
            Amount = StockData.Amount;
            Price = StockData.Price;
            Cost = StockData.Cost;
            AddedBy = StockData.AddedBy;
            State = returnResult;
            Mode = clsClassModes.enClassMode.Update;
        }


        public clsStock()
        {
            ID = -1;
            Name = string.Empty;
            Amount = 0;
            Price = 0d;
            Cost = 0d;
            AddedBy = -1;
            Mode = clsClassModes.enClassMode.Add;
            State = clsReturnResult.enReturnResult.None;
        }




        public static async Task<(clsReturnResult.enReturnResult, List<clsStock>)> GetStockPaged(short PageNumber, short RowsNumber)
        {
            if (PageNumber <= 0 || RowsNumber <= 0)
                return (clsReturnResult.enReturnResult.InvalidInputs, new List<clsStock>());

            try
            {
                HttpResponseMessage Response = await clsRequestSettings.Request.GetAsync(clsRequestPaths.GetStocksPaged + $@"/{PageNumber}/{RowsNumber}");

                if (Response.IsSuccessStatusCode)
                {
                    string StocksDataStringAsJson = await Response.Content.ReadAsStringAsync();

                    List<clsStock> Users = JsonConvert.DeserializeObject<List<clsStockDTO>>(StocksDataStringAsJson).
                        Select(StockDTO => new clsStock(StockDTO, clsReturnResult.enReturnResult.Found)).ToList();

                    if (Users == null)
                        return (clsReturnResult.enReturnResult.Empty, new List<clsStock>());


                    return (clsReturnResult.enReturnResult.Success, Users);
                }

                return (clsRequestSettings.ConvertToReturnResult(Response.StatusCode), new List<clsStock>());
            }
            catch (Exception ex)
            {
                await clsErrorLogger.LogErrorAsync(ex.Message);
                return (clsReturnResult.enReturnResult.Exception, new List<clsStock>());
            }
        }

        public static async Task<clsStock> GetStockByName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
                return InvalidStockInstance(clsReturnResult.enReturnResult.InvalidInputs);

            try
            {
                HttpResponseMessage Response = await clsRequestSettings.Request.GetAsync(clsRequestPaths.GetStockByName + $@"/{Name}");

                if (Response.IsSuccessStatusCode)
                {
                    clsStockDTO StockData = JsonConvert.DeserializeObject<clsStockDTO>(await Response.Content.ReadAsStringAsync());
                    return new clsStock(StockData, clsReturnResult.enReturnResult.Found);
                }

                return InvalidStockInstance(clsRequestSettings.ConvertToReturnResult(Response.StatusCode));
            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return InvalidStockInstance(clsReturnResult.enReturnResult.Exception);
            }

        }

        private async Task<clsReturnResult> AddNewStock()
        {
            if (string.IsNullOrEmpty(Name) || Amount < 0 || Cost < 0 || Price < 0 || AddedBy < 0)
                return new clsReturnResult(clsReturnResult.enReturnResult.InvalidInputs);

            try
            {
                string StockDataAsJson = JsonConvert.SerializeObject(new clsAddStockDTO(Name, Amount, Price, Cost, AddedBy));

                StringContent Content = new StringContent(StockDataAsJson, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage Response = await clsRequestSettings.Request.PostAsync(clsRequestPaths.AddStock, Content);

                string ResponseBody = await Response.Content.ReadAsStringAsync();

                if (Response.IsSuccessStatusCode)
                {
                    //Update The Stock Data
                    this.ID = JsonConvert.DeserializeObject<short>(ResponseBody);
                    State = clsReturnResult.enReturnResult.Found;
                    this.Mode = clsClassModes.enClassMode.Update;

                    return new clsReturnResult(clsReturnResult.enReturnResult.Success);
                }

                if (Response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                {
                    return new clsReturnResult(clsReturnResult.enReturnResult.ServerError, ResponseBody);
                }

                return new clsReturnResult(clsRequestSettings.ConvertToReturnResult(Response.StatusCode));

            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return new clsReturnResult(clsReturnResult.enReturnResult.Exception);
            }
        }

        private async Task<clsReturnResult> UpdateStockByStockID()
        {
            if (string.IsNullOrEmpty(Name) || Amount < 0 || Cost < 0 || Price < 0 || AddedBy <= 0 || ID <= 0)
                return new clsReturnResult(clsReturnResult.enReturnResult.InvalidInputs);

            try
            {
                string StockDataAsJson = JsonConvert.SerializeObject(new clsUpdateStockDTO(ID, Name, Amount, Price, Cost));

                StringContent Content = new StringContent(StockDataAsJson, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage Response = await clsRequestSettings.Request.PutAsync(clsRequestPaths.UpdateStock, Content);

                string ResponseBody = await Response.Content.ReadAsStringAsync();

                if (Response.IsSuccessStatusCode)
                {
                    State = clsReturnResult.enReturnResult.Found;
                    return new clsReturnResult(clsReturnResult.enReturnResult.Success);
                }

                return new clsReturnResult(clsRequestSettings.ConvertToReturnResult(Response.StatusCode));
            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return new clsReturnResult(clsReturnResult.enReturnResult.Exception);
            }

        }

        public static async Task<clsReturnResult.enReturnResult> DeleteStockByStockID(short ID)
        {
            if (ID <= 0)
                return clsReturnResult.enReturnResult.InvalidInputs;

            try
            {
                HttpResponseMessage Response = await clsRequestSettings.Request.DeleteAsync(clsRequestPaths.DeleteStock + $@"/{ID}");

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

        public async Task<clsReturnResult> Save()
        {
            switch (Mode)
            {
                case clsClassModes.enClassMode.Add:
                    return await AddNewStock();
                case clsClassModes.enClassMode.Update:
                    return await UpdateStockByStockID();

                default:
                    return new clsReturnResult(clsReturnResult.enReturnResult.None);
            }
        }



        private static clsStock InvalidStockInstance(clsReturnResult.enReturnResult State)
        {
            return new clsStock(-1, string.Empty, 0, 0d, 0d, 0, State);
        }
    }
}
