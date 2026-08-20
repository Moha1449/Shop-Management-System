using APIsAccessData.Entities;

namespace APIsAccessData.ReturnResultHandler
{
    public class clsSaleOperationResult : clsGeneralResult
    {
        public enum enInputError
        {
            EmptyInstance,
            InvalidDoneByID,
            EmptyBuyerList,
            InvalidCost
        }

        public enum enDbException
        {
            None = 0,
            EnteredByIsNotFound = 50015,
            InvalidCost = 50012,
            EmptyBuyerList = 50013,
            StockIsNotFound = 50014,
            SaleNotFound = 50023
        }


        public enDbException DbException { get; private set; }

        public List<enInputError> InputErrors { get; private set; }

        public bool IsDataInvalid { get; private set; }


        public clsSaleOperationResult(int errorNumber) : base(enGeneralResult.Exception)
        {
            DbException = (errorNumber <= 0 || errorNumber < 50000) ? enDbException.None : (enDbException)errorNumber;
            IsDataInvalid = false;
            InputErrors = new List<enInputError>();
        }

        public clsSaleOperationResult(List<enInputError> InvalidsInputs) : base(enGeneralResult.InvalidInputs)
        {
            DbException = enDbException.None;
            IsDataInvalid = true;
            InputErrors = InvalidsInputs;
        }

        public clsSaleOperationResult(enGeneralResult Result) : base(Result)
        {
            DbException = enDbException.None;
            IsDataInvalid = false;
            InputErrors = new List<enInputError>();
        }


        internal static clsSaleOperationResult IsEntityDataValid(clsSaleEntity Entity)
        {
            if (Entity == null)
                return new clsSaleOperationResult(
                    new List<enInputError> { enInputError.EmptyInstance });

            List<enInputError> InvalidInputs = new List<enInputError>();

            if (Entity.DoneByID <= 0)
                InvalidInputs.Add(enInputError.InvalidDoneByID);

            if (Entity.TotalPrice <= 0)
                InvalidInputs.Add(enInputError.InvalidCost);

            if (Entity.BuyerList == null || Entity.BuyerList.Count == 0)
                InvalidInputs.Add(enInputError.EmptyBuyerList);

            if (InvalidInputs.Count > 0)
                return new clsSaleOperationResult(InvalidInputs);

            return new clsSaleOperationResult(clsGeneralResult.enGeneralResult.None);
        }
    }
}
