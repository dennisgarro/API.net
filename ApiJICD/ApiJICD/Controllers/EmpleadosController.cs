using Dominio.Interfaces;
using Dominio.Modelos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiJICD.Controllers
{
    [ApiController]
    [Route("POLI/Api")]
    public class EmpleadosController(IServicios iServicios) : Controller
    {
        [HttpGet("empleados")]
        public async Task<ActionResult<List<Empleados>>> GetEmpleados()
        {
            List<Empleados> result = await iServicios.GetEmpleadosList();
            return Json(result);
        }
    }
}
