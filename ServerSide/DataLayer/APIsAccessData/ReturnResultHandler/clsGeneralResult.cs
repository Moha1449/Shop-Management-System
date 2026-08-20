using Microsoft.IdentityModel.Protocols.OpenIdConnect.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAccessData.ReturnResultHandler
{
    public abstract class clsGeneralResult 
    {
        public enum enGeneralResult 
        {
            Success = 0,Exception, InvalidInputs, NotFound, Found, failed,None
        };

        public enGeneralResult GeneralResult { get; protected set; }

       
        public clsGeneralResult(enGeneralResult generalResult)
        {
            GeneralResult = generalResult;
        }
    }
}
