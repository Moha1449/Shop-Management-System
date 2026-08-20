using APIs_Business.DTOs.StatesDTOs;
using APIs_Business.OperationResultsHandler;
using APIsAccessData.DataProviders;
using APIsAccessData.Entities;


namespace APIs_Business.Businesses
{
    public sealed class clsStates
    {
        private static clsStatesDTO _ConvertToStatesDTO(clsStatesEntity Entity)
        {
            if (Entity == null)
                return new clsStatesDTO();

            return new clsStatesDTO(Entity.TotalUsers, Entity.TotalStocks, Entity.TotalServedCustomers, Entity.TotalSells);
        }

        public static async Task<(clsOperationResultDetails.enReturnResult, clsStatesDTO)> GetStatesAsync()
        {
            (var GetResult, var StatesEntity) = await clsStatesDataProvider.GetStatesAsync();

            return (clsOperationResultDetails.ConvertToBusinessState(GetResult), _ConvertToStatesDTO(StatesEntity));
        }

    }
}
