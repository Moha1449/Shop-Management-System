using APIsAccessData.Entities;
using APIsAccessData.ErrorsHandler;
using APIsAccessData.ReturnResultHandler;
using Microsoft.Data.SqlClient;

namespace APIsAccessData.DataProviders
{
    public static class clsStatesDataProvider
    {
        public static async Task <(clsGeneralResult.enGeneralResult, clsStatesEntity)> GetStatesAsync( )
        {
            clsStatesEntity States = new clsStatesEntity();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_GetStates", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {

                            if (await Reader.ReadAsync())
                            {
                                

                                States.TotalUsers = Convert.ToInt16(Reader["total_users"]);
                                States.TotalStocks = Convert.ToInt16(Reader["total_stocks"]);
                                States.TotalServedCustomers = Convert.ToInt32(Reader["total_served"]);
                                States.TotalSells = Convert.ToDouble(Reader["total_sales"]);


                                
                            }
                        }
                        
                        return (clsGeneralResult.enGeneralResult.Success,States);
                    }
                }
            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return (clsGeneralResult.enGeneralResult.Exception, States);
            }

        }

    }
}
