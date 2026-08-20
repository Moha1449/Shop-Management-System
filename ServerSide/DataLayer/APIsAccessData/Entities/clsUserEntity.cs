using static APIsAccessData.Entities.clsEntityCall;


namespace APIsAccessData.Entities
{
    public class clsUserEntity
    {
        public short ID { get; private set; }

        public string UserName { get;private set; }

        public string Password { get; private set; }

        public byte Permissions { get; private set; }

        public bool IsActive { get; private set; }

        public short? CreatedBy { get; private set; }

        internal clsEntityCall.enCallingFor Call { get; private set; }

        private clsUserEntity(short id, string userName, string password, byte permissions, bool isactive, short? createdBy, clsEntityCall.enCallingFor mode)
        {
            ID = id;
            UserName = userName;
            Password = password;
            Permissions = permissions;
            IsActive = isactive;
            CreatedBy = createdBy;
            Call = mode;
        }



        public static clsUserEntity GetUserEntityInstance(short ID)
        {
            return new clsUserEntity(ID, string.Empty, string.Empty, 0, false, null, clsEntityCall.enCallingFor.Search);
        }


        public static clsUserEntity UpdateUserEntityInstance(short id, string userName, string password, byte permissions, bool isactive)
        {
            return new clsUserEntity(id, userName, password, permissions, isactive, null, clsEntityCall.enCallingFor.Update);
        }

        public static clsUserEntity AddUserEntityInstance(string userName, string password, byte permissions, bool isactive, short? createdBy)
        {
            return new clsUserEntity(-1, userName, password, permissions, isactive, createdBy, clsEntityCall.enCallingFor.Add);
        }

        internal void FoundUserEntityInstanceMutable(string userName, string password, byte permissions, bool isactive, short? createdBy, short id = -1)
        {
            this.ID = id;
            this.UserName = userName;
            this.Password = password;
            this.Permissions = permissions;
            this.IsActive = isactive;
            this.CreatedBy = createdBy;
            this.Call = enCallingFor.Update;
        }

        internal static clsUserEntity FoundUserEntityInstanceImmutable(short id, string userName, string password, byte permissions, bool isactive, short? createdBy)
        {
            return new clsUserEntity(id, userName, password, permissions, isactive, createdBy, clsEntityCall.enCallingFor.Update);
        }

        public static clsUserEntity LoginEntityInstance(string userName, string Password)
        {
            return new clsUserEntity(-1, userName, Password, 1, false, null, enCallingFor.Search);
        }

        internal static clsUserEntity InvalidUserEntityInstance()
        {
            return new clsUserEntity(-1, string.Empty, string.Empty, 0, false, null, clsEntityCall.enCallingFor.Invalid);
        }

        internal void SetID(short ID)
        {
            if (Call != enCallingFor.Add) return;

            this.ID = ID;
        }
    }
}
