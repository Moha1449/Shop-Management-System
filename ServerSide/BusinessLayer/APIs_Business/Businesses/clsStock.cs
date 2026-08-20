using APIs_Business.DTOs.StockDTOs;
using APIs_Business.OperationResultsHandler;
using APIsAccessData.DataProviders;
using APIsAccessData.Entities;
using System.Threading.Tasks;


namespace APIs_Business.Businesses
{
   public class clsStock
   {
        public short ID { get; set; }

        public string Name { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

        public double Cost { get; set; }

        public short AddedBy { get; set; }

        public clsStockDTO StockDTO { get { return new clsStockDTO(this.ID,this.Name,this.Amount,this.Price,this.Cost,this.AddedBy); } }

        public clsOperationResultDetails.enReturnResult GeneralResult { get; private set; }

        private clsClassesModes.enClassMode _Mode {  get; set; }



        private clsStock(short id, string name, int amount, double price, double cost, short addedBy, clsOperationResultDetails.enReturnResult operationResult)
        {
            ID = id;
            Name = name;
            Amount = amount;
            Price = price;
            Cost = cost;
            AddedBy = addedBy;
            GeneralResult = operationResult;
            _Mode = clsClassesModes.enClassMode.Update;
        }

        public clsStock(clsAddStockDTO NewStock)
        {
            ID = -1;
            Name = NewStock.Name;
            Amount = NewStock.Amount;
            Price = NewStock.Price;
            Cost = NewStock.Cost;
            AddedBy = NewStock.AddedBy;
            _Mode = clsClassesModes.enClassMode.Add;
            GeneralResult = clsOperationResultDetails.enReturnResult.None;
        }



        public static async Task< (clsOperationResultDetails.enReturnResult, List<clsStockDTO>)> GetAllStocksAsync()
        {
            List<clsStockEntity> StocksEntities = new List<clsStockEntity>();

            var GetResult = clsOperationResultDetails.ConvertToBusinessState
                (await clsStocksDataProvider.GetAllStocksAsync(StocksEntities));

            return (GetResult, StocksEntities.
                Select(Entity => new clsStockDTO(Entity.ID, Entity.Name, Entity.Amount,
                Entity.Price, Entity.Cost, Entity.AddedBy)).ToList());
          
        }

        public static async Task<(clsOperationResultDetails.enReturnResult, List<clsStockDTO>)> GetStocksPagedAsync(short PageNumber,short RowsNumber)
        {
            List<clsStockEntity> StocksEntities = new List<clsStockEntity> ();

            var GetResult = clsOperationResultDetails.ConvertToBusinessState
                 (await clsStocksDataProvider.
                GetStockPagedAsync(StocksEntities,
                PageNumber,RowsNumber));

            return (GetResult, StocksEntities.
                Select(Entity => new clsStockDTO(Entity.ID, Entity.Name, Entity.Amount,
                Entity.Price, Entity.Cost, Entity.AddedBy)).ToList());
        }

        public static async Task<clsStock> GetStockByIDAsync(short ID)
        {
             clsStockEntity Entity = clsStockEntity.GetStockEntity(ID);

            var GetStock = clsOperationResultDetails.ConvertToBusinessState(await clsStocksDataProvider.GetStockByStockIDAsync(Entity));

            if (GetStock == clsOperationResultDetails.enReturnResult.Success)
                return new clsStock(ID,Entity.Name,Entity.Amount,Entity.Price,Entity.Cost,Entity.AddedBy,GetStock);

            return InvalidStockInstance(GetStock);
        }


        public static async Task<clsStock> GetStockByNameAsync(string Name)
        {
            clsStockEntity Entity = clsStockEntity.GetStockEntity(Name);

            var GetStock = clsOperationResultDetails.ConvertToBusinessState(await clsStocksDataProvider.GetStockByStockNameAsync(Entity));

            if (GetStock == clsOperationResultDetails.enReturnResult.Success)
                return new clsStock(Entity.ID, Name, Entity.Amount, Entity.Price, Entity.Cost, Entity.AddedBy, GetStock);

            return InvalidStockInstance(GetStock);
        }

        private async Task<clsOperationResultDetails> AddNewStockAsync()
        {
            clsStockEntity NewStockEntity = clsStockEntity.AddStockEntityInstance(Name,Amount,Price,Cost,AddedBy);

            clsOperationResultDetails AddResult = clsOperationResultDetails.ConvertFromDLResultToBSResult(
               await clsStocksDataProvider.AddNewStockAsync(NewStockEntity));

            if (AddResult.State == clsOperationResultDetails.enReturnResult.Success)
                this.ID = NewStockEntity.ID;

            this.GeneralResult = AddResult.State;

            return AddResult;
        }

        private async Task<clsOperationResultDetails> UpdateStockByIDAsync()
        {
            clsStockEntity Stock = clsStockEntity.UpdateStockEntityInstance(ID,Name,Amount,Price,Cost);

            clsOperationResultDetails UpdateResult = clsOperationResultDetails.
                ConvertFromDLResultToBSResult(await clsStocksDataProvider.UpdateStockByStockIDAsync(Stock));

            this.GeneralResult = UpdateResult.State;

            return UpdateResult;
        }
        
        public static async Task<clsOperationResultDetails.enReturnResult> DeleteStockByStockID(short ID)
        {
            return  clsOperationResultDetails.
                ConvertToBusinessState(await clsStocksDataProvider.DeleteStockByUserIDAsync(ID));
        }

        public  async Task<clsOperationResultDetails> SaveAsync()
        {
            switch (_Mode)
            {
                case clsClassesModes.enClassMode.Add:
                    return await AddNewStockAsync();

                case clsClassesModes.enClassMode.Update:
                    return await UpdateStockByIDAsync();

                default:
                    return clsOperationResultDetails.NonResult();
            }
        }



        private static clsStock InvalidStockInstance(clsOperationResultDetails.enReturnResult OperationResult)
        {
            return new clsStock(-1, string.Empty,0, 0.0d,0.0d,-1, OperationResult);
        }
    }
}
