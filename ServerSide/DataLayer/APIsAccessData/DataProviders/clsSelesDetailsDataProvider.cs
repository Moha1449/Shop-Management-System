using APIsAccessData.Entities;
using APIsAccessData.ErrorsHandler;
using APIsAccessData.ReturnResultHandler;
using Microsoft.Data.SqlClient;


namespace APIsAccessData.DataProviders
{
    public static class clsSelesDetailsDataProvider
    {
        public static async Task<(clsGeneralResult.enGeneralResult, List<clsSaleDetailEntity>)> GetSalesDetailsBySaleIDAsync(int SaleID)
        {
            List<clsSaleDetailEntity> SaleDetails = new List<clsSaleDetailEntity>();

            if (SaleID <= 0)
                return (clsGeneralResult.enGeneralResult.InvalidInputs, SaleDetails);

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_GetSalesDetailsBySaleID", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@SaleID", SaleID);

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            while (await Reader.ReadAsync())
                            {
                                SaleDetails.Add(clsSaleDetailEntity.FoundSaleDetailInstance
                                    (
                                     Convert.ToInt32(Reader["detail_id"]),
                                     Convert.ToInt32(Reader["sell_id"]),
                                     Convert.ToInt16(Reader["entered_by"]),
                                     Convert.ToInt16(Reader["stock_id"]),
                                     Convert.ToString(Reader["stock_name"]),
                                     Convert.ToString(Reader["user_name"]),
                                     Convert.ToByte(Reader["quantity"]),
                                     Convert.ToDouble(Reader["cost"])
                                    ));
                            }

                            return (clsGeneralResult.enGeneralResult.Success, SaleDetails);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                await clsErrorLogger.LogErrorAsync(ex.Message);
                return (clsGeneralResult.enGeneralResult.Exception, SaleDetails);
            }




        }

        public static async Task<clsSaleDetailOperationResult> UpdateAmountAsync(clsSaleDetailEntity Detail)
        {
            var DataChecker = clsSaleDetailOperationResult.IsEntityDataValid(Detail);

            if (DataChecker.IsDataInvalid)
                return DataChecker;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_UpdateQuantity", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@SaleID", Detail.SaleID);
                        Command.Parameters.AddWithValue("@StockID", Detail.StockID);
                        Command.Parameters.AddWithValue("@Amount", Detail.Quantity);
                        Command.Parameters.AddWithValue("@SaleDetailID", Detail.DetailID);

                        await Connection.OpenAsync();

                        await Command.ExecuteNonQueryAsync();

                        return new clsSaleDetailOperationResult(clsGeneralResult.enGeneralResult.Success);
                    }
                }
            }
            catch (SqlException Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return new clsSaleDetailOperationResult(Ex.Number);
            }
        }

        public static async Task<clsSaleDetailOperationResult> AddNewItemToBuyerListAsync(clsSaleDetailEntity Item)
        {
            var DataChecker = clsSaleDetailOperationResult.IsEntityDataValid(Item);

            if (DataChecker.IsDataInvalid)
                return DataChecker;

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command =
                        new SqlCommand("sp_AddNewItemToBuyerList", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.Add("@DetailID", System.Data.SqlDbType.Int).Direction
                            = System.Data.ParameterDirection.ReturnValue;

                        Command.Parameters.AddWithValue("@StockID", Item.StockID);
                        Command.Parameters.AddWithValue("@SaleID", Item.SaleID);
                        Command.Parameters.AddWithValue("@EnteredByID", Item.EnteredByID);
                        Command.Parameters.AddWithValue("@Amount", Item.Quantity);
                        Command.Parameters.AddWithValue("@TotalCost", Item.Cost);

                        await Connection.OpenAsync();

                        await Command.ExecuteNonQueryAsync();

                        Item.DetailID = Convert.ToInt32(Command.Parameters["@DetailID"].Value);

                        return new clsSaleDetailOperationResult
                            (clsGeneralResult.enGeneralResult.Success);
                    }
                }
            }
            catch (SqlException Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return new clsSaleDetailOperationResult(Ex.Number);
            }
        }

        public static async Task<clsGeneralResult.enGeneralResult> DeleteSaleDetailByIDAsync(int ID)
        {
            if (ID <= 0)
                return clsGeneralResult.enGeneralResult.InvalidInputs;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_DeleteSaleDetailByDetailID", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@SaleDetailID", ID);

                        await Connection.OpenAsync();

                        await Command.ExecuteNonQueryAsync();

                        return clsGeneralResult.enGeneralResult.Success;
                    }
                }
            }
            catch (SqlException Ex)
            {
                if (Ex.Number == (int)clsSaleDetailOperationResult.enDbException.SaleDetailNotFound)
                    return clsGeneralResult.enGeneralResult.NotFound;

                await clsErrorLogger.LogErrorAsync(Ex.Message);

                return clsGeneralResult.enGeneralResult.Exception;
            }
        }
    }
}
