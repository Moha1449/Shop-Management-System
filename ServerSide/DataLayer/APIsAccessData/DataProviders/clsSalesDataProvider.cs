using APIsAccessData.Entities;
using APIsAccessData.ErrorsHandler;
using APIsAccessData.ReturnResultHandler;
using Microsoft.Data.SqlClient;


namespace APIsAccessData.DataProviders
{
    public static class clsSalesDataProvider
    {
        public static async Task<clsGeneralResult.enGeneralResult> GetSalesPagedAsync(List<clsSaleEntity> Sales, short PageNumber, short RowsPerPage)
        {
            if (PageNumber <= 0 || RowsPerPage <= 0 || Sales == null)
            {
                return clsGeneralResult.enGeneralResult.InvalidInputs;
            }


            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_GetSellsPaged", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            while (await Reader.ReadAsync())
                            {
                                Sales.Add(clsSaleEntity.FoundSellEntityInstance
                                    (
                                    Convert.ToInt32(Reader["sell_id"])
                                    , Convert.ToDouble(Reader["total_price"])
                                    , Convert.ToDateTime(Reader["pay_date"])
                                    , Convert.ToInt16(Reader["done_by"])
                                    , Convert.ToString(Reader["user_name"])
                                    ));
                            }
                            return clsGeneralResult.enGeneralResult.Success;
                        }


                    }
                }


            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return clsGeneralResult.enGeneralResult.Exception;
            }
        }

        public static async Task<clsGeneralResult.enGeneralResult> GetSaleBySellIDAsync(clsSaleEntity SaleData)
        {
            if (SaleData == null || SaleData.ID <= 0 || SaleData.Call != clsEntityCall.enCallingFor.Search)
                return clsGeneralResult.enGeneralResult.InvalidInputs;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_GetSellBySellID", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@SellID", SaleData.ID);

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            if (await Reader.ReadAsync())
                            {
                                SaleData.FoundSaleEntityBySaleID
                                    (
                                     Convert.ToDouble(Reader["total_price"])
                                    , Convert.ToDateTime(Reader["pay_date"])
                                    , Convert.ToInt16(Reader["done_by"])
                                    , Convert.ToString(Reader["user_name"])
                                    );
                                return clsGeneralResult.enGeneralResult.Success;
                            }

                        }

                        return clsGeneralResult.enGeneralResult.NotFound;
                    }
                }


            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return clsGeneralResult.enGeneralResult.Exception;
            }
        }

        public static async Task<clsSaleOperationResult> AddNewSaleAsync(clsSaleEntity Sell)
        {
            var DataChecker = clsSaleOperationResult.IsEntityDataValid(Sell);

            if (DataChecker.IsDataInvalid)
                return DataChecker;


            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_AddNewSale", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.Add("@BuyerList", System.Data.SqlDbType.Structured).Value = clsSaleDetailEntity.BuyerListMaker(Sell.BuyerList);
                        Command.Parameters.AddWithValue("@TotalCost", Sell.TotalPrice);
                        Command.Parameters.AddWithValue("@EnteredByID", Sell.DoneByID);
                        Command.Parameters.AddWithValue("@PayDate", Sell.PayDate);
                        Command.Parameters.Add("@SellID", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;

                        await Connection.OpenAsync();

                        await Command.ExecuteNonQueryAsync();

                        Sell.SetID(Convert.ToInt32(Command.Parameters["@SellID"].Value));

                        return new clsSaleOperationResult(clsSaleOperationResult.enGeneralResult.Success);
                    }
                }
            }
            catch (SqlException Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return new clsSaleOperationResult(Ex.Number);
            }
        }

        public static async Task<clsGeneralResult.enGeneralResult> DeleteSaleBySaleIDAsync(int ID)
        {
            if (ID <= 0)
                return clsGeneralResult.enGeneralResult.InvalidInputs;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_DeleteSaleBySaleID", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@SaleID", ID);

                        await Connection.OpenAsync();

                        await Command.ExecuteNonQueryAsync();

                        return clsGeneralResult.enGeneralResult.Success;
                    }
                }
            }
            catch (SqlException Ex)
            {


                if (Ex.Number == (int)clsSaleOperationResult.enDbException.SaleNotFound)
                    return clsGeneralResult.enGeneralResult.NotFound;

                await clsErrorLogger.LogErrorAsync(Ex.Message);

                return clsGeneralResult.enGeneralResult.Exception;
            }
        }
    }
}
