

namespace ClientSideBusinessLayer.DTOs.SaleDetailsDTO
{
    public class clsAddItemToBuyerListDTO
    {
        public int SaleID { get; set; }

        public short EnteredByID { get; set; }

        public short StockID { get; set; }

        public int Quantity { get; set; }

        public double Cost { get; set; }

        public clsAddItemToBuyerListDTO(int saleID, short enteredByID, short stockID, int quantity, double cost)
        {
            SaleID = saleID;
            EnteredByID = enteredByID;
            StockID = stockID;
            Quantity = quantity;
            Cost = cost;
        }
    }
}

