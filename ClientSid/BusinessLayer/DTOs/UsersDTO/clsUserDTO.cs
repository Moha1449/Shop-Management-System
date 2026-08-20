

namespace ClientSideBusinessLayer.DTOs
{
   public class clsUserDTO
    {
        public short UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public byte Permissions { get; set; }

        public bool IsActive { get; set; }

        public short?CreatedBy { get; set; }

        public clsUserDTO(short userID, string userName, string password, byte permissions, bool isActive, short? createdBy)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            Permissions = permissions;
            IsActive = isActive;
            CreatedBy = createdBy;
        }
    }
}
