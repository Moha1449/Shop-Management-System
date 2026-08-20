using APIs_Business.DTOs.SaleDetailsDTOs;
using APIs_Business.OperationResultsHandler;
using APIsAccessData.DataProviders;
using APIsAccessData.Entities;

namespace APIs_Business.Businesses
{
    public class clsSaleDetails
    {
        public int DetailID { get; set; }

        public int SaleID { get; set; }

        public short EnteredByID { get; set; }

        public short StockID { get; set; }

        public string StockName { get; set; }

        public string EnteredByName { get; set; }

        public int Quantity { get; set; }

        public double Cost { get; set; }

        public clsOperationResultDetails.enReturnResult GeneralState { get; private set; }

        private clsClassesModes.enClassMode _Mode { get; set; }


        public clsSaleDetails(clsAddItemToBuyerListDTO NewDetail)
        {
            DetailID = -1;
            SaleID = NewDetail.SaleID;
            EnteredByID = NewDetail.EnteredByID;
            StockID = NewDetail.StockID;
            this.StockName = string.Empty;
            this.EnteredByName = string.Empty;
            Quantity = NewDetail.Quantity;
            Cost = NewDetail.Cost;
            _Mode = clsClassesModes.enClassMode.Add;
            GeneralState = clsOperationResultDetails.enReturnResult.None;
        }


        public static async Task<(clsOperationResultDetails.enReturnResult,List<clsSaleDetailsDTO>)> GetSaleDetailsBySaleIDAsync(int SaleID)
        {
            (var GetResult,var Entities) =await clsSelesDetailsDataProvider
                .GetSalesDetailsBySaleIDAsync(SaleID);

           
          return (clsOperationResultDetails.ConvertToBusinessState(GetResult),Entities.Select(S => new clsSaleDetailsDTO(S.DetailID,S.SaleID,S.EnteredByID
                ,S.StockID,S.StockName,S.EnteredByName,S.Quantity,S.Cost)).ToList());

        }

        public static async Task<clsOperationResultDetails> UpdateAmountAsync(clsUpdateAmountDTO Data)
        {
            clsSaleDetailEntity UpdateEntity = clsSaleDetailEntity.
                UpdateAmountSaleDetailInstance(Data.SaleDetailID, Data.SaleID, Data.Amount, Data.StockID);

            var UpdateResult = clsOperationResultDetails.
                ConvertFromDLResultToBSResult( await clsSelesDetailsDataProvider.UpdateAmountAsync(UpdateEntity));

            return UpdateResult;
        }

        public async Task< clsOperationResultDetails> AddNewItemDetailToBuyerListAsync()
        {
            if (_Mode != clsClassesModes.enClassMode.Add)
                return clsOperationResultDetails.NonResult();

            clsSaleDetailEntity Entity = clsSaleDetailEntity.
                AddItemDetailInstance(this.SaleID,this.EnteredByID,this.StockID,this.Quantity,this.Cost);

            var AddResult = clsOperationResultDetails.ConvertFromDLResultToBSResult
                 (await clsSelesDetailsDataProvider.AddNewItemToBuyerListAsync(Entity));

            if(AddResult.State == clsOperationResultDetails.enReturnResult.Success)
                this.DetailID = Entity.DetailID; 

            GeneralState = AddResult.State;

            return AddResult;
        }


        public static async Task<clsOperationResultDetails.enReturnResult> DeleteSaleDetailByDetailIDAsync(int ID)
        {
            return clsOperationResultDetails.ConvertToBusinessState(await
                clsSelesDetailsDataProvider.DeleteSaleDetailByIDAsync(ID));
        }
    }
}
