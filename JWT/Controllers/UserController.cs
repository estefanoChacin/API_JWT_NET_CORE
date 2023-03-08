using JWT.CONSTANS;
using JWT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.CodeDom.Compiler;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Text;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;

        public UserController(IConfiguration config) { 
            _config= config;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult login(loginUser user) {

            var userlog = validateUser(user);

            if (userlog != null) {
                //crear token 
                var token = Generate(userlog);

                return Ok(token);
            }

            return NotFound("usurio no encontrado");
        }

        private UserModel validateUser(loginUser userLogin)
        {
            var userFind = UsersConstants.usuarios.FirstOrDefault(user => user.email == userLogin.email && user.password == userLogin.password);

            if (userFind != null)
            {
                return userFind;
            }

            return null;
        }


        private string  Generate(UserModel user) {

            var security = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:key"]));
            var credentials = new SigningCredentials(security, SecurityAlgorithms.HmacSha256);

            //crear los claims
            var claims = new[] {
                new Claim("Id", user.id.ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.name),
                new Claim(ClaimTypes.Surname, user.lastmane),
                new Claim(ClaimTypes.Email, user.email),
                new Claim(ClaimTypes.Role, user.rol)
            };

            //crear el token

            var token = new JwtSecurityToken(
                    _config["JWT:issuer"],
                    _config["JWT:audience"],
                    claims,
                    expires: DateTime.Now.AddMinutes(60),
                    signingCredentials:credentials
                ) ;

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
