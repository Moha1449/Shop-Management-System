using System.Data;
using System.Security.AccessControl;

namespace APIsAccessData.Entities
{
    public class clsSaleDetailEntity
    {
        public int DetailID { get; set; }

        public int SaleID { get; set; }

        public short EnteredByID { get; set; }

        public short StockID { get; set; }

        public string StockName { get; set; }

        public string EnteredByName { get; set; }

        public int Quantity { get; set; }

        public double Cost { get; set; }

        internal clsEntityCall.enCallingFor CallingFor { get; private set; }

        private clsSaleDetailEntity(int detailID, int saleID, short enteredByID, short stockID, string stockName, string enteredByName, int quantity, double cost, clsEntityCall.enCallingFor call)
        {
            DetailID = detailID;
            SaleID = saleID;
            EnteredByID = enteredByID;
            StockID = stockID;
            StockName = stockName;
            EnteredByName = enteredByName;
            Quantity = quantity;
            Cost = cost;
            CallingFor = call;
        }

        internal static clsSaleDetailEntity FoundSaleDetailInstance(int detailID, int saleID, short enteredByID, short stockID, string stockName, string enteredByName, int quantity, double cost)
        {
            return new clsSaleDetailEntity(detailID, saleID, enteredByID, stockID, stockName, enteredByName, quantity, cost, clsEntityCall.enCallingFor.Search);
        }

        public static clsSaleDetailEntity AddNewSale(short EnterByID, short stockID,int quantity, double cost)
        {
            return new clsSaleDetailEntity(-1,-1,EnterByID,stockID,string.Empty,string.Empty,quantity,cost,clsEntityCall.enCallingFor.Add);
        }
        
        public static clsSaleDetailEntity UpdateAmountSaleDetailInstance(int SaleDetailID, int SaleID, int Amount, short StockID)
        {
            return new clsSaleDetailEntity(SaleDetailID, SaleID, -1, StockID
                , string.Empty, string.Empty, Amount, 0d, clsEntityCall.enCallingFor.Update);
        }

        public static clsSaleDetailEntity AddItemDetailInstance(int saleID, short enteredByID, short stockID, int quantity, double cost)
        {
            return new clsSaleDetailEntity(-1, saleID, enteredByID, stockID, string.Empty,
                string.Empty, quantity, cost, clsEntityCall.enCallingFor.Add);
        }


        internal static DataTable BuyerListMaker(List<clsSaleDetailEntity> Entities)
        {
            DataTable BuyerList = new DataTable();

            BuyerList.Columns.Add("stock_id", typeof(short));
            BuyerList.Columns.Add("amount", typeof(int));
            BuyerList.Columns.Add("total_cost", typeof(double));

            if (Entities == null)
                return BuyerList;

            foreach (clsSaleDetailEntity entity in Entities)
            {
                BuyerList.Rows.Add(entity.StockID, entity.Quantity, entity.Cost);
            }

            return BuyerList;
        }
    }
}
