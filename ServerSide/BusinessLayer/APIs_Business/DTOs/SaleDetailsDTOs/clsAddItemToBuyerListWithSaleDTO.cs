namespace APIs_Business.DTOs.SaleDetailsDTOs
{
    public class clsAddItemToBuyerListWithSaleDTO
    {
        public short StockID { get; set; }

        public int Amount { get; set; }

        public double TotalCost { get; set; }

        public clsAddItemToBuyerListWithSaleDTO(short stockID, int amount, double totalCost)
        {
            StockID = stockID;
            Amount = amount;
            TotalCost = totalCost;
        }
    }
}
