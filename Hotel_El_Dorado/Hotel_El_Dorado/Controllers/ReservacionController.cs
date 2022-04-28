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
    [Route("Reservacion")]
    public class ReservacionController : Controller
    {

        public IConfiguration Configuration { get; }
        private readonly ILogger<ReservacionController> _logger;
        private readonly IWebHostEnvironment _iweb;


        public ReservacionController(IConfiguration configuration, ILogger<ReservacionController> logger, IWebHostEnvironment iweb)
        {
            _logger = logger;
            _iweb = iweb;
            Configuration = configuration;
        } // constructor

        [Route("Reservar")]
        public IActionResult Index()
        {
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

        [Route("Obtener")]
        [HttpPost]
        public List<ReservacionModel> ObtenerReservaciones()
        {
            ReservacionBusiness reservacionBusiness = new ReservacionBusiness(Configuration);
            return reservacionBusiness.ObtenerReservaciones();
        }

        [Route("Verificar")]
        [HttpPost]
        public int VerificarFechas(string fechaEntrada2, string fechaSalida2, int tipoHabitacion)
        {

            string entrada = "";
            string salida = "";
            List<string> fechaSalida = new List<string>();
            List<string> fechaEntrada = new List<string>();


                fechaEntrada = new List<string>();
                fechaEntrada = fechaEntrada2.Split('-').ToList();
                entrada = fechaEntrada[2] + "/" + fechaEntrada[1] + "/" + fechaEntrada[0];



                fechaSalida = fechaSalida2.Split('-').ToList();
                salida = fechaSalida[2] + "/" + fechaSalida[1] + "/" + fechaSalida[0];

            ReservacionBusiness reservacionBusiness = new ReservacionBusiness(Configuration);

            return reservacionBusiness.VerificarFechas(entrada, salida, tipoHabitacion);
        }

        [Route("Datos")]
        [HttpPost]
        public IActionResult Index2(ReservacionModel reservacionModel)
        {

            PublicidadBusiness publicidadBusiness = new PublicidadBusiness(Configuration);
            List<PublicidadModel> listaPublicidad = new List<PublicidadModel>();
            listaPublicidad = publicidadBusiness.ObtenerPublicidad();
            ViewBag.ListaPublicidad = listaPublicidad;

            OfertaBusiness ofertaBusiness = new OfertaBusiness(Configuration);
            List<OfertaModel> listaOferta = new List<OfertaModel>();
            listaOferta = ofertaBusiness.ObtenerOferta();
            ViewBag.ListaOferta = listaOferta;

            string entrada = "";
            string salida = "";
            List<string> fechaSalida = new List<string>();
            List<string> fechaEntrada = new List<string>();


            if (reservacionModel.Fecha_Entrada != null)
            {
                fechaEntrada = new List<string>();
                fechaEntrada = reservacionModel.Fecha_Entrada.Split('-').ToList();
                entrada = fechaEntrada[2] + "/" + fechaEntrada[1] + "/" + fechaEntrada[0];
                reservacionModel.Fecha_Entrada = entrada;
            }
            else
            {
                reservacionModel.Fecha_Entrada = entrada;
            }


            if (reservacionModel.Fecha_Salida != null)
            {
                fechaSalida = reservacionModel.Fecha_Salida.Split('-').ToList();
                salida = fechaSalida[2] + "/" + fechaSalida[1] + "/" + fechaSalida[0];
                reservacionModel.Fecha_Salida = salida;
            }
            else
            {
                reservacionModel.Fecha_Salida = salida;
            }

            ViewBag.FechaEntrada = reservacionModel.Fecha_Entrada;
            ViewBag.FechaSalida = reservacionModel.Fecha_Salida;

            HabitacionBusiness habitacionController = new HabitacionBusiness(Configuration);
            HabitacionModel habitacion = habitacionController.ObtenerHabitacionesIDTipo(reservacionModel.tipoHabitacion);

            ViewBag.Imagen = habitacion.Imagen;
            

            DateTime date_1 = new DateTime(Int32.Parse(fechaEntrada[0]), Int32.Parse(fechaEntrada[1]), Int32.Parse(fechaEntrada[2]));
            DateTime date_2 = new DateTime(Int32.Parse(fechaSalida[0]), Int32.Parse(fechaSalida[1]), Int32.Parse(fechaSalida[2]));

            TimeSpan Diff_dates = date_2.Subtract(date_1);

            ViewBag.Costo = habitacion.Costo*Diff_dates.Days;
            ViewBag.Descripcion = habitacion.Descripcion;


            ViewBag.ID_Habitacion = reservacionModel.Habitacion.ID_Habitacion;


            return View("IngresarDatos");
        }

        [Route("Factura")]
        [HttpPost]
        public IActionResult Index3(ReservacionModel reservacionModel)
        {

            PublicidadBusiness publicidadBusiness = new PublicidadBusiness(Configuration);
            List<PublicidadModel> listaPublicidad = new List<PublicidadModel>();
            listaPublicidad = publicidadBusiness.ObtenerPublicidad();
            ViewBag.ListaPublicidad = listaPublicidad;

            OfertaBusiness ofertaBusiness = new OfertaBusiness(Configuration);
            List<OfertaModel> listaOferta = new List<OfertaModel>();
            listaOferta = ofertaBusiness.ObtenerOferta();
            ViewBag.ListaOferta = listaOferta;

            ReservacionBusiness reservacionBusiness = new ReservacionBusiness(Configuration);
            int reservacion = reservacionBusiness.RealizarReservacion(reservacionModel);

            ViewBag.Nombre = reservacionModel.Cliente.Nombre;
            ViewBag.Apellidos = reservacionModel.Cliente.Apellidos;
            ViewBag.Reservacion = reservacion;
            ViewBag.Email = reservacionModel.Cliente.Email;

            return View("Factura");
        }

    }
}
