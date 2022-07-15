using Hotel_El_Dorado.Business;
using Hotel_El_Dorado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado.Controllers
{
    public class TipoHabitacionController : Controller
    {
        private readonly ILogger<TipoHabitacionController> _logger;

        public IConfiguration Configuration { get; }

        public TipoHabitacionController(ILogger<TipoHabitacionController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            TipoHabitacionBusiness tipoHabitacionBusiness = new TipoHabitacionBusiness(Configuration);
            ViewBag.tipoHabitacion = tipoHabitacionBusiness.ObtenerTipohabitacion();

            ReservacionBusiness reservacionBusiness = new ReservacionBusiness(Configuration);
            ViewBag.DescuentoTemporada = reservacionBusiness.ObtenerDescuentoTemporada();

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
