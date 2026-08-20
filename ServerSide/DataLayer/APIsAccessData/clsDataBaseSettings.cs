using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAccessData
{
  internal static class clsDataBaseSettings
  {
     internal static string ConnectionString 
        { 
            get
            {
                return "Server=.;Database=ShopManagementDB;User Id=sa;Password=sa123456;TrustServerCertificate=True;"; 
            } 
        }  

  }
}
