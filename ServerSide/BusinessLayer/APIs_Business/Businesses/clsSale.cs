using APIs_Business.DTOs.SaleDetailsDTOs;
using APIs_Business.DTOs.SellDTOs;
using APIs_Business.OperationResultsHandler;
using APIsAccessData.DataProviders;
using APIsAccessData.Entities;


namespace APIs_Business.Businesses
{
    public class clsSale
    {
        public int ID { get; set; }

        public double TotalPrice { get; set; }

        public DateTime PayDate { get; set; }

        public short DoneByID { get; set; }

        public string DoneByName { get; set; }

        public List<clsAddItemToBuyerListWithSaleDTO> BuyerList { get; set; }

        public clsSellDTO DTO { get { return new clsSellDTO(ID, TotalPrice, PayDate, DoneByName, DoneByID); } }

        public clsOperationResultDetails.enReturnResult GeneralState { get; private set; }

        private clsClassesModes.enClassMode _Mode { get; set; }



        public clsSale(clsAddSellDTO SellData)
        {
            this.TotalPrice = SellData.TotalPrice;
            this.PayDate = DateTime.Now;
            this.DoneByID = SellData.DoneByID;
            this.BuyerList = SellData.BuyerList;
            _Mode = clsClassesModes.enClassMode.Add;
            GeneralState = clsOperationResultDetails.enReturnResult.None;
        }

        private clsSale(int iD, double totalPrice, DateTime payDate, string doneByName, short doneByID, clsOperationResultDetails.enReturnResult result)
        {
            ID = iD;
            TotalPrice = totalPrice;
            PayDate = payDate;
            DoneByName = doneByName;
            DoneByID = doneByID;
            BuyerList = null;
            _Mode = clsClassesModes.enClassMode.Update;
            GeneralState = result;
        }



        public static async Task<(clsOperationResultDetails.enReturnResult, List<clsSellDTO>)> GetSellsPagedAsync(short PageNumber, short RowsPerPage)
        {
            List<clsSaleEntity> SellsEntities = new List<clsSaleEntity>();

            var GetResult = clsOperationResultDetails.ConvertToBusinessState(await clsSalesDataProvider.
                GetSalesPagedAsync(SellsEntities, PageNumber, RowsPerPage));

            return (GetResult, SellsEntities.Select(Entity => new clsSellDTO(Entity.ID, Entity.TotalPrice, Entity.PayDate,
                    Entity.DoneByName, Entity.DoneByID)).ToList());
        }

        public static async Task<clsSale> GetSellBySellIDAsync(int SellID)
        {
            clsSaleEntity SellEntity = clsSaleEntity.GetSaleEntity(SellID);

            clsOperationResultDetails.enReturnResult GetResult = clsOperationResultDetails.
                ConvertToBusinessState(await clsSalesDataProvider.GetSaleBySellIDAsync(SellEntity));

            if (GetResult == clsOperationResultDetails.enReturnResult.Success)
                return new clsSale(SellEntity.ID, SellEntity.TotalPrice, SellEntity.PayDate, SellEntity.DoneByName, SellEntity.DoneByID,
                   GetResult);

            return InvalidSaleInstance(GetResult);
        }

        public async Task<clsOperationResultDetails> AddNewSaleAsync()
        {
            if (_Mode != clsClassesModes.enClassMode.Add)
                return clsOperationResultDetails.NonResult();

            var BuyerListAsEntities = BuyerList.Select(D => clsSaleDetailEntity.AddNewSale(DoneByID, D.StockID,
                          D.Amount, D.TotalCost)).ToList();

            clsSaleEntity SaleEntity = clsSaleEntity.AddSellEntityInstance(TotalPrice, PayDate, DoneByID, BuyerListAsEntities);


            var AddResult = clsOperationResultDetails
                .ConvertFromDLResultToBSResult(await clsSalesDataProvider.AddNewSaleAsync(SaleEntity));

            if (AddResult.State == clsOperationResultDetails.enReturnResult.Success)
                this.ID = SaleEntity.ID;

            this.GeneralState = AddResult.State;

            return AddResult;
        }

        public static async Task<clsOperationResultDetails.enReturnResult> DeleteSaleBySaleIDAsync(int ID)
        {
            return clsOperationResultDetails.ConvertToBusinessState
                (await clsSalesDataProvider.DeleteSaleBySaleIDAsync(ID));
        }



        private static clsSale InvalidSaleInstance(clsOperationResultDetails.enReturnResult Result)
        {
            return new clsSale(-1, 0d, DateTime.Now, string.Empty, -1, Result);
        }
    }
}
