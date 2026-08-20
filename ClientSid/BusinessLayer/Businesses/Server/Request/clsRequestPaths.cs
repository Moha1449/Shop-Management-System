

using System.Net.NetworkInformation;

namespace ClientSideBusinessLayer
{
    internal sealed class clsRequestPaths
    {
        //Users Paths 
        private static string UsersMainPath => "Users";

        internal static string Login =>UsersMainPath + @"/LoginUsingUserNameAndPassword";

        internal static string GetUsers => UsersMainPath + @"/All";

        internal static string AddUser => UsersMainPath + @"/Add";

        internal static string UpdateUser => UsersMainPath + @"/Update";

        internal static string DeleteUser => UsersMainPath + @"/Delete";


        //States Paths 
        private static string StatesMainPath => "States";

        internal static string AllStates => StatesMainPath + @"/GetStates";


        //Stocks Paths
        private static string StocksMainPath => "Stocks";

        internal static string GetStocksPaged => StocksMainPath + @"/Paged";

        internal static string GetStockByName => StocksMainPath + @"/NameSpecific";

        internal static string DeleteStock => StocksMainPath + @"/Delete";

        internal static string AddStock => StocksMainPath + @"/Add";

        internal static string UpdateStock => StocksMainPath + @"/Update";

        //Sells Path 
        private static string SellsMainPath => "Sells";

        internal static string GetSellsPaged => SellsMainPath + @"/Paged";

        internal static string GetSell => SellsMainPath + @"/Specific";

        internal static string AddSale => SellsMainPath + @"/Add";

        internal static string DeleteSale => SellsMainPath + @"/Delete";

        //SalesDetails
        private static string SalesDetailsMainPath => "SalesDetails";

        internal static string GetSaleDetailsBySaleID => SalesDetailsMainPath + @"/Specific";

        internal static string UpdateAmount => SalesDetailsMainPath + @"/Update/Amount";

        internal static string DeleteSaleDetail => SalesDetailsMainPath + @"/Delete";

        internal static string AddItemToBuyerList => SalesDetailsMainPath + @"/Add/Item";
    }
}
