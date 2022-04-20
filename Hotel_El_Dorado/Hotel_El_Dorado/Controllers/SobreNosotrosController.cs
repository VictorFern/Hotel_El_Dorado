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
    [Route("SobreNosotros")]
    public class SobreNosotrosController : Controller
    {

        public IConfiguration Configuration { get; }
        private readonly ILogger<SobreNosotrosController> _logger;

        public SobreNosotrosController(IConfiguration configuration, ILogger<SobreNosotrosController> logger)
        {
            _logger = logger;
            Configuration = configuration;
        } // constructor

        public IActionResult Index()
        {
            SobreNosotrosBusiness sobreNosotrosBusiness = new SobreNosotrosBusiness(Configuration);
            SobreNosotrosModel sobreNosotros = sobreNosotrosBusiness.ObtenerSobreNosotros();
            Console.WriteLine(sobreNosotros.SobreNosotros);
            ViewBag.SobreNosotros = sobreNosotros;

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
