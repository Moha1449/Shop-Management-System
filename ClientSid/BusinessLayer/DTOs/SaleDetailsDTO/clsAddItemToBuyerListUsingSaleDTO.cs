using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSideBusinessLayer.DTOs.SaleDetailsDTO
{
    public class clsAddItemToBuyerListUsingSaleDTO
    {
        public short StockID { get; set; }

        public int Amount { get; set; }

        public double TotalCost { get; set; }

        public clsAddItemToBuyerListUsingSaleDTO(short stockID, int amount, double totalCost)
        {
            StockID = stockID;
            Amount = amount;
            TotalCost = totalCost;
        }
    }
}
