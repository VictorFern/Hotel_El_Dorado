using Hotel_El_Dorado_Admin.Business;
using Hotel_El_Dorado_Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Text.Json;

namespace Hotel_El_Dorado_Admin.Controllers
{
    [Route("Habitacion")]
    //[Produces("application/json")]
    public class HabitacionController : Controller
    {
        public IConfiguration Configuration { get; }

        public HabitacionController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [Route("ListarHabDisponibles")]
        [HttpPost]
        public IActionResult ListarHabDisponibles(string fechaEntrada, string fechaSalida, int tipo)
        {   
            HabitacionBusiness haBusiness = new HabitacionBusiness(Configuration);
            List<HabitacionModel> listaDisponibles = haBusiness.ConsultarDisponibilidad(fechaEntrada, fechaSalida, tipo);

            var ret = JsonSerializer.Serialize(listaDisponibles);
            
            return Ok(ret);
        }
    }
}
