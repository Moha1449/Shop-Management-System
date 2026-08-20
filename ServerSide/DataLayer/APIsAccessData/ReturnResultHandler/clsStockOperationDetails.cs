using APIsAccessData.Entities;


namespace APIsAccessData.ReturnResultHandler
{
    public class clsStockOperationDetails : clsGeneralResult
    {
        public enum enInputError
        {
            InvalidStockID,
            EmptyName,
            InvalidAmount,
            InvalidPrice,
            InvalidCost,
            InvalidAddedBy,
            EmptyInstance
        }

        public enum enDbException
        {
            None = 0,
            AddedByDoseNotExist = 50010,
            EmptyName = 50006,
            InvalidAmount = 50009,
            InvalidPrice = 50008,
            InvalidCost = 50007,
            StockNameIsUsed = 50011
        }


        public bool IsDataInvalid { get; private set; }

        public enDbException DbException { get; private set; }

        public List<enInputError> InputErrors { get; private set; }



        public clsStockOperationDetails(int errorNumber) : base(enGeneralResult.Exception)
        {
            DbException = (errorNumber <= 0 || errorNumber < 50000) ? enDbException.None : (enDbException)errorNumber;
            IsDataInvalid = false;
            InputErrors = new List<enInputError>();
        }

        public clsStockOperationDetails(List<enInputError> InvalidsInputs) : base(enGeneralResult.InvalidInputs)
        {
            DbException = enDbException.None;
            IsDataInvalid = true;
            InputErrors = InvalidsInputs;
        }

        public clsStockOperationDetails(enGeneralResult Result) : base(Result)
        {
            DbException = enDbException.None;
            IsDataInvalid = false;
            InputErrors = new List<enInputError>();
        }


        internal static clsStockOperationDetails IsEntityDataValid(clsStockEntity Entity)
        {
            if (Entity == null)
                return new clsStockOperationDetails(
                    new List<enInputError> { enInputError.EmptyInstance });

            List<enInputError> InvalidInputs = new List<enInputError>();

            if (string.IsNullOrEmpty(Entity.Name))
                InvalidInputs.Add(enInputError.EmptyName);

            if (Entity.Amount < 0)
                InvalidInputs.Add(enInputError.InvalidAmount);

            if (Entity.Price < 0)
                InvalidInputs.Add(enInputError.InvalidPrice);

            if (Entity.Cost < 0)
                InvalidInputs.Add(enInputError.InvalidCost);

            if (Entity.CallFor == clsEntityCall.enCallingFor.Add && Entity.AddedBy <= 0)
                InvalidInputs.Add(enInputError.InvalidAddedBy);

            if (Entity.CallFor == clsEntityCall.enCallingFor.Update && Entity.ID <= 0)
                InvalidInputs.Add(enInputError.InvalidStockID);

            if (InvalidInputs.Count > 0)
                return new clsStockOperationDetails(InvalidInputs);

            return new clsStockOperationDetails(enGeneralResult.None);
        }
    }
}
