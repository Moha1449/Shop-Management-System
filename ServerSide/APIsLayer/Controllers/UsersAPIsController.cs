using APIs_Business.Businesses;
using APIs_Business.DTOs.UsersDTOs;
using APIs_Business.OperationResultsHandler;
using Microsoft.AspNetCore.Mvc;


namespace Shop_Management_System_Server_Side.Controllers
{
    [Route("Users")]
    [ApiController]
    public class UsersAPIsController : ControllerBase
    {
        [HttpGet("All", Name = "GetAllUsersAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<clsUserDTO>>> GetAllUsers()
        {
            (var GetResult, List<clsUserDTO> Users) = await clsUser.GetAllUsersAsync();

            if (GetResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(Users);

            return StatusCode(500, "Something went wrong try again later");
        }



        [HttpGet("Specific/{ID}", Name = "GetUserByUserIDAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<clsUserDTO>> GetUsersByUserID(short ID)
        {
            if (ID <= 0)
                return BadRequest($"Invalid ID : {ID}");

            var User = await clsUser.GetUserByUserIDAsync(ID);

            if (User.GeneralResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(User.UserDTO);

            if (User.GeneralResult == clsOperationResultDetails.enReturnResult.NotFound)
                return NotFound($"The User with {ID} dose not found");

            return StatusCode(500, "Something went wrong try again later");
        }



        [HttpPost("Add", Name = "AddNewUserAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task< ActionResult<short>> AddNewUser(clsAddUserDTO NewUser)
        {
            if (NewUser == null)
                return BadRequest("Empty Instance");

            clsUser User = new clsUser(NewUser);

            var AddUserResult =await  User.SaveAsync();

            if (AddUserResult.State == clsOperationResultDetails.enReturnResult.Success)
                return CreatedAtRoute("GetUserByUserIDAsync", new { ID = User.UserID },
                User.UserID);

            if (AddUserResult.State == clsOperationResultDetails.enReturnResult.InvalidInputs)
                return BadRequest(AddUserResult.Reason);

            return StatusCode(500, AddUserResult.Reason);
        }


        [HttpPut("Update", Name = "UpdateUserByUserIDAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<bool>> UpdateUserByUserID(clsUpdateUserDTO UserDTO)
        {
            if (UserDTO == null)
                return BadRequest("Empty Instance");

            var User = await clsUser.GetUserByUserIDAsync(UserDTO.UserID);

            if (User.GeneralResult == clsOperationResultDetails.enReturnResult.NotFound)
                return NotFound($"The User with {UserDTO.UserID} dose not found");

            if (User.GeneralResult == clsOperationResultDetails.enReturnResult.InvalidInputs)
                return BadRequest("Invalid User ID");

            if (User.GeneralResult == clsOperationResultDetails.enReturnResult.Exception)
                return StatusCode(500, "Something went wrong try again later");

            User.Password = UserDTO.Password;
            User.UserName = UserDTO.UserName;
            User.Permissions = UserDTO.Permissions;
            User.IsActive = UserDTO.IsActive;

            var UpdateResult = await User.SaveAsync();

            if (UpdateResult.State == clsOperationResultDetails.enReturnResult.Success)
                return Ok(true);

            if (UpdateResult.State == clsOperationResultDetails.enReturnResult.InvalidInputs)
                return BadRequest(UpdateResult.Reason);

            return StatusCode(500, UpdateResult.Reason);
        }



        [HttpDelete("Delete/{ID}", Name = "DeleteUserByUserIDAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task< ActionResult<bool>> DeleteUserByUserID(short ID)
        {
            if(ID <= 0)
                return BadRequest("Invalid User ID");

            var DeleteResult = await clsUser.DeleteUserByUserIDAsync(ID);

            if (DeleteResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(true);

            if (DeleteResult == clsOperationResultDetails.enReturnResult.NotFound)
                return NotFound($"The User with {ID} dose not found");

            return StatusCode(500, "Something went wrong try again later");
        }



        [HttpGet("LoginUsingUserNameAndPassword", Name = "LoginUsingUserNameAndPasswordAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task< ActionResult<clsUserDTO>> LoginUsingPasswordAndUserNameAsync(string UserName, string Password)
        {
            if(string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                    return BadRequest("Empty Input/s");

            var User = await clsUser.LoginUsingUserNameAndPasswordAsync(new clsLoginDTO(UserName, Password));

            if (User.GeneralResult == clsOperationResultDetails.enReturnResult.Success)
                return Ok(User.UserDTO);

            if (User.GeneralResult == clsOperationResultDetails.enReturnResult.NotFound)
                return NotFound("Password Or UserName is invalid");

            return StatusCode(500, "Something went wrong try again later");
        }
    }
}
