
namespace ClientSideBusinessLayer.DTOs.StockDTO
{
    public class clsStockDTO
    {

        public short ID { get; set; }

        public string Name { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

        public double Cost { get; set; }

        public short AddedBy { get; set; }


        public clsStockDTO(short iD, string name, int amount, double price, double cost, short addedBy)
        {
            ID = iD;
            Name = name;
            Amount = amount;
            Price = price;
            Cost = cost;
            AddedBy = addedBy;
        }
    }
}
