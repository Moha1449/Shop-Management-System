using APIsAccessData.Entities;
using APIsAccessData.ErrorsHandler;
using APIsAccessData.ReturnResultHandler;
using Microsoft.Data.SqlClient;
using System.Data;



namespace APIsAccessData.DataProviders
{
    public static class clsStocksDataProvider
    {
        public static async Task<clsGeneralResult.enGeneralResult> GetAllStocksAsync(List<clsStockEntity> Stocks)
        {
            if (Stocks == null)
                return clsGeneralResult.enGeneralResult.InvalidInputs;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_GetAllStocks", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            while (await Reader.ReadAsync())
                            {
                                Stocks.Add(clsStockEntity.FoundStockEntityInstanceImmutable
                                    (
                                    Convert.ToInt16(Reader["stock_id"])
                                     , Convert.ToString(Reader["name"])
                                     , Convert.ToInt32(Reader["amount"])
                                     , Convert.ToDouble(Reader["price"])
                                     , Convert.ToDouble(Reader["cost"])
                                     , Convert.ToInt16(Reader["added_by"])
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

        public static async Task<clsGeneralResult.enGeneralResult> GetStockPagedAsync(List<clsStockEntity> Stocks, short PageNumber, short RowsNumberInPage)
        {
            if (PageNumber <= 0 || RowsNumberInPage <= 0 || Stocks == null)
            {
                return clsGeneralResult.enGeneralResult.InvalidInputs;
            }

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_GetStocksPaged", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", RowsNumberInPage);

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            while (await Reader.ReadAsync())
                            {
                                Stocks.Add(clsStockEntity.FoundStockEntityInstanceImmutable
                                    (
                                    Convert.ToInt16(Reader["stock_id"])
                                     , Convert.ToString(Reader["name"])
                                     , Convert.ToInt32(Reader["amount"])
                                     , Convert.ToDouble(Reader["price"])
                                     , Convert.ToDouble(Reader["cost"])
                                     , Convert.ToInt16(Reader["added_by"])
                                    ));
                            }
                            return clsGeneralResult.enGeneralResult.Success;
                        }


                    }
                }

               ;
            }
            catch (Exception Ex)

            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return clsGeneralResult.enGeneralResult.Exception;
            }
        }

        public static async Task<clsGeneralResult.enGeneralResult> GetStockByStockIDAsync(clsStockEntity StockData)
        {
            if (StockData == null || StockData.ID <= 0 || StockData.CallFor != clsEntityCall.enCallingFor.Search)
            {
                return clsGeneralResult.enGeneralResult.InvalidInputs;
            }

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_GetStockByID", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@StockID", StockData.ID);

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {

                            if (await Reader.ReadAsync())
                            {
                                StockData.FoundStockEntityByID(
                                    Convert.ToString(Reader["name"]),

                                Convert.ToInt32(Reader["amount"]),

                                 Convert.ToDouble(Reader["price"]),

                                Convert.ToDouble(Reader["cost"]),

                                Convert.ToInt16(Reader["added_by"])
                                  );

                                return clsGeneralResult.enGeneralResult.Success;
                            }

                            return clsGeneralResult.enGeneralResult.NotFound;
                        }

                    }
                }
            }
            catch (SqlException Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return clsGeneralResult.enGeneralResult.Exception;
            }
        }

        public static async Task<clsGeneralResult.enGeneralResult> GetStockByStockNameAsync(clsStockEntity StockData)
        {
            if (StockData == null || StockData.CallFor != clsEntityCall.enCallingFor.Search
                || string.IsNullOrEmpty(StockData.Name))
                return clsGeneralResult.enGeneralResult.InvalidInputs; 

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_GetStockByName", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@Name", StockData.Name);

                      await  Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {

                            if (await Reader.ReadAsync())
                            {
                                StockData.FoundStockEntityByName
                                    (Convert.ToInt16(Reader["stock_id"]),

                                Convert.ToInt32(Reader["amount"]),

                                 Convert.ToDouble(Reader["price"]),

                                Convert.ToDouble(Reader["cost"]),

                                Convert.ToInt16(Reader["added_by"]));

                                return clsGeneralResult.enGeneralResult.Success;
                            }

                            return clsGeneralResult.enGeneralResult.NotFound;
                        }

                    }
                }
            }
            catch (SqlException Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return clsGeneralResult.enGeneralResult.Exception;
            }

        }

        public static async Task<clsStockOperationDetails> AddNewStockAsync(clsStockEntity StockEntity)
        {
            var DataChecker = clsStockOperationDetails.IsEntityDataValid(StockEntity);

            if (DataChecker.IsDataInvalid)
                return DataChecker;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_AddNewStock", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@Name", StockEntity.Name);
                        Command.Parameters.AddWithValue("@Amount", StockEntity.Amount);
                        Command.Parameters.AddWithValue("@Cost", StockEntity.Cost);
                        Command.Parameters.AddWithValue("@Price", StockEntity.Price);
                        Command.Parameters.AddWithValue("@AddedBy", StockEntity.AddedBy);

                        Command.Parameters.Add("@StockID", System.Data.SqlDbType.SmallInt).Direction
                            = System.Data.ParameterDirection.ReturnValue;

                        await Connection.OpenAsync();

                        await Command.ExecuteNonQueryAsync();

                        StockEntity.SetID(Convert.ToInt16(Command.Parameters["@StockID"].Value));

                        return new clsStockOperationDetails(clsGeneralResult.enGeneralResult.Success);
                    }
                }
            }
            catch (SqlException Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return new clsStockOperationDetails(Ex.Number);
            }
        }

        public static async Task<clsStockOperationDetails> UpdateStockByStockIDAsync(clsStockEntity Stock)
        {
            var DataChecker = clsStockOperationDetails.IsEntityDataValid(Stock);

            if (DataChecker.IsDataInvalid)
                return DataChecker;


            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_UpdateStockByID", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.Add("@StockID", SqlDbType.SmallInt).Value = Stock.ID;
                        Command.Parameters.Add("@Name", SqlDbType.VarChar, 20).Value = Stock.Name;
                        Command.Parameters.Add("@Cost", SqlDbType.Decimal).Value = Stock.Cost;
                        Command.Parameters.Add("@Price", SqlDbType.Decimal).Value = Stock.Price;
                        Command.Parameters.Add("@Amount", SqlDbType.Int).Value = Stock.Amount;


                        await Connection.OpenAsync();


                        return (Convert.ToInt16(await Command.ExecuteNonQueryAsync()) > 0)?
                            new clsStockOperationDetails(clsGeneralResult.enGeneralResult.Success)
                            :new clsStockOperationDetails(clsGeneralResult.enGeneralResult.NotFound);
                    }
                }
            }
            catch (SqlException Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return new clsStockOperationDetails(Ex.Number);
            }

        }

        public static async Task<clsGeneralResult.enGeneralResult> DeleteStockByUserIDAsync(short ID)
        {
            if (ID <= 0)
                return clsGeneralResult.enGeneralResult.InvalidInputs;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_DeleteStockByStockID", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@StockID", ID);

                        await Connection.OpenAsync();


                        return (Convert.ToInt16(await Command.ExecuteNonQueryAsync()) > 0) ?
                           clsGeneralResult.enGeneralResult.Success
                           : clsGeneralResult.enGeneralResult.NotFound;
                    }
                }
            }
            catch (SqlException Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return clsGeneralResult.enGeneralResult.Exception ;
            }
        }                                                                   
    }
}
