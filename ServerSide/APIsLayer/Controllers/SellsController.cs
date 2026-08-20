using APIs_Business.Businesses;
using APIs_Business.DTOs.SellDTOs;
using APIs_Business.OperationResultsHandler;
using Microsoft.AspNetCore.Mvc;

namespace Shop_Management_System_Server_Side.Controllers
{
    [Route("Sells")]
    [ApiController]
    public class SellsController : ControllerBase
    {
        [HttpGet("Paged/{PageNumber}/{RowsNumber}", Name = "GetSalesPagedAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<clsSellDTO>>> GetSalesPagedAsync(short PageNumber,short RowsNumber)
        {
            if (PageNumber <= 0)
                return BadRequest($"Invalid Page Number {PageNumber}");

            if (RowsNumber <= 0)
                return BadRequest($"Invalid Rows Number {RowsNumber}");

            (var GetResult,var Sales) = await clsSale.GetSellsPagedAsync(PageNumber,RowsNumber);

            if (GetResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(Sales);

            return StatusCode(500, "Something went wrong try again later");
        }



        [HttpGet("Specific/{ID}", Name = "GetSaleBySaleIDAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<clsSellDTO>> GetSaleBySaleIDAsync(int ID)
        {
            if (ID <= 0)
                return BadRequest($"Invalid ID : {ID}");

            var Sell = await clsSale.GetSellBySellIDAsync(ID);

            if (Sell.GeneralState == clsOperationResultDetails.enReturnResult.Success)
                return Ok(Sell.DTO);

            if (Sell.GeneralState == clsOperationResultDetails.enReturnResult.NotFound)
                return NotFound($"The Sell with {ID} dose not found");

            return StatusCode(500, "Something went wrong try again later");
        }



        [HttpPost("Add", Name = "AddNewSaleAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<int>> AddNewSaleAsync(clsAddSellDTO NewSell)
        {
            if (NewSell == null)
                return BadRequest("Sale Data Is Empty");

            if(NewSell.BuyerList == null || NewSell.BuyerList.Count == 0)
                return BadRequest("Buyer List Is Empty");

            clsSale Sell = new clsSale(NewSell);

            var AddSaleResult = await Sell.AddNewSaleAsync();

            if (AddSaleResult.State == clsOperationResultDetails.enReturnResult.Success)
                return CreatedAtRoute("GetSaleBySaleIDAsync", new { ID = Sell.ID },
                Sell.ID);


            if (AddSaleResult.State == clsOperationResultDetails.enReturnResult.InvalidInputs)
                return BadRequest(AddSaleResult.Reason);

            return StatusCode(500, AddSaleResult.Reason);
        }



        [HttpDelete("Delete/{ID}", Name = "DeleteSaleBySaleIDAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<bool>> DeleteSaleBySaleIDAsync(int ID)
        {
             if(ID <= 0 )
                return BadRequest("Invalid Sale ID");

            var DeleteResult = await clsSale.DeleteSaleBySaleIDAsync(ID);
             

            if (DeleteResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(true);

            if (DeleteResult == clsOperationResultDetails.enReturnResult.NotFound)
                return NotFound($"The Sale with {ID} dose not found");

            return StatusCode(500, "Something went wrong try again later");
        }


    }
}
