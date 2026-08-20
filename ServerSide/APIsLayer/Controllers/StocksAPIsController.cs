using APIs_Business.Businesses;
using APIs_Business.DTOs.StockDTOs;
using APIs_Business.OperationResultsHandler;
using Microsoft.AspNetCore.Mvc;

namespace Shop_Management_System_Server_Side.Controllers
{
    [Route("Stocks")]
    [ApiController]
    public class StocksAPIsController : ControllerBase
    {
        [HttpGet("All", Name = "GetAllStocksAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<clsStockDTO>>> GetAllStocksAsync()
        {
            (var GetResult,var Stocks) = await clsStock.GetAllStocksAsync();

            if (GetResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(Stocks);

            return StatusCode(500, "Something went wrong try again later");
        }


        [HttpGet("Paged/{PageNumber}/{RowsNumber}", Name = "GetStocksPagedAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<clsStockDTO>> >GetStocksPagedAsync(short PageNumber,short RowsNumber)
        {
            if (PageNumber <= 0)
                return BadRequest($"Invalid Page Number {PageNumber}");

            if (RowsNumber <= 0)
                return BadRequest($"Invalid Rows Number {RowsNumber}");

            (var GetResult,var Stocks) =await clsStock.GetStocksPagedAsync(PageNumber,RowsNumber);

            if (GetResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(Stocks);

            return StatusCode(500, "Something went wrong try again later");
        }


        
        [HttpGet("Specific/{ID}", Name = "GetStockByStockIDAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task< ActionResult<clsStockDTO>> GetStockByStockIDAsync(short ID)
        {
            if (ID <= 0)
                return BadRequest($"Invalid ID : {ID}");

            var Stock =await clsStock.GetStockByIDAsync(ID);

            if (Stock.GeneralResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(Stock.StockDTO);

            if (Stock.GeneralResult == clsOperationResultDetails.enReturnResult.NotFound)
                return NotFound($"The Stock with {ID} dose not found");

            return StatusCode(500, "Something went wrong try again later");
        }


        [HttpGet("NameSpecific/{Name}", Name = "GetStockByNameAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<clsStockDTO>> GetStockByNameAsync(string Name)
        {
            if (string.IsNullOrEmpty(Name))
                return BadRequest($"Empty Name");

            var Stock = await clsStock.GetStockByNameAsync(Name);

            if (Stock.GeneralResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(Stock.StockDTO);

            if (Stock.GeneralResult == clsOperationResultDetails.enReturnResult.NotFound)
                return NotFound($"The Stock with {Name} dose not found");

            return StatusCode(500, "Something went wrong try again later");
        }



        [HttpPost("Add", Name = "AddNewStockAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task< ActionResult<short>> AddNewStockAsync(clsAddStockDTO NewStock)
        {
            if (NewStock == null)
                return BadRequest("Empty Data");

            clsStock Stock = new clsStock(NewStock);

            var AddStockResult = await Stock.SaveAsync();

            if (AddStockResult.State == clsOperationResultDetails.enReturnResult.Success)
                return CreatedAtRoute("GetStockByStockIDAsync", new { ID = Stock.ID },
                Stock.ID);


            if (AddStockResult.State == clsOperationResultDetails.enReturnResult.InvalidInputs)
                return BadRequest(AddStockResult.Reason);



            return StatusCode(500, AddStockResult.Reason);
        }



        [HttpPut("Update", Name = "UpdateStockByStockIDAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task< ActionResult<bool>> UpdateStockByStockIDAsync(clsUpdateStockDTO StockDTO)
        {
            if(StockDTO == null)
                return BadRequest("Empty Data");

            var Stock =  await clsStock.GetStockByIDAsync(StockDTO.ID);

            if (Stock.GeneralResult == clsOperationResultDetails.enReturnResult.NotFound)
                return NotFound($"The Stock with {Stock.ID} dose not found");

            if (Stock.GeneralResult == clsOperationResultDetails.enReturnResult.InvalidInputs)
                return BadRequest("Invalid Stock ID");

            if (Stock.GeneralResult == clsOperationResultDetails.enReturnResult.Exception)
                return StatusCode(500, "Something went wrong try again later");

            Stock.Amount = StockDTO.Amount;
            Stock.Price = StockDTO.Price;
            Stock.Cost = StockDTO.Cost;
            Stock.Name = StockDTO.Name;

            var UpdateResult =await Stock.SaveAsync();

            if (UpdateResult.State == clsOperationResultDetails.enReturnResult.Success)
                return Ok(true);

            if (UpdateResult.State == clsOperationResultDetails.enReturnResult.InvalidInputs)
                return BadRequest(UpdateResult.Reason);

            return StatusCode(500, UpdateResult.Reason);
        }



        [HttpDelete("Delete/{ID}", Name = "DeleteStockByStockID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<bool> >DeleteStockByStockIDAsync(short ID)
        {
            if (ID <= 0)
                return BadRequest($"Invalid ID : {ID}");

            var DeleteResult = await clsStock.DeleteStockByStockID(ID);

            if (DeleteResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(true);


            if (DeleteResult == clsOperationResultDetails.enReturnResult.NotFound)
                return NotFound($"The Stock with {ID} dose not found");

            return StatusCode(500, "Something went wrong try again later");
        }

    }
}
