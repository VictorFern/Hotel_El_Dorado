using Hotel_El_Dorado.Business;
using Hotel_El_Dorado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

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
            HomeModel model = new HomeModel();
            model = business.ObtenerHome();

            ViewData["Descripcion"] = model.infoComoLlegar;

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
