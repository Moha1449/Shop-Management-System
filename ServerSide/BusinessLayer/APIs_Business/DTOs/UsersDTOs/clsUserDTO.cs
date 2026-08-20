using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs_Business.DTOs.UsersDTOs
{
   public  class clsUserDTO
    {
        public short UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public byte Permissions { get; set; }

        public bool IsActive { get; set; }

        public short? CreatedBy { get; set; }

        public clsUserDTO(short userid, string username, string password, byte permissions, bool isactive, short? createdBy)
        {
            UserID = userid;
            UserName = username;
            Password = password;
            Permissions = permissions;
            IsActive = isactive;
            CreatedBy = createdBy;
        }
    }
}
