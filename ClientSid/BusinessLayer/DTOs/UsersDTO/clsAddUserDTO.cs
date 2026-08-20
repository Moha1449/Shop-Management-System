using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSideBusinessLayer.DTOs.UsersDTO
{
    public class clsAddUserDTO
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public byte Permissions { get; set; }

        public bool IsActive { get; set; }

        public short? CreatedBy { get; set; }

        public clsAddUserDTO(string userName, string password, byte permissions, bool isActive, short? createdBy)
        {
            UserName = userName;
            Password = password;
            Permissions = permissions;
            IsActive = isActive;
            CreatedBy = createdBy;
        }
    }
}
