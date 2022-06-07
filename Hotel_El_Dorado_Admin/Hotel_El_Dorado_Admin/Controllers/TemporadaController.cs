using Hotel_El_Dorado_Admin.Business;
using Hotel_El_Dorado_Admin.Models;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult InsertarTemporada()
        {
            return View();
        }

        [HttpPost]
        public IActionResult guardarTemporada(TemporadaModel temp)
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            TemBussi.guardarTemporada(temp);
            return RedirectToAction("VisualizarTemporada");
        }


        public IActionResult EliminarTemporada (TemporadaModel temp)
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            TemBussi.eliminarTemporada(temp);
            return RedirectToAction("VisualizarTemporada");
        }

        public IActionResult EditarTemporada(TemporadaModel temp)
        {
            ViewData["item"] = temp;
            return View();
        }

        public IActionResult ModificarTemporada(TemporadaModel temp)
        {
            AdministradorBusiness TemBussi = new AdministradorBusiness(Configuration);
            TemBussi.editarTemporada(temp);
            return RedirectToAction("VisualizarTemporada");
        }

        public IActionResult VisualizarTemporada()
        {
            AdministradorBusiness adminBus = new AdministradorBusiness(Configuration);
            List<TemporadaModel> temp = new List<TemporadaModel>();
            temp = adminBus.ObtenerTemporada();
            return View(temp);
        }


    }
}
