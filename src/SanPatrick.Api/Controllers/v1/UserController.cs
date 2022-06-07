using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SanPatrick.Application.Dtos.Users;
using SanPatrick.Application.UseCases.User.Authenticate;
using SanPatrick.Application.UseCases.User.Register;

namespace SanPatrick.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    public class UserController : BaseApiController
    {
        [HttpPost("signin")]
        public async Task<IActionResult> AuthenticateAsync(AuthenticationRequest request)
        {
            return Ok(await Mediator.Send(
                new AuthenticateUserCommand(
                    request.Email, 
                    request.Password, 
                    GetIpAddress()
            )));
        }

        [HttpPost("signup")]
        public async Task<IActionResult> RegisterAsync(RegistrationRequest request)
        {
            return Ok(await Mediator.Send(
                new RegisterUserCommand(
                        request.Email,
                        request.Password,
                        request.ConfirmPassword,
                        request.PhoneNumber,
                        request.FirstName,
                        request.MiddleName,
                        request.LastName,
                        request.BirthDate,
                        request.AvatarString,
                        request.Citizenship,
                        request.MaritalStatus,
                        request.Occupation,
                        request.Country,
                        request.City,
                        request.Address,
                        Request.Headers["origin"]
            )));
        }

        private string GetIpAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                return Request.Headers["X-Forwarded-For"];
            }
            else
            {
                return HttpContext.Connection.RemoteIpAddress!.MapToIPv4().ToString();
            }
        }
    }
}
