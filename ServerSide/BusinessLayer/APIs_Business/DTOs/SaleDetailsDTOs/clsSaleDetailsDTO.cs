

namespace APIs_Business.DTOs.SaleDetailsDTOs
{
   public class clsSaleDetailsDTO
    {
        public int DetailID { get; set; }

        public int SaleID { get; set; }

        public short EnteredByID { get; set; }

        public short StockID { get; set; }

        public string StockName { get; set; }

        public string EnteredByName { get; set; }

        public int Quantity { get; set; }

        public double Cost { get; set; }

        public clsSaleDetailsDTO(int detailID, int saleID, short enteredByID, short stockID, string stockName, string enteredByName, int quantity, double cost)
        {
            DetailID = detailID;
            SaleID = saleID;
            EnteredByID = enteredByID;
            StockID = stockID;
            StockName = stockName;
            EnteredByName = enteredByName;
            Quantity = quantity;
            Cost = cost;
        }

    }
}
