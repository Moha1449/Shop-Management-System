using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs_Business.DTOs.UsersDTOs
{
    public class clsAddUserDTO
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public byte Permissions { get; set; }

        public bool IsActive { get; set; }

        public short? CreatedBy { get; set; }

        public clsAddUserDTO(string username, string password,byte permissions, bool isactive, short? createdBy)
        {
            UserName = username;
            Password = password;
            Permissions = permissions;
            IsActive = isactive;
            CreatedBy = createdBy;
        }
    }
}
