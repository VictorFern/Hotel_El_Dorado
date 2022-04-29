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

            FacilidadBusiness facilidadBusiness = new FacilidadBusiness(Configuration);
            List<FacilidadModel> lista = facilidadBusiness.ObtenerFacilidades();

            string[,] data = new string[lista.Count, 2];

            for (int i = 0; i < lista.Count; i++)
            {
                data[i, 0] = lista[i].Src.ToString();
                data[i, 1] = lista[i].Descripcion.ToString();
            }

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
