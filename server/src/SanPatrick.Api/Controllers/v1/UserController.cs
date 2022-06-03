using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SanPatrick.Application.Dtos.Users;
using SanPatrick.Application.Features.Users.Commands.AuthenticateUser;
using SanPatrick.Application.Features.Users.Commands.RegisterUserCommand;

namespace SanPatrick.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    public class UserController : BaseApiController
    {
        [HttpPost("signin")]
        public async Task<IActionResult> AuthenticateAsync(AuthenticationRequest request)
        {
            return Ok(await Mediator.Send(new AuthenticateUserCommand
            {
                Email = request.Email,
                Password = request.Password,
                IpAddress = GetIpAddress()
            }));
        }

        [HttpPost("signup")]
        public async Task<IActionResult> RegisterAsync(RegistrationRequest request)
        {
            return Ok(await Mediator.Send(new RegisterUserCommand
            {
                Email = request.Email,
                Password = request.Password,
                ConfirmPassword = request.ConfirmPassword,
                PhoneNumber = request.PhoneNumber,
                FirstName = request.FirstName,
                MiddleName = request.MiddleName,
                LastName = request.LastName,
                BirthDate = request.BirthDate,
                AvatarString = request.AvatarString,

                Citizenship = request.Citizenship,
                MaritalStatus = request.MaritalStatus,
                Occupation = request.Occupation,

                Country = request.Country,
                City = request.City,
                Address = request.Address,

                Origin = Request.Headers["origin"]
            }));
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
