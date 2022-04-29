using Hotel_El_Dorado.Business;
using Hotel_El_Dorado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Hotel_El_Dorado.Controllers
{
    public class ComoLlegarController : Controller
    {

        private readonly ILogger<ComoLlegarController> _logger;

        public IConfiguration Configuration { get; }

        public ComoLlegarController(ILogger<ComoLlegarController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            ComoLlegarBusiness business = new ComoLlegarBusiness(Configuration);
            ComoLlegarModel model = new ComoLlegarModel();
            model = business.ObtenerHome();

            ViewData["Título"] = model.Titulo;
            ViewData["Descripcion"] = model.Descripcion;

            return View();
        }
    }
}
