
using ClientSideBusinessLayer.DTOs.StatesDTO;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;
using ClientSideBusinessLayer.Businesses.Server;


namespace ClientSideBusinessLayer.Businesses
{
    public sealed class clsStates
    {
        public short TotalUsers { get; set; }

        public short TotalStocks { get; set; }

        public int TotalServedCustomers { get; set; }

        public double TotalSells { get; set; }

        public clsReturnResult.enReturnResult State { get; private set; }

        public clsClassModes.enClassMode Mode { get; private set; }


        private clsStates(clsReturnResult.enReturnResult state)
        {
            TotalUsers = 0;
            TotalStocks =0;
            TotalServedCustomers = 0;
            State = state;
            Mode = clsClassModes.enClassMode.Add;
        }

        private clsStates(clsStatesDTO StatesDTO, clsReturnResult.enReturnResult state)
        { 
            TotalUsers = StatesDTO.TotalUsers;
            TotalStocks = StatesDTO.TotalStocks;
            TotalServedCustomers = StatesDTO.TotalServedCustomers;
            TotalSells = StatesDTO.TotalSells;
            State = state;
            Mode = clsClassModes.enClassMode.Update;
        }



        public static async Task<clsStates> GetStates()
        {
            try
            {
                var Response = await clsRequestSettings.Request.GetAsync(clsRequestPaths.AllStates);

                if (Response.IsSuccessStatusCode)
                {
                    string StatesDataStringAsJson = await Response.Content.ReadAsStringAsync();
                    return new clsStates(JsonConvert.DeserializeObject<clsStatesDTO>(StatesDataStringAsJson), clsReturnResult.enReturnResult.Success);
                }

                return InvalidStatesInstance(clsRequestSettings.ConvertToReturnResult(Response.StatusCode));
            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return InvalidStatesInstance(clsReturnResult.enReturnResult.Exception);
            }
        }

        private static clsStates InvalidStatesInstance(clsReturnResult.enReturnResult State)
        {
            return new clsStates(State);
        }
    }
}
