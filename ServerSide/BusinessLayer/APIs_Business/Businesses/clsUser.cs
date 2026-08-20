using APIs_Business.DTOs.UsersDTOs;
using APIs_Business.OperationResultsHandler;
using APIsAccessData.DataProviders;
using APIsAccessData.Entities;
using System.Runtime.CompilerServices;




namespace APIs_Business.Businesses
{
    public sealed class clsUser
    {
        public short UserID {  get; private set; }
       
        public string UserName { get; set; }

        public string Password { get; set; }

        public byte Permissions { get; set; }

        public bool IsActive { get; set; }

        public short? CreatedBy { get; set; }

        public clsUserDTO UserDTO { get { return new clsUserDTO(UserID, UserName, Password, Permissions,IsActive,CreatedBy); } }

        public clsOperationResultDetails.enReturnResult  GeneralResult { get; private set; }

        private clsClassesModes.enClassMode _Mode { get; set; }

        

        private clsUser(short userID, string username, string password,byte permissions, bool isActive, short? createdBy, clsOperationResultDetails.enReturnResult state)
        {
            UserID = userID;
            UserName = username;
            Password = password;
            Permissions = permissions;
            IsActive = isActive;
            _Mode = clsClassesModes.enClassMode.Update;
            GeneralResult = state;
            CreatedBy = createdBy;
        }

        public clsUser(clsAddUserDTO NewUser)
        {
            UserID = -1;
            UserName = NewUser.UserName;
            Password = NewUser.Password;
            Permissions = NewUser.Permissions;
            IsActive = NewUser.IsActive;
            CreatedBy = NewUser.CreatedBy;
            _Mode = clsClassesModes.enClassMode.Add;
            GeneralResult = clsOperationResultDetails.enReturnResult.None;
        }
        

        public static async Task<(clsOperationResultDetails.enReturnResult,List<clsUserDTO>)> GetAllUsersAsync()
        {
            List<clsUserEntity> UsersEntities = new List<clsUserEntity> ();

            var GetResult =clsOperationResultDetails.ConvertToBusinessState(await clsUsersDataProvider.GetAllUsersAsync( UsersEntities));

            if (GetResult != clsOperationResultDetails.enReturnResult.Success)
                return (GetResult,new List<clsUserDTO>());

            return (GetResult, UsersEntities.Select
                (UserEntity => new clsUserDTO(UserEntity.ID, UserEntity.UserName, UserEntity.Password, UserEntity
                .Permissions, UserEntity.IsActive, UserEntity.CreatedBy)).ToList());
        }

        public static async Task<clsUser> GetUserByUserIDAsync(short UserID)
        {
            clsUserEntity UserEntity = clsUserEntity.GetUserEntityInstance(UserID);

            clsOperationResultDetails.enReturnResult GetResult = clsOperationResultDetails.
                ConvertToBusinessState(await clsUsersDataProvider.GetUserByUserIDAsync(UserEntity));

             if(GetResult == clsOperationResultDetails.enReturnResult.Success)
                return new clsUser(UserID, UserEntity.UserName, UserEntity.Password,
                    UserEntity.Permissions, UserEntity.IsActive, UserEntity.CreatedBy,
                   GetResult);


            return InvalidStatesUserInstance(GetResult);
        }
         
        private async Task<clsOperationResultDetails> AddNewUserAsync() 
        {
        
            clsUserEntity NewUserEntity = clsUserEntity.AddUserEntityInstance(UserName, Password, Permissions, IsActive, CreatedBy);

            clsOperationResultDetails AddResult = clsOperationResultDetails.
                ConvertFromDLResultToBSResult(await clsUsersDataProvider.AddNewUserAsync(NewUserEntity));

            if(AddResult.State == clsOperationResultDetails.enReturnResult.Success)
                this.UserID = NewUserEntity.ID;

            this.GeneralResult = AddResult.State;

            return AddResult;
        }

        private async Task<clsOperationResultDetails> UpdateUserByUserIDAsync()
        {
            clsUserEntity User = clsUserEntity.UpdateUserEntityInstance(UserID, UserName, Password, Permissions,IsActive);

            clsOperationResultDetails UpdateResult = clsOperationResultDetails.
                ConvertFromDLResultToBSResult(await clsUsersDataProvider.UpdateUserByUserIDAsync(User));

            this.GeneralResult = UpdateResult.State;

            return UpdateResult;
        }

        public static async Task<clsOperationResultDetails.enReturnResult> DeleteUserByUserIDAsync(short ID)
        {
          return clsOperationResultDetails.
                ConvertToBusinessState(await clsUsersDataProvider.DeleteUserByUserIDAsync(ID));
        }

        public static async Task<clsUser> LoginUsingUserNameAndPasswordAsync(clsLoginDTO LoginData)
        {
            clsUserEntity UserEntity = clsUserEntity.LoginEntityInstance(LoginData.UserName, LoginData.Password);

            var LoginResult = clsOperationResultDetails.
                ConvertToBusinessState(await clsUsersDataProvider.LoginUsingUserNameAndPasswordAsync(UserEntity));  

            if (LoginResult == clsOperationResultDetails.enReturnResult.Success)
                return new clsUser(UserEntity.ID, UserEntity.UserName, UserEntity.Password,
                    UserEntity.Permissions, UserEntity.IsActive, UserEntity.CreatedBy,
                    LoginResult);

            return InvalidStatesUserInstance(LoginResult);
        }

        public async Task<clsOperationResultDetails> SaveAsync()
        {
            switch (_Mode)
            {
                case clsClassesModes.enClassMode.Add:
                    {
                        return await AddNewUserAsync();
                    }
                case clsClassesModes.enClassMode.Update:
                    {
                        return await UpdateUserByUserIDAsync();
                    }
            }

            return clsOperationResultDetails.NonResult();
        }





        private static clsUser InvalidStatesUserInstance(clsOperationResultDetails.enReturnResult State)
        {
            return new clsUser(-1, string.Empty, string.Empty,0, false,null,State);
        }
    }
}

