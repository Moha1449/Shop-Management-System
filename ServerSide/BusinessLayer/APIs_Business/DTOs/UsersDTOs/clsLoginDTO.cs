using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs_Business.DTOs.UsersDTOs
{
    public class clsLoginDTO
    {
      public  string UserName { get; set; }

        public string Password { get; set; }

        public clsLoginDTO(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
