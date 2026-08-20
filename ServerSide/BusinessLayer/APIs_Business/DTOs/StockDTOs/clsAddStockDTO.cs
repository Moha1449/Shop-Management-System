namespace APIs_Business.DTOs.StockDTOs
{
    public class clsAddStockDTO
    {
        public string Name { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

        public double Cost { get; set; }

        public short AddedBy { get; set; }

        public clsAddStockDTO(string name, int amount, double price, double cost, short addedBy)
        {
            Name = name;
            Amount = amount;
            Price = price;
            Cost = cost;
            AddedBy = addedBy;
        }
    }
}
