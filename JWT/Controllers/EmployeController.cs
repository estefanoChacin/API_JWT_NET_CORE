using JWT.CONSTANS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() {
            var lista = EmployeContants.listEmployes;
            return Ok(lista);
        }
    }
}
