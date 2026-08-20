

namespace APIs_Business.DTOs.StatesDTOs
{
    public class clsStatesDTO
    {
        public short TotalUsers { get;  set; }

        public short TotalStocks { get;  set; }

        public int TotalServedCustomers { get;  set; }

        public double TotalSells { get; set; }

        public clsStatesDTO (short totalUsers=0, short totalStocks=0, int totalServedCustomers = 0,double totalsells=0 )
        {
            TotalUsers = totalUsers;
            TotalStocks = totalStocks;
            TotalServedCustomers = totalServedCustomers;
            TotalSells = totalsells;
        }
    }
}
