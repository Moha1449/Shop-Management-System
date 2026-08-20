using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSideBusinessLayer.DTOs.UsersDTO
{
    public class clsUpdateUserDTO
    {
        public short UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public byte Permissions { get; set; }

        public bool IsActive { get; set; }

        public clsUpdateUserDTO(short userid, string username, string password, byte permissions, bool isactive)
        {
            UserID = userid;
            UserName = username;
            Password = password;
            Permissions = permissions;
            IsActive = isactive;
        }
    }
}
