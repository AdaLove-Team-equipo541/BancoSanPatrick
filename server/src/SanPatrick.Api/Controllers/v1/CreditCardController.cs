using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SanPatrick.Application.Features.SavingsAccounts.Commands.CreateSavingsAccountCommand;

namespace SanPatrick.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    public class CreditCardController : BaseApiController
    {
        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] CreateSavingsAccountCommand command)
        //{
        //    return Ok(await Mediator.Send(command));
        //}

        [HttpGet]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> Get()
        {
            return Ok("Lista de tarjetas");
        }
    }
}
