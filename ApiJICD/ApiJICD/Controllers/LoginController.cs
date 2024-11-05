
using Dominio.Interfaces;
using Dominio.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiJICD.Controllers
{
    [ApiController]
    [Route("POLI/Api")]
    public class LoginController(IServicios servicios) : Controller
    {
        // GET: LoginController
        [HttpGet("login")]
        public async Task<ActionResult<Login>> Getlogin(string correo)
        {
            Login login = await servicios.GetLogin(correo);
            return Ok(login);
        }
    }
}
