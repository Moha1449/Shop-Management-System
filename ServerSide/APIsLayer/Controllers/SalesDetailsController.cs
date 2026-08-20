using APIs_Business.Businesses;
using APIs_Business.DTOs.SaleDetailsDTOs;
using APIs_Business.OperationResultsHandler;
using Microsoft.AspNetCore.Mvc;

namespace Shop_Management_System_Server_Side.Controllers
{
    [Route("SalesDetails")]
    [ApiController]
    public class SalesDetailsController: ControllerBase
    {
        [HttpGet("Specific/{ID}", Name = "GetSaleDetailsBySaleIDAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<clsSaleDetailsDTO>>> GetSaleDetailsBySaleIDAsync(int ID)
        {
            if (ID <= 0)
                return BadRequest($"Invalid ID : {ID}");

           ( var GetResult, var Sales) = await clsSaleDetails.GetSaleDetailsBySaleIDAsync(ID);

            if (GetResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(Sales);

            return StatusCode(500, "Something went wrong try again later");
        }



        [HttpPut("Update/Amount", Name = "UpdateAmountBySaleDetailIDAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task< ActionResult<bool>> UpdateAmountBySaleDetailIDAsync(clsUpdateAmountDTO NewAmount)
        {
            if (NewAmount == null)
                return BadRequest("Empty Instance");

           var UpdateResult = await clsSaleDetails.UpdateAmountAsync(NewAmount);

            if (UpdateResult.State == clsOperationResultDetails.enReturnResult.Success)
                return Ok(true);

            if (UpdateResult.Reason == "There is not sale detail with this id")
                return NotFound(UpdateResult.Reason);

            return StatusCode(500,UpdateResult.Reason);
        }



        [HttpDelete("Delete/{ID}", Name = "DeleteSaleDetailByIDAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task< ActionResult<bool>> DeleteSaleDetailByIDAsync(int ID)
        {
            if(ID <= 0)
                 return BadRequest("Invalid Sale ID");

            var DeleteResult = await clsSaleDetails.DeleteSaleDetailByDetailIDAsync(ID);

            if (DeleteResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(true);

            if (DeleteResult == clsOperationResultDetails.enReturnResult.NotFound)
                return NotFound($"The Sale Detail with {ID} dose not found");

            return StatusCode(500, "Something went wrong try again later");
        }




        [HttpPost("Add/Item", Name = "AddNewItemToBuyerListAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task< ActionResult<int> >AddNewItemToBuyerListAsync(clsAddItemToBuyerListDTO NewItem)
        {
            if (NewItem == null)
                return BadRequest("Item Is Empty");

            clsSaleDetails Detail = new clsSaleDetails(NewItem);

            var AddSaleResult = await Detail.AddNewItemDetailToBuyerListAsync();

            if (AddSaleResult.State == clsOperationResultDetails.enReturnResult.Success)
                return Ok(Detail.DetailID);

            if (AddSaleResult.State == clsOperationResultDetails.enReturnResult.InvalidInputs)
                return BadRequest(AddSaleResult.Reason);


            return StatusCode(500, AddSaleResult.Reason);
        }

    }
}
