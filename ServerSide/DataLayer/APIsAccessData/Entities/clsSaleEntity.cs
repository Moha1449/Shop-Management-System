using static APIsAccessData.Entities.clsEntityCall;

namespace APIsAccessData.Entities
{
    public class clsSaleEntity
    {
        public int ID { get; private set; }

        public double TotalPrice { get; private set; }

        public DateTime PayDate { get; private set; }

        public string DoneByName { get; private set; }

        public short DoneByID { get; private set; }

        public List<clsSaleDetailEntity> BuyerList { get; private set; }

        internal clsEntityCall.enCallingFor Call { get; private set; }

        private clsSaleEntity(int iD, double totalPrice, DateTime payDate, short doneByID, string doneByName, List<clsSaleDetailEntity> buyerList, enCallingFor call)
        {
            ID = iD;
            TotalPrice = totalPrice;
            PayDate = payDate;
            DoneByName = doneByName;
            DoneByID = doneByID;
            BuyerList = buyerList;
            Call = call;
        }

        internal void SetID(int id)
        {
            if (Call != enCallingFor.Add) return;

            ID = id;
        }

        public static clsSaleEntity GetSaleEntity(int id)
        {
            return new clsSaleEntity(id, 0d, DateTime.Now, -1, string.Empty, null, clsEntityCall.enCallingFor.Search);
        }

        public void FoundSaleEntityBySaleID(double totalPrice, DateTime payDate, short doneByID, string doneByName)
        {
            this.TotalPrice = totalPrice;
            this.PayDate = payDate;
            this.DoneByID = doneByID;
            this.DoneByName = doneByName;
            this.Call = enCallingFor.Update;
        }

        public static clsSaleEntity AddSellEntityInstance(double totalPrice, DateTime payDate, short doneByID, List<clsSaleDetailEntity> buyerList)
        {
            return new clsSaleEntity(-1, totalPrice, DateTime.Now, doneByID, string.Empty, buyerList, enCallingFor.Add);
        }

        internal static clsSaleEntity FoundSellEntityInstance(int iD, double totalPrice, DateTime payDate, short doneByID, string doneByName)
        {
            return new clsSaleEntity(iD, totalPrice, payDate, doneByID, doneByName, null, enCallingFor.Update);
        }
    }
}
