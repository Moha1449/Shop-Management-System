using APIsAccessData.Entities;
using APIsAccessData.ErrorsHandler;
using APIsAccessData.ReturnResultHandler;
using Microsoft.Data.SqlClient;



namespace APIsAccessData.DataProviders
{
    public static class clsUsersDataProvider
    {
        public static async Task<clsGeneralResult.enGeneralResult> GetAllUsersAsync(List<clsUserEntity> Users)
        {
            if (Users == null)
                return clsGeneralResult.enGeneralResult.InvalidInputs;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_GetAllUsers", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            while (await Reader.ReadAsync())
                            {
                                Users.Add(clsUserEntity.FoundUserEntityInstanceImmutable
                                   (
                                        Convert.ToInt16(Reader["user_id"])
                                        ,
                                        Convert.ToString(Reader["user_name"])
                                        ,
                                        Convert.ToString(Reader["password"])
                                        ,
                                        Convert.ToByte(Reader["permissions"])
                                      , Convert.ToBoolean(Reader["is_active"])

                                      , (Reader["added_by"] == DBNull.Value) ? null : Convert.ToInt16(Reader["added_by"])
                                    ));
                            }

                            return clsGeneralResult.enGeneralResult.Success;
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

        public static async Task<clsGeneralResult.enGeneralResult> GetUserByUserIDAsync(clsUserEntity UserData)
        {
            if (UserData.ID <= 0 || UserData.Call != clsEntityCall.enCallingFor.Search)
            {
                return clsGeneralResult.enGeneralResult.InvalidInputs;
            }

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_GetUserByUserID", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@UserID", UserData.ID);

                        await Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {

                            if (await Reader.ReadAsync())
                            {
                                UserData.FoundUserEntityInstanceMutable(

                                Convert.ToString(Reader["user_name"]),

                                Convert.ToString(Reader["password"]),

                                 Convert.ToByte(Reader["permissions"]),

                                Convert.ToBoolean(Reader["is_active"]),

                                (Reader["added_by"] == DBNull.Value) ? null : Convert.ToInt16(Reader["added_by"]));

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

        public static async Task<clsUserOperationDetails> AddNewUserAsync(clsUserEntity NewUser)
        {
            var DataChecker = clsUserOperationDetails.IsEntityDataValid(NewUser);

            if (DataChecker.IsDataInvalid)
            {
                return DataChecker;
            }

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_AddNewUser", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@UserName", NewUser.UserName);
                        Command.Parameters.AddWithValue("@Password", NewUser.Password);
                        Command.Parameters.AddWithValue("@Permissions", NewUser.Permissions);
                        Command.Parameters.AddWithValue("@IsActive", NewUser.IsActive);
                        Command.Parameters.AddWithValue("@AddedBy", (NewUser.CreatedBy == null) ? DBNull.Value : NewUser.CreatedBy);

                        Command.Parameters.Add("@UserID", System.Data.SqlDbType.SmallInt).Direction
                            = System.Data.ParameterDirection.ReturnValue;

                        await Connection.OpenAsync();

                        await Command.ExecuteNonQueryAsync();


                        NewUser.SetID(Convert.ToInt16(Command.Parameters["@UserID"].Value));


                        return new clsUserOperationDetails(clsGeneralResult.enGeneralResult.Success);
                    }
                }
            }
            catch (SqlException Ex)
            {
                await  clsErrorLogger.LogErrorAsync(Ex.Message);
                return new clsUserOperationDetails(Ex.Number);
            }
        }

        public static async Task<clsUserOperationDetails> UpdateUserByUserIDAsync(clsUserEntity User)
        {
            var DataChecker = clsUserOperationDetails.IsEntityDataValid(User);

            if (DataChecker.IsDataInvalid)
            {
                return DataChecker;
            }

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_UpdateUserByUserID", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@UserName", User.UserName);
                        Command.Parameters.AddWithValue("@Password", User.Password);
                        Command.Parameters.AddWithValue("@Permissions", User.Permissions);
                        Command.Parameters.AddWithValue("@UserID", User.ID);
                        Command.Parameters.AddWithValue("@IsActive", User.IsActive);

                        await Connection.OpenAsync();


                        return (Convert.ToInt16(await Command.ExecuteNonQueryAsync()) > 0) ?
                            new clsUserOperationDetails(clsGeneralResult.enGeneralResult.Success) :
                             new clsUserOperationDetails(clsGeneralResult.enGeneralResult.NotFound);
                    }
                }
            }
            catch (SqlException Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return new clsUserOperationDetails(Ex.Number);
            }
        }

        public static async Task<clsGeneralResult.enGeneralResult> DeleteUserByUserIDAsync(short UserID)
        {
            if (UserID <= 0)
                return clsGeneralResult.enGeneralResult.InvalidInputs;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_DeleteUserByUserID", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@UserID", UserID);

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
                return clsGeneralResult.enGeneralResult.Exception;
            }
        }

        public static async Task<clsGeneralResult.enGeneralResult> LoginUsingUserNameAndPasswordAsync(clsUserEntity UserData)
        {
            if (string.IsNullOrEmpty(UserData.UserName) || string.IsNullOrEmpty(UserData.Password))
                return clsGeneralResult.enGeneralResult.InvalidInputs;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_LoginUsingUserNameAndPassword", Connection))
                    {
                        Command.CommandType = System.Data.CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@UserName", UserData.UserName);
                        Command.Parameters.AddWithValue("@Password", UserData.Password);


                        await Connection.OpenAsync();

                        using (SqlDataReader Reader = await Command.ExecuteReaderAsync())
                        {
                            if (await Reader.ReadAsync())
                            {
                                UserData.FoundUserEntityInstanceMutable(
                                UserData.UserName,
                                 UserData.Password, Convert.ToByte(Reader["permissions"]),
                                 Convert.ToBoolean(Reader["is_active"]),
                                 (Reader["added_by"] == DBNull.Value) ? null : Convert.ToInt16(Reader["added_by"]),
                                  Convert.ToInt16(Reader["user_id"]));

                                return clsGeneralResult.enGeneralResult.Success;
                            }
                        }

                        return clsGeneralResult.enGeneralResult.NotFound;
                    }
                }
            }
            catch (SqlException Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return clsGeneralResult.enGeneralResult.Exception;
            }
        }
    }
}
