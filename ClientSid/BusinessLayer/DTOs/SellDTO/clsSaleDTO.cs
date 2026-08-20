using System;


namespace ClientSideBusinessLayer.DTOs.SellDTO
{
    class clsSaleDTO
    {
        public int ID { get; set; }

        public double TotalPrice { get; set; }

        public DateTime PayDate { get; set; }

        public string DoneByName { get; set; }
       
        public short DoneByID { get; set; }


        public clsSaleDTO(int iD, double totalPrice, DateTime payDate,string doneByName, short doneByID)
        {
            ID = iD;
            TotalPrice = totalPrice;
            PayDate = payDate;
            DoneByName = doneByName;
            DoneByID = doneByID;
        }
    }
}
