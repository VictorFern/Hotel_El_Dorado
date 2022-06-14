using Hotel_El_Dorado_Admin.Models;
using Hotel_El_Dorado_Admin.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Hotel_El_Dorado_Admin.Controllers
{
    public class OfertaController : Controller
    {
        public IConfiguration Configuration { get; }
        private static string Imagen = "";
        private readonly IWebHostEnvironment _iweb;

        public OfertaController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult InsertarOferta()
        {
            return View();
        }


        [HttpPost]
        public IActionResult guardarOferta(OfertaModel temp)
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            Console.WriteLine(temp.Imagen);
            TemBussi.guardarOferta(temp);
            return RedirectToAction("VisualizarOferta");
        }


        public IActionResult VisualizarOferta()
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            List<OfertaModel> var = new List<OfertaModel>();
            var = TemBussi.ObtenerOfertas();
            return View(var);
        }

        public IActionResult EliminarOferta(OfertaModel temp)
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            TemBussi.eliminarOferta(temp);
            return RedirectToAction("VisualizarOferta");
        }

      
        public IActionResult EditarOferta(OfertaModel temp)
        {
            Console.WriteLine("fecha i " + temp.Fecha_Inicio);
            Console.WriteLine("fecha f " + temp.Fecha_Fin);
            ViewData["data"] = temp;
            return View();
        }

        public IActionResult ModificarOferta(OfertaModel temp)
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            TemBussi.editarOferta(temp);
            return RedirectToAction("VisualizarOferta");
        }


    }
}
