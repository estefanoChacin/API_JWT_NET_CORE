using JWT.CONSTANS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        [Authorize(Roles = "seguridad")]
        public IActionResult get() {
            var lista = ProductConstants.listaProducts;

            return Ok(lista);
        }
    }
}
