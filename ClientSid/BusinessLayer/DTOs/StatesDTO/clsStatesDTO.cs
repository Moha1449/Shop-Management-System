using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSideBusinessLayer.DTOs.StatesDTO
{
    public class clsStatesDTO
    {
        public short TotalUsers { get; set; }

        public short TotalStocks { get; set; }

        public int TotalServedCustomers { get; set; }

        public double TotalSells {  get; set; }

        public clsStatesDTO(short totalUsers, short totalStocks, int totalServedCustomers,double totalsells)
        {
            TotalUsers = totalUsers;
            TotalStocks = totalStocks;
            TotalServedCustomers = totalServedCustomers;
            TotalSells = totalsells;
        }
    }
}
