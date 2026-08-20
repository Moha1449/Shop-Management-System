using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSideBusinessLayer.DTOs.SaleDetailsDTO
{
    public class clsSaleDetailsDTO
    {
        public int DetailID { get; set; }

        public int SaleID { get; set; }

        public short EnteredByID { get; set; }

        public short StockID { get; set; }

        public string StockName { get; set; }

        public string EnteredByName { get; set; }

        public byte Quantity { get; set; }

        public double Cost { get; set; }

        public clsSaleDetailsDTO(int detailID, int saleID, short enteredByID, short stockID, string stockName, string enteredByName, byte quantity, double cost)
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
