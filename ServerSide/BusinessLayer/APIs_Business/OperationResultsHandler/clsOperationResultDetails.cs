using APIsAccessData.ReturnResultHandler;


namespace APIs_Business.OperationResultsHandler
{
    public class clsOperationResultDetails
    {

        public string Reason { get; private set; }

        public enum enReturnResult { None = 0, Success, Exception, InvalidInputs, NotFound, Found };

        public enReturnResult State { get; private set; }



        private clsOperationResultDetails(string reason, enReturnResult state)
        {
            Reason = reason;
            State = state;
        }



        internal static enReturnResult ConvertToBusinessState(clsGeneralResult.enGeneralResult GeneralState)
        {
            switch (GeneralState)
            {
                case clsGeneralResult.enGeneralResult.Success:
                    return enReturnResult.Success;
                case clsGeneralResult.enGeneralResult.InvalidInputs:
                    return enReturnResult.InvalidInputs;
                case clsGeneralResult.enGeneralResult.Exception:
                    return enReturnResult.Exception;
                case clsGeneralResult.enGeneralResult.NotFound:
                    return enReturnResult.NotFound;
                case clsGeneralResult.enGeneralResult.Found:
                    return enReturnResult.Found;
                default:
                    return enReturnResult.None;
            }
        }



        internal static clsOperationResultDetails NonResult()
        {
            return new clsOperationResultDetails(string.Empty, enReturnResult.None);
        }



        // Users
        private static string _ConvertInvalidInputToString(clsUserOperationDetails.enInputError InputError)
        {
            switch (InputError)
            {
                case clsUserOperationDetails.enInputError.EmptyInstance:
                    return "Empty User";
                case clsUserOperationDetails.enInputError.EmptyPassword:
                    return "Empty Password";
                case clsUserOperationDetails.enInputError.EmptyUserName:
                    return "Empty User Name";
                case clsUserOperationDetails.enInputError.InvalidRole:
                    return "Invalid Role";
                case clsUserOperationDetails.enInputError.InvalidCreatorId:
                    return "Invalid Creator ID";
                case clsUserOperationDetails.enInputError.InvalidUserId:
                    return "Invalid User ID";
                default:
                    return "Unknown Error";
            }
        }

        private static string _ConvertInvalidsInputsToString(List<clsUserOperationDetails.enInputError> InvalidInputs)
        {
            string Reasons = "";
            int cErrors = InvalidInputs.Count;

            for (int Index = 0; Index < cErrors; Index++)
            {
                Reasons += _ConvertInvalidInputToString(InvalidInputs[Index]);

                if (Index + 1 != cErrors)
                    Reasons += ',';
            }

            return Reasons;
        }

        private static string _ConvertExceptionResultToString(clsUserOperationDetails.enDbException Exception)
        {
            switch (Exception)
            {
                case clsUserOperationDetails.enDbException.UserNameAlreadyExists:
                    return "User Name Is Used";
                case clsUserOperationDetails.enDbException.RoleNotFound:
                    return "Role Is Not Found";
                case clsUserOperationDetails.enDbException.CreatorNotFound:
                    return "Creator ID Is Not Found";
                case clsUserOperationDetails.enDbException.EmptyUserName:
                    return "User Name Is Empty";
                case clsUserOperationDetails.enDbException.EmptyPassword:
                    return "Password Is Empty";
                default:
                    return "Unknown Error";


            }

        }

        internal static clsOperationResultDetails ConvertFromDLResultToBSResult(clsUserOperationDetails OperationResult)
        {
            if (OperationResult == null)
                return NonResult();

            var BusinessState = ConvertToBusinessState(OperationResult.GeneralResult);

            if (BusinessState == clsOperationResultDetails.enReturnResult.InvalidInputs)
                return new clsOperationResultDetails(_ConvertInvalidsInputsToString(OperationResult.InputErrors), BusinessState);

            if (BusinessState == clsOperationResultDetails.enReturnResult.Exception)
                return new clsOperationResultDetails(_ConvertExceptionResultToString(OperationResult.DbException), BusinessState);


            return new clsOperationResultDetails(string.Empty, ConvertToBusinessState(OperationResult.GeneralResult));
        }


        // Stocks
        private static string _ConvertInvalidInputToString(clsStockOperationDetails.enInputError InputError)
        {
            switch (InputError)
            {
                case clsStockOperationDetails.enInputError.InvalidStockID:
                    return "Invalid Stock ID";
                case clsStockOperationDetails.enInputError.EmptyName:
                    return "Stock Name Is Empty";
                case clsStockOperationDetails.enInputError.InvalidAmount:
                    return "Invalid Amount";
                case clsStockOperationDetails.enInputError.InvalidPrice:
                    return "Invalid Price";
                case clsStockOperationDetails.enInputError.InvalidCost:
                    return "Invalid Cost";
                case clsStockOperationDetails.enInputError.InvalidAddedBy:
                    return "Invalid Added By ID";
                default:
                    return "Unknown Error";
            }
        }

        private static string _ConvertInvalidsInputsToString(List<clsStockOperationDetails.enInputError> InvalidInputs)
        {
            string Reasons = "";
            int cErrors = InvalidInputs.Count;

            for (int Index = 0; Index < cErrors; Index++)
            {
                Reasons += _ConvertInvalidInputToString(InvalidInputs[Index]);

                if (Index + 1 != cErrors)
                    Reasons += ',';
            }

            return Reasons;
        }

        private static string _ConvertExceptionResultToString(clsStockOperationDetails.enDbException Exception)
        {
            switch (Exception)
            {
                case clsStockOperationDetails.enDbException.EmptyName:
                    return "Stock Name Is Empty";
                case clsStockOperationDetails.enDbException.InvalidAmount:
                    return "Invalid Amount";
                case clsStockOperationDetails.enDbException.InvalidPrice:
                    return "Invalid Price";
                case clsStockOperationDetails.enDbException.InvalidCost:
                    return "Invalid Cost";
                case clsStockOperationDetails.enDbException.AddedByDoseNotExist:
                    return "Added By Is Not Found";
                case clsStockOperationDetails.enDbException.StockNameIsUsed:
                    return "Stock Name Is Used";
                default:
                    return "Unknown Error";
            }

        }

        internal static clsOperationResultDetails ConvertFromDLResultToBSResult(clsStockOperationDetails OperationResult)
        {
            if (OperationResult == null)
                return NonResult();

            var BusinessState = ConvertToBusinessState(OperationResult.GeneralResult);

            if (BusinessState == clsOperationResultDetails.enReturnResult.Success)
                return new clsOperationResultDetails(_ConvertInvalidsInputsToString(OperationResult.InputErrors), BusinessState);

            if (BusinessState == clsOperationResultDetails.enReturnResult.InvalidInputs)
                return new clsOperationResultDetails(_ConvertInvalidsInputsToString(OperationResult.InputErrors), BusinessState);

            if (BusinessState == clsOperationResultDetails.enReturnResult.Exception)
                return new clsOperationResultDetails(_ConvertExceptionResultToString(OperationResult.DbException), BusinessState);

            return new clsOperationResultDetails(string.Empty, BusinessState);
        }

        //Seles

        private static string _ConvertInvalidInputToString(clsSaleOperationResult.enInputError InputError)
        {
            switch (InputError)
            {
                case clsSaleOperationResult.enInputError.EmptyInstance:
                    return "Empty Instance";
                case clsSaleOperationResult.enInputError.InvalidDoneByID:
                    return "Invalid Done By ID";
                case clsSaleOperationResult.enInputError.EmptyBuyerList:
                    return "Empty Buyer List";
                default:
                    return "Unknown Error";
            }
        }

        private static string _ConvertInvalidsInputsToString(List<clsSaleOperationResult.enInputError> InvalidInputs)
        {
            string Reasons = "";
            int cErrors = InvalidInputs.Count;

            for (int Index = 0; Index < cErrors; Index++)
            {
                Reasons += _ConvertInvalidInputToString(InvalidInputs[Index]);

                if (Index + 1 != cErrors)
                    Reasons += ',';
            }

            return Reasons;
        }

        private static string _ConvertExceptionResultToString(clsSaleOperationResult.enDbException Exception)
        {
            switch (Exception)
            {
                case clsSaleOperationResult.enDbException.InvalidCost:
                    return "Invalid Cost";
                case clsSaleOperationResult.enDbException.EmptyBuyerList:
                    return "Empty Buyer List";
                case clsSaleOperationResult.enDbException.StockIsNotFound:
                    return "Stock/s Is/Are Not Found";
                case clsSaleOperationResult.enDbException.EnteredByIsNotFound:
                    return "Entered By Is Not Found";

                default:
                    return "Unknown Error";
            }

        }

        internal static clsOperationResultDetails ConvertFromDLResultToBSResult(clsSaleOperationResult OperationResult)
        {
            if (OperationResult == null)
                return NonResult();

            var BusinessState = ConvertToBusinessState(OperationResult.GeneralResult);

            if (BusinessState == clsOperationResultDetails.enReturnResult.Success)
                return new clsOperationResultDetails(_ConvertInvalidsInputsToString(OperationResult.InputErrors), BusinessState);

            if (BusinessState == clsOperationResultDetails.enReturnResult.InvalidInputs)
                return new clsOperationResultDetails(_ConvertInvalidsInputsToString(OperationResult.InputErrors), BusinessState);

            if (BusinessState == clsOperationResultDetails.enReturnResult.Exception)
                return new clsOperationResultDetails(_ConvertExceptionResultToString(OperationResult.DbException), BusinessState);

            return new clsOperationResultDetails(string.Empty, BusinessState);
        }


        //Sale Details
        private static string _ConvertInvalidInputToString(clsSaleDetailOperationResult.enInputError InputError)
        {
            switch (InputError)
            {
                case clsSaleDetailOperationResult.enInputError.InvalidSaleID:
                    return "Invalid Sale ID";

                case clsSaleDetailOperationResult.enInputError.InvalidSaleDetailID:
                    return "Invalid Sale Detail ID";

                case clsSaleDetailOperationResult.enInputError.InvalidStockID:
                    return "Invalid Stock ID";

                case clsSaleDetailOperationResult.enInputError.InvalidAmount:
                    return "Invalid Amount";

                case clsSaleDetailOperationResult.enInputError.InvalidCost:
                    return "Invalid Cost";

                case clsSaleDetailOperationResult.enInputError.InvalidEnterByID:
                    return "Invalid Entered By ID";

                default:
                    return "Unknown Error";
            }
        }

        private static string _ConvertInvalidsInputsToString(List<clsSaleDetailOperationResult.enInputError> InvalidInputs)
        {
            string Reasons = "";
            int cErrors = InvalidInputs.Count;

            for (int Index = 0; Index < cErrors; Index++)
            {
                Reasons += _ConvertInvalidInputToString(InvalidInputs[Index]);

                if (Index + 1 != cErrors)
                    Reasons += ',';
            }

            return Reasons;
        }

        private static string _ConvertExceptionResultToString(clsSaleDetailOperationResult.enDbException Exception)
        {
            switch (Exception)
            {
                case clsSaleDetailOperationResult.enDbException.SaleDetailNotFound:
                    return "There is not sale detail with this id";

                case clsSaleDetailOperationResult.enDbException.StockNotFound:
                    return "Stock is not found";

                case clsSaleDetailOperationResult.enDbException.InvalidAmount:
                    return "Invalid Amount";

                case clsSaleDetailOperationResult.enDbException.AmountIsBiggerThenWeHave:
                    return "The Amount is more then we have";

                case clsSaleDetailOperationResult.enDbException.SaleInfoNotFound:
                    return "Sale info is not found";

                case clsSaleDetailOperationResult.enDbException.BuyerListContainsThisStock:
                    return "The buyer list contains this stock";

                case clsSaleDetailOperationResult.enDbException.InvalidCost:
                    return "Invalid Cost";

                default:
                    return "Unknown Error";
            }

        }

        internal static clsOperationResultDetails ConvertFromDLResultToBSResult(clsSaleDetailOperationResult OperationResult)
        {
            if (OperationResult == null)
                return NonResult();

            var BusinessState = ConvertToBusinessState(OperationResult.GeneralResult);

            if (BusinessState == clsOperationResultDetails.enReturnResult.Success)
                return new clsOperationResultDetails(_ConvertInvalidsInputsToString(OperationResult.InputErrors), BusinessState);

            if (BusinessState == clsOperationResultDetails.enReturnResult.InvalidInputs)
                return new clsOperationResultDetails(_ConvertInvalidsInputsToString(OperationResult.InputErrors), BusinessState);

            if (BusinessState == clsOperationResultDetails.enReturnResult.Exception)
                return new clsOperationResultDetails(_ConvertExceptionResultToString(OperationResult.DbException), BusinessState);

            return new clsOperationResultDetails(string.Empty, BusinessState);
        }
    }
}
