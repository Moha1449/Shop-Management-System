namespace APIs_Business.DTOs.StockDTOs
{
    public class clsStockDTO
    {
        public short ID { get; set; }

        public string Name { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

        public double Cost { get; set; }

        public short AddedBy { get; set; }

        public clsStockDTO(short id, string name, int amount, double price, double cost, short addedBy)
        {
            ID = id;
            Name = name;
            Amount = amount;
            Price = price;
            Cost = cost;
            AddedBy = addedBy;
        }
    }
}
