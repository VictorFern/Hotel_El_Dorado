using Hotel_El_Dorado.Business;
using Hotel_El_Dorado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Hotel_El_Dorado.Controllers
{
    public class ContactenosController : Controller
    {
        private readonly ILogger<ContactenosController> _logger;
        public IConfiguration Configuration { get; }

        public ContactenosController(ILogger<ContactenosController> logger, IConfiguration configuration)
        {
            _logger =logger;
            Configuration = configuration;
        }

        public IActionResult Index()
        {

            string[,] data = {
                { "Hotel el Dorado" },
                { "Tel: 2222-2222 / 2222-2323" },
                {  "Apdo Postal: 21004" },
                {  "info@hoteleldorado.com" },
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
