using ClientSideBusinessLayer.Businesses.Client;
using ClientSideBusinessLayer.Businesses.Server;
using ClientSideBusinessLayer.DTOs;
using ClientSideBusinessLayer.DTOs.UsersDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace ClientSideBusinessLayer
{
    public class clsUser
    {
        public short UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public byte Permissions { get; set; }

        public bool IsActive { get; set; }

        public short? CreatedBy { get; set; }

        public clsRoles.enRole Role { get { return (clsRoles.enRole)Permissions; } }

        public clsReturnResult.enReturnResult State { get; private set; }

        public clsClassModes.enClassMode Mode { get; private set; }

        public enum enOperations
        {
            ShowStocks, ShowUsers, ShowSales, AddUsers, UpdateUsers, DeleteUsers
                , AddStocks, UpdateStocks, DeleteStocks
                , AddSells, UpdateSells,DeleteSale
        }




        private clsUser(short userID, string userName, string password, byte permissions, bool isactive, short? createdBy, clsReturnResult.enReturnResult state)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            Permissions = permissions;
            State = state;
            IsActive = isactive;
            Mode = clsClassModes.enClassMode.Update;
            CreatedBy = createdBy;
        }

        private clsUser(clsUserDTO UserData, clsReturnResult.enReturnResult returnResult)
        {
            UserID = UserData.UserID;
            UserName = UserData.UserName;
            Password = UserData.Password;
            Permissions = UserData.Permissions;
            IsActive = UserData.IsActive;
            State = returnResult;
            Mode = clsClassModes.enClassMode.Update;
            CreatedBy = UserData.CreatedBy;
        }

        public clsUser()
        {
            UserID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            Permissions = 0;
            State = clsReturnResult.enReturnResult.None;
            IsActive = false;
            Mode = clsClassModes.enClassMode.Add;
            CreatedBy = null;
        }



        public static async Task<(clsReturnResult.enReturnResult, List<clsUser>)> GetAllUsers()
        {
            try
            {
                HttpResponseMessage Response = await clsRequestSettings.Request.GetAsync(clsRequestPaths.GetUsers);

                if (Response.IsSuccessStatusCode)
                {
                    string UsersDataStringAsJson = await Response.Content.ReadAsStringAsync();

                    List<clsUser> Users = JsonConvert.DeserializeObject<List<clsUserDTO>>(UsersDataStringAsJson).
                        Select(UserDTO => new clsUser(UserDTO, clsReturnResult.enReturnResult.Found)).ToList();

                    if (Users == null)
                        return (clsReturnResult.enReturnResult.Empty, new List<clsUser>());


                    return (clsReturnResult.enReturnResult.Success, Users);
                }

                return (clsRequestSettings.ConvertToReturnResult(Response.StatusCode), new List<clsUser>());
            }
            catch (Exception ex)
            {
                await clsErrorLogger.LogErrorAsync(ex.Message);
                return (clsReturnResult.enReturnResult.Exception, new List<clsUser>());
            }
        }

        public static async Task<clsUser> LoginUsingPasswordAndUserName(clsLoginDTO LoginData)
        {
            if (LoginData == null || string.IsNullOrEmpty(LoginData.UserName) || string.IsNullOrEmpty(LoginData.Password))
                return InvalidUserInstance(clsReturnResult.enReturnResult.InvalidInputs);

            try
            {
                string Query = clsRequestPaths.Login + $"?UserName={LoginData.UserName}&Password={LoginData.Password}";

                HttpResponseMessage Response = await clsRequestSettings.Request.GetAsync(Query);

                if (Response.IsSuccessStatusCode)
                {
                    string UserDataStringAsJson = await Response.Content.ReadAsStringAsync();

                    clsUserDTO UserDTO = JsonConvert.DeserializeObject<clsUserDTO>(UserDataStringAsJson);

                    return new clsUser(UserDTO, clsReturnResult.enReturnResult.Found);
                }

                return InvalidUserInstance(clsRequestSettings.ConvertToReturnResult(Response.StatusCode));

            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return InvalidUserInstance(clsReturnResult.enReturnResult.Exception);
            }
        }

        private async Task<clsReturnResult> AddNewUser()
        {
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                return new clsReturnResult(clsReturnResult.enReturnResult.InvalidInputs);

            try
            {
                string UserDataAsJson = JsonConvert.SerializeObject(new clsAddUserDTO(this.UserName, this.Password, this.Permissions, this.IsActive, this.CreatedBy));

                StringContent Content = new StringContent(UserDataAsJson, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage Response = await clsRequestSettings.Request.PostAsync(clsRequestPaths.AddUser, Content);

                string ResponseBody = await Response.Content.ReadAsStringAsync();

                if (Response.IsSuccessStatusCode)
                {
                    Task LogActivity = clsRecentActivatesLogger.LogTheActivityAsync(clsRecentActivatesLogger.enActivates.NewUserAdded);

                    UserID = JsonConvert.DeserializeObject<short>(ResponseBody);

                    //Change state and mode to exist instance
                    State = clsReturnResult.enReturnResult.Found;
                    Mode = clsClassModes.enClassMode.Update;

                    await LogActivity;

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

        private async Task<clsReturnResult> UpdateUserByUserID()
        {
            if (Permissions <= 0 || Permissions > 4 ||
                string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                return new clsReturnResult(clsReturnResult.enReturnResult.InvalidInputs);

            try
            {
                string UserDataAsJson = JsonConvert.SerializeObject(new clsUpdateUserDTO(UserID, UserName, Password, Permissions, IsActive));
                StringContent Content = new StringContent(UserDataAsJson, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage Response = await clsRequestSettings.Request.PutAsync(clsRequestPaths.UpdateUser, Content);

                if (Response.IsSuccessStatusCode)
                {
                    await clsRecentActivatesLogger.LogTheActivityAsync(clsRecentActivatesLogger.enActivates.UserUpdated);

                    //Update the state
                    State = clsReturnResult.enReturnResult.Found;

                    return new clsReturnResult(clsReturnResult.enReturnResult.Success);
                }

                if (Response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                {
                    return new clsReturnResult(clsReturnResult.enReturnResult.ServerError, await Response.Content.ReadAsStringAsync());
                }

                return new clsReturnResult(clsRequestSettings.ConvertToReturnResult(Response.StatusCode));
            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return new clsReturnResult(clsReturnResult.enReturnResult.Exception);
            }
        }

        public static async Task<clsReturnResult.enReturnResult> DeleteUserByUserID(short ID)
        {
            if (ID <= 0)
                return clsReturnResult.enReturnResult.InvalidInputs;

            try
            {

                HttpResponseMessage Response = await clsRequestSettings.Request.DeleteAsync(clsRequestPaths.DeleteUser + $"/{ID}");

                if (Response.IsSuccessStatusCode)
                {
                    await clsRecentActivatesLogger.LogTheActivityAsync(clsRecentActivatesLogger.enActivates.UserDeleted);
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
                    return await AddNewUser();
                case clsClassModes.enClassMode.Update:
                    return await UpdateUserByUserID();
                default:
                    return new clsReturnResult(clsReturnResult.enReturnResult.None);
            }
        }



        public bool IsUserHasPermission(enOperations operation)
        {
            if (Role == clsRoles.enRole.None || !IsActive)
                return false;

            if (Role == clsRoles.enRole.Owner)
                return true;

            if (Role == clsRoles.enRole.Employee)
            {
                return operation == enOperations.AddSells
                    || operation == enOperations.ShowStocks
                    || operation == enOperations.ShowSales;
            }

            if (Role == clsRoles.enRole.Admin)
            {
                return operation == enOperations.ShowSales
                    || operation == enOperations.ShowStocks
                    || operation == enOperations.ShowUsers
                    || operation == enOperations.AddUsers
                    || operation == enOperations.UpdateUsers
                    || operation == enOperations.AddStocks
                    || operation == enOperations.UpdateStocks
                    || operation == enOperations.UpdateSells
                    || operation == enOperations.AddSells;
            }

            return false;
        }

        private static clsUser InvalidUserInstance(clsReturnResult.enReturnResult State)
        {
            return new clsUser(-1, string.Empty, string.Empty, 0, false, null, State);
        }

        public static byte ConvertRoleFromStringToByte(string Role)
        {
            switch (Role)
            {
                case "Owner":
                    return 2;
                case "Admin":
                    return 3;
                case "Employee":
                    return 4;

                default:
                    return 1;
            }

        }

    }
}
