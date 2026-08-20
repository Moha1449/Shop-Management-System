using APIs_Business.Businesses;
using APIs_Business.DTOs.StatesDTOs;
using APIs_Business.OperationResultsHandler;
using Microsoft.AspNetCore.Mvc;

namespace Shop_Management_System_Server_Side.Controllers
{
    [Route("States")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        [HttpGet("GetStates",Name ="GetStatesAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<clsStatesDTO>> GetStatesAsync()
        {
            (var GetResult,var States) = await clsStates.GetStatesAsync();

            if(GetResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(States);

            return StatusCode(StatusCodes.Status500InternalServerError,"Something Went Wrong");
        }
    }
}
