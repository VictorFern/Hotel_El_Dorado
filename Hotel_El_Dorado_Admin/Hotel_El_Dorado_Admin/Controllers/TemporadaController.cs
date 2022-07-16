using Hotel_El_Dorado_Admin.Business;
using Hotel_El_Dorado_Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado_Admin.Controllers
{
    public class TemporadaController : Controller
    {
        public IConfiguration Configuration { get; }

        public TemporadaController(IConfiguration configuration)
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
        public IActionResult InsertarTemporada()
        {
            getLogin();
            return View();
        }

        [HttpPost]
        public IActionResult guardarTemporada(TemporadaModel temp)
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            TemBussi.guardarTemporada(temp);
            getLogin();
            return RedirectToAction("VisualizarTemporada");
        }


        public IActionResult EliminarTemporada (TemporadaModel temp)
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            TemBussi.eliminarTemporada(temp);
            getLogin();
            return RedirectToAction("VisualizarTemporada");
        }

        public IActionResult EditarTemporada(TemporadaModel temp)
        {
            ViewData["item"] = temp;
            getLogin();
            return View();
        }

        public IActionResult ModificarTemporada(TemporadaModel temp)
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            TemBussi.editarTemporada(temp);
            getLogin();
            return RedirectToAction("VisualizarTemporada");
        }

        public IActionResult VisualizarTemporada()
        {
            AdministradorBusiness adminBus = new AdministradorBusiness(Configuration);
            List<TemporadaModel> temp = new List<TemporadaModel>();
            temp = adminBus.ObtenerTemporada();
            getLogin();
            return View(temp);
        }


    }
}
