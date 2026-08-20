using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSideBusinessLayer.DTOs
{
    public class clsLoginDTO
    {

        public string UserName { get; set; }

        public string Password { get; set; }

        public clsLoginDTO(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
