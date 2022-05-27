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
                    HttpContext.Session.SetString("nombreAdmin", lista[0].nombre);
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
                string nombre = HttpContext.Session.GetString("nombreAdmin");
                ViewBag.nombre = nombre;
                ViewBag.Session = valor;
                return View();
            }
            return RedirectToAction("Login");
        }

        public IActionResult logOut()
        {
            Cache.Instance.isLogged = false;
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

	    public IActionResult habitacionStandard()
        {
            return View();
        }

        public IActionResult verHabitacionStandard()
        {
            return View();
        }

        public IActionResult EstadoActualHabitacion()
        {
            AdministradorBusiness administradorBusiness = new AdministradorBusiness(Configuration);

            List<HabitacionModel> listaHabitaciones = new List<HabitacionModel>();
            listaHabitaciones = administradorBusiness.ObtenerHabitaciones();

            List<ReservacionModel> listaReservaciones = new List<ReservacionModel>();
            listaReservaciones = administradorBusiness.ObtenerReservaciones();

            List<EstadoDiarioModel> listaEstadoDiario = new List<EstadoDiarioModel>();

            bool ocupado = false;

            for (int i = 0; i < listaHabitaciones.Count(); i++)
            {

                for (int j = 0; j < listaReservaciones.Count(); j++)
                {
                    if (listaHabitaciones[i].ID_Habitacion == listaReservaciones[j].Habitacion.ID_Habitacion)
                    {
                        ocupado = true;
                        break;
                    }
                }

                if (ocupado)
                {
                    for (int j = 0; j < listaReservaciones.Count(); j++)
                    {
                        if (listaHabitaciones[i].ID_Habitacion == listaReservaciones[j].Habitacion.ID_Habitacion)
                        {
                            EstadoDiarioModel estadoDiario = new EstadoDiarioModel();
                            estadoDiario.Estado = "Ocupado";
                            estadoDiario.Fecha_Entrada = listaReservaciones[j].Fecha_Entrada;
                            estadoDiario.Fecha_Reservacion = listaReservaciones[j].Fecha_Reservacion;
                            estadoDiario.Fecha_Salida = listaReservaciones[j].Fecha_Salida;
                            estadoDiario.ID_Reservacion = listaReservaciones[j].ID_Reservacion;
                            estadoDiario.Habitacion.Numero_Habitacion = listaHabitaciones[i].Numero_Habitacion;
                            listaEstadoDiario.Add(estadoDiario);
                            break;
                        }
                    }
                }
                else
                {
                    EstadoDiarioModel estadoDiario = new EstadoDiarioModel();
                    estadoDiario.Estado = "Disponible";
                    estadoDiario.Fecha_Entrada = "-";
                    estadoDiario.Fecha_Reservacion = "-";
                    estadoDiario.Fecha_Salida = "-";
                    estadoDiario.ID_Reservacion = 0;
                    estadoDiario.Habitacion.Numero_Habitacion = listaHabitaciones[i].Numero_Habitacion;
                    listaEstadoDiario.Add(estadoDiario);
                }

                ocupado = false;

            }

            ViewBag.ListaEstadoDiario = listaEstadoDiario;

            return View();
        }

    }
}
