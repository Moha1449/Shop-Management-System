namespace ClientSideBusinessLayer.DTOs.StockDTO
{
    public class clsUpdateStockDTO
    {
        public short ID { get; set; }

        public string Name { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

        public double Cost { get; set; }


        public clsUpdateStockDTO(short id, string name, int amount, double price, double cost)
        {
            ID = id;
            Name = name;
            Amount = amount;
            Price = price;
            Cost = cost;
        }
    }
}
