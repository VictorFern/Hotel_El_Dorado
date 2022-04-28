using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Hotel_El_Dorado.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Hotel_El_Dorado.Business;

namespace Hotel_El_Dorado.Controllers
{
    [Route("Habitacion")]
    public class HabitacionController : Controller
    {

        public IConfiguration Configuration { get; }
        private readonly ILogger<HabitacionController> _logger;
        private readonly IWebHostEnvironment _iweb;

        public HabitacionController(IConfiguration configuration, ILogger<HabitacionController> logger, IWebHostEnvironment iweb)
        {
            _logger = logger;
            _iweb = iweb;
            Configuration = configuration;
        } // constructor

        [Route("Obtener")]
        [HttpPost]
        public HabitacionModel ObtenerHabitacionesIDTipo(int id)
        {
            HabitacionBusiness habitacionBusiness = new HabitacionBusiness(Configuration);
            return habitacionBusiness.ObtenerHabitacionesIDTipo(id);
        }

    }
}
