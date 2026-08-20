using APIsAccessData.Entities;


namespace APIsAccessData.ReturnResultHandler
{
    public class clsUserOperationDetails : clsGeneralResult
    {
        public enum enInputError
        {
            EmptyInstance,
            EmptyPassword,
            EmptyUserName,
            InvalidRole,
            InvalidCreatorId,
            InvalidUserId
        }

        public enum enDbException
        {
            None = 0,
            UserNameAlreadyExists = 50002,
            RoleNotFound = 50001,
            CreatorNotFound = 50003,
            EmptyUserName = 50004,
            EmptyPassword = 50005,
        }



        public bool IsDataInvalid { get; private set; }

        public enDbException DbException { get; private set; }

        public List<enInputError> InputErrors { get; private set; }



        public clsUserOperationDetails(int errorNumber) : base(enGeneralResult.Exception)
        {
            DbException = DbException = (errorNumber <= 0 || errorNumber < 50000) ? 
                enDbException.None : (enDbException)errorNumber;

            IsDataInvalid = false;
            InputErrors = new List<enInputError>();
        }

        public clsUserOperationDetails(List<enInputError> InvalidsInputs) : base(enGeneralResult.InvalidInputs)
        {
            DbException = enDbException.None;
            IsDataInvalid = true;
            InputErrors = InvalidsInputs;
        }

        public clsUserOperationDetails(enGeneralResult Result) : base(Result)
        {
            DbException = enDbException.None;
            IsDataInvalid = false;
            InputErrors = new List<enInputError>();
        }



        internal static clsUserOperationDetails IsEntityDataValid(clsUserEntity Entity)
        {
            if (Entity == null)
                return new clsUserOperationDetails(new List<enInputError> { enInputError.EmptyInstance });

            if (Entity.Call == clsEntityCall.enCallingFor.Search && Entity.ID <= 0)
                return new clsUserOperationDetails(new List<enInputError> { enInputError.InvalidUserId });

            List<enInputError> InvalidInputs = new List<enInputError>();

            if (string.IsNullOrEmpty(Entity.UserName))
                InvalidInputs.Add(enInputError.EmptyUserName);

            if (string.IsNullOrEmpty(Entity.Password))
                InvalidInputs.Add(enInputError.EmptyPassword);

            if (Entity.CreatedBy <= 0)
                InvalidInputs.Add(enInputError.InvalidCreatorId);

            if (Entity.Call == clsEntityCall.enCallingFor.Update && Entity.ID <= 0)
                InvalidInputs.Add(enInputError.InvalidUserId);

            return InvalidInputs.Count > 0
                ? new clsUserOperationDetails(InvalidInputs)
                : new clsUserOperationDetails(enGeneralResult.None);
        }

    }
}

