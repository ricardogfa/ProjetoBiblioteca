using Microsoft.AspNetCore.Mvc;
using TechLibrary.Comunication.Requests;
using TechLibrary.Comunication.Response;

namespace TechLibrary.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
        public IActionResult Create(RequestUserJson request)
        {
            return Created();
        }
    }
}

