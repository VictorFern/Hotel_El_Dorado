using Hotel_El_Dorado_Admin.Models;
using Hotel_El_Dorado_Admin.Business;
using Microsoft.AspNetCore.Http;
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
        public bool getLogin()
        {
            if (Cache.Instance.isLogged)
            {
                int valor = (int)HttpContext.Session.GetInt32("variableInt");
                string nombre = HttpContext.Session.GetString("nombreAdmin");
                ViewBag.nombre = nombre;
                ViewBag.Session = valor;

                return true;
            }
            return false;
        }
        public IActionResult Index()
        {
            getLogin();
            return View();
        }


        public IActionResult InsertarOferta()
        {
            getLogin();
            return View();
        }


        [HttpPost]
        public IActionResult guardarOferta(OfertaModel temp)
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            Console.WriteLine(temp.Imagen);
            TemBussi.guardarOferta(temp);
            getLogin();
            return RedirectToAction("VisualizarOferta");
        }


        public IActionResult VisualizarOferta()
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            List<OfertaModel> var = new List<OfertaModel>();
            var = TemBussi.ObtenerOfertas();
            getLogin();
            return View(var);
        }

        public IActionResult EliminarOferta(OfertaModel temp)
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            TemBussi.eliminarOferta(temp);
            getLogin();
            return RedirectToAction("VisualizarOferta");
        }

      
        public IActionResult EditarOferta(OfertaModel temp)
        {
            Console.WriteLine("fecha i " + temp.Fecha_Inicio);
            Console.WriteLine("fecha f " + temp.Fecha_Fin);
            ViewData["data"] = temp;
            getLogin();
            return View();
        }

        public IActionResult ModificarOferta(OfertaModel temp)
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            TemBussi.editarOferta(temp);
            getLogin();
            return RedirectToAction("VisualizarOferta");
        }


    }
}
