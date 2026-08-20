using APIsAccessData.Entities;


namespace APIsAccessData.ReturnResultHandler
{
    public class clsSaleDetailOperationResult : clsGeneralResult
    {
        public enum enInputError
        {
            InvalidSaleID,
            InvalidSaleDetailID,
            EmptyInstance,
            InvalidCost,
            InvalidAmount,
            InvalidStockID,
            InvalidEnterByID
        }

        public enum enDbException
        {
            None = 0,
            SaleDetailNotFound = 50016,
            StockNotFound = 50018,
            InvalidAmount = 50017,
            AmountIsBiggerThenWeHave = 50019,
            SaleInfoNotFound = 50020,
            BuyerListContainsThisStock = 50021,
            InvalidCost = 50022
        }

        public enDbException DbException { get; private set; }

        public bool IsDataInvalid { get; private set; }

        public List<enInputError> InputErrors { get; private set; }



        public clsSaleDetailOperationResult(int errorNumber) : base(enGeneralResult.Exception)
        {
            DbException = DbException = (errorNumber <= 0 || errorNumber < 50000) ? enDbException.None : (enDbException)errorNumber;
            IsDataInvalid = false;
            InputErrors = new List<enInputError>();
        }

        public clsSaleDetailOperationResult(List<enInputError> InvalidsInputs) : base(enGeneralResult.InvalidInputs)
        {
            DbException = enDbException.None;
            IsDataInvalid = true;
            InputErrors = InvalidsInputs;
        }

        public clsSaleDetailOperationResult(enGeneralResult Result) : base(Result)
        {
            DbException = enDbException.None;
            IsDataInvalid = false;
            InputErrors = new List<enInputError>();
        }


        internal static clsSaleDetailOperationResult IsEntityDataValid(clsSaleDetailEntity Entity)
        {
            if (Entity == null)
                return new clsSaleDetailOperationResult(new List<enInputError> { enInputError.EmptyInstance });

            List<enInputError> InvalidInputs = new List<enInputError>();

            if (Entity.StockID <= 0)
                InvalidInputs.Add(enInputError.InvalidStockID);

            if (Entity.SaleID <= 0)
                InvalidInputs.Add(enInputError.InvalidSaleID);

            if (Entity.Quantity <= 0)
                InvalidInputs.Add(enInputError.InvalidAmount);

            if (Entity.CallingFor == clsEntityCall.enCallingFor.Update)
            {
                if (Entity.DetailID <= 0)
                    InvalidInputs.Add(enInputError.InvalidSaleDetailID);
            }
            else
            {
                if (Entity.EnteredByID <= 0)
                    InvalidInputs.Add(enInputError.InvalidEnterByID);

                if (Entity.Cost <= 0)
                    InvalidInputs.Add(enInputError.InvalidCost);
            }

            return InvalidInputs.Count > 0
                ? new clsSaleDetailOperationResult(InvalidInputs)
                : new clsSaleDetailOperationResult(enGeneralResult.None);
        }
    }
}
