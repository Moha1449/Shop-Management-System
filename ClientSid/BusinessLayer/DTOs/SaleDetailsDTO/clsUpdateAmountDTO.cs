

namespace ClientSideBusinessLayer.DTOs.SaleDetailsDTO
{
    public class clsUpdateAmountDTO
    {
        public int SaleDetailID { get; set; }

        public int SaleID { get; set; }

        public short StockID { get; set; }

        public int Amount { get; set; }

        public clsUpdateAmountDTO(int saleDetailID, int saleID, short stockID, int amount)
        {
            SaleDetailID = saleDetailID;
            SaleID = saleID;
            StockID = stockID;
            Amount = amount;
        }
    }
}
