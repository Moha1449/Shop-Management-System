using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs_Business.DTOs.SellDTOs
{
    public class clsSellDTO
    {
        public int ID { get; set; }

        public double TotalPrice { get; set; }

        public DateTime PayDate { get; set; }

        public short DoneByID { get; set; }

        public string DoneByName { get; set; }

       
        public clsSellDTO(int iD, double totalPrice, DateTime payDate, string doneByName,short doneByID)
        {
            ID = iD;
            TotalPrice = totalPrice;
            PayDate = payDate;
            DoneByName = doneByName;
            DoneByID = doneByID;
        }
    }
}
