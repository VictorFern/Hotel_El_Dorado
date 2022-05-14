using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Hotel_El_Dorado_Admin.Models;
using Hotel_El_Dorado_Admin.Business;

namespace Hotel_El_Dorado_Admin.Controllers
{
    public class AdministradorController : Controller
    {
        public IConfiguration Configuration { get;}

        public AdministradorController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Login()
        {
            HttpContext.Session.SetString("variableSession", "valor en session");
            HttpContext.Session.SetInt32("variableInt", 0);
            return View();
        }

        [HttpPost]
        public IActionResult Login(AdministradorModel model)
        {
            /*
            * Comprueba si ya ha iniciado sesión
            */
            if(!Cache.Instance.isLogged)
            {
                Cache.Instance.isLogged = true;

                AdministradorBusiness administradorBusiness = new AdministradorBusiness(Configuration);
                List<AdministradorModel> lista = administradorBusiness.login(model);
                if (lista.Count > 0) 
                { 
                    int valor = lista[0].id;

                    HttpContext.Session.SetInt32("variableInt", valor);
                    return RedirectToAction("Index");
                }
            }
            return View();

        }

        public IActionResult Index()
        {
            if (Cache.Instance.isLogged)
            {
                int valor = (int)HttpContext.Session.GetInt32("variableInt");
                ViewBag.Session = valor;
                return View();
            }
            return RedirectToAction("Login");
        }
    }
}
