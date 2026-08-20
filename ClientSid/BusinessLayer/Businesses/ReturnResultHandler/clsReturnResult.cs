

namespace ClientSideBusinessLayer
{
    public  class clsReturnResult
    {
        public enum enReturnResult { None=0,Success  , InvalidInputs,Exception,NotFound,Found,ServerError,Empty}   

        public enReturnResult State { get; private set; }

        public string Error { get ; private set; }

        public clsReturnResult(enReturnResult state, string error = "")
        {
            State = state;
            Error = error;
        }
    }
}
