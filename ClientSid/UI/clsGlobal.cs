using ClientSideBusinessLayer;


namespace ShopManagementSystem
{
    internal static class clsGlobal
    {
      internal static clsUser CurrentUser { get; set; }

      internal enum enScreenMode { Add, Update }
    }
}
