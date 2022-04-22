using Hotel_El_Dorado.Business;
using Hotel_El_Dorado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Hotel_El_Dorado.Controllers
{
    public class FacilidadController : Controller
    {
        private readonly ILogger<FacilidadController> _logger;
        public IConfiguration Configuration { get; }

        public FacilidadController(ILogger<FacilidadController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Index()
        {

            string[,] data = { 
                { "/img/spa.png", "Abierto de 9:00 a.m. a 5:00 p.m. Disponible" +
                " para todos nuestros clientes"},
                { "/img/restaurante.png", "Abierto de 7:00 a.m. a 9:00 p.m." +
                "El menú disponible puede cambiar dependiendo del día o festividad"},
                { "/img/estacionamiento.png", "Bajo techo para los clientes que reserven" +
                "más de una noche y, al aire libre para todos los demás"},
                { "/img/piscina.png", "Disponible para todos nuestros clientes." +
                "Deben acatarse las reglas de decoro especificadas en el lugar."},
            };

            ViewData["data"]  = data;

            PublicidadBusiness publicidadBusiness = new PublicidadBusiness(Configuration);
            List<PublicidadModel> listaPublicidad = new List<PublicidadModel>();
            listaPublicidad = publicidadBusiness.ObtenerPublicidad();
            ViewBag.ListaPublicidad = listaPublicidad;

            OfertaBusiness ofertaBusiness = new OfertaBusiness(Configuration);
            List<OfertaModel> listaOferta = new List<OfertaModel>();
            listaOferta = ofertaBusiness.ObtenerOferta();
            ViewBag.ListaOferta = listaOferta;
            return View();

        }
    }
}
