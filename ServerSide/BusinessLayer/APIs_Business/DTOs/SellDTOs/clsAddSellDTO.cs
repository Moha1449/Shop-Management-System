
using APIs_Business.DTOs.SaleDetailsDTOs;

namespace APIs_Business.DTOs.SellDTOs
{
    public class clsAddSellDTO
    {
        public double TotalPrice { get; set; }

        public short DoneByID { get; set; }

        public List<clsAddItemToBuyerListWithSaleDTO> BuyerList { get; set; }

        public clsAddSellDTO(double totalPrice,  short doneByID, List<clsAddItemToBuyerListWithSaleDTO> buyerList)
        {
            TotalPrice = totalPrice;
            DoneByID = doneByID;
            BuyerList = buyerList;
        }
    }
}
