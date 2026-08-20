using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAccessData.Entities
{
    public class clsStatesEntity
    {
        public short TotalUsers { get;set; }

        public short TotalStocks { get;  set; }

        public int TotalServedCustomers { get;  set; }

        public double TotalSells { get; set; }

      

        public clsStatesEntity(short totalUsers =0 , short totalStocks= 0, int totalServed=0,double totalSells =0)
        {
            TotalUsers = totalUsers;
            TotalStocks = totalStocks;
            TotalServedCustomers = totalServed;
            TotalSells = totalSells;
        }
    }
}
