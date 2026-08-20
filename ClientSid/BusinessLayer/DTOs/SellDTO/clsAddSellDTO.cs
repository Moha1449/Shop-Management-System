using ClientSideBusinessLayer.DTOs.SaleDetailsDTO;
using System.Collections.Generic;

namespace ClientSideBusinessLayer.DTOs.SellDTO
{
    public class clsAddSellDTO
    {
        public double TotalPrice { get; set; }

        public short DoneByID { get; set; }

        public List<clsAddItemToBuyerListUsingSaleDTO> BuyerList { get; set; }

        public clsAddSellDTO(double totalPrice, short doneByID, List<clsAddItemToBuyerListUsingSaleDTO> buyerList)
        {
            TotalPrice = totalPrice;
            DoneByID = doneByID;
            BuyerList = buyerList;
        }
    }
}
