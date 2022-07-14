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
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Hotel_El_Dorado_Admin.Controllers
{
    public class OfertaController : Controller
    {
        public IConfiguration Configuration { get; }
        private static string Imagen = "";
        private readonly IWebHostEnvironment _iweb;
        private readonly IHostingEnvironment _webhost;

        public OfertaController(IConfiguration configuration, IHostingEnvironment webhost)
        {
            Configuration = configuration;
            _webhost = webhost;
        }

        public string copiarImagen()
        {
            var newFileName = string.Empty;
            var fileName = "";
            if (HttpContext.Request.Form.Files != null)
            {
                fileName = string.Empty;
                string PathDB = string.Empty;

                var files = HttpContext.Request.Form.Files;

                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        //Getting FileName
                        fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                        //Assigning Unique Filename (Guid)
                        var myUniqueFileName = Path.GetFileNameWithoutExtension(fileName);

                        //Getting file Extension
                        var FileExtension = Path.GetExtension(fileName);

                        // concating  FileName + FileExtension
                        newFileName = myUniqueFileName + FileExtension;

                        // Combines two strings into a path.
                        fileName = Path.Combine(_webhost.WebRootPath, "img") + $@"\{newFileName}";

                        // if you want to store path of folder in database
                        PathDB = "img/" + newFileName;

                        using (FileStream fs = System.IO.File.Create(fileName))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            }

            return newFileName;
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
            temp.Imagen = copiarImagen();
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
            temp.Imagen = copiarImagen();
            TemBussi.editarOferta(temp);
            getLogin();
            return RedirectToAction("VisualizarOferta");
        }


    }
}
