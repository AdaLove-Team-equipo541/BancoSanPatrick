using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SanPatrick.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : BaseApiController
    {
        [HttpGet]
        [Authorize(Roles = "BasicCustomer")]
        public async Task<IActionResult> Get()
        {
            return Ok("Lista de tarjetas");
        }
    }
}
