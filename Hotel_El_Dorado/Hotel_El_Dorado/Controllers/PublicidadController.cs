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
    [Route("Publicidad")]
    public class PublicidadController : Controller
    {
        public IConfiguration Configuration { get; }
        private readonly ILogger<PublicidadController> _logger;
        private readonly IWebHostEnvironment _iweb;
        private static string Imagen = "";

        public PublicidadController(IConfiguration configuration, ILogger<PublicidadController> logger, IWebHostEnvironment iweb)
        {
            _logger = logger;
            _iweb = iweb;
            Configuration = configuration;
        } // constructor

        [Route("Obtener")]
        [HttpPost]
        public IActionResult ObtenerPublicidad()
        {
            PublicidadBusiness publicidadBusiness = new PublicidadBusiness(Configuration);
            List<PublicidadModel> listaPublicidad = new List<PublicidadModel>();
            listaPublicidad = publicidadBusiness.ObtenerPublicidad();
            ViewBag.ListaPublicidad = listaPublicidad;
            return View("/Views/Home/Index.cshtml");
        }

        [Route("ObtenerID")]
        public PublicidadModel ObtenerPublicidadID(int ID)
        {
            PublicidadBusiness publicidadBusiness = new PublicidadBusiness(Configuration);
            return publicidadBusiness.ObtenerPublicidadID(ID);
        }
        [Route("MostrarPublicidad")]
        public IActionResult MostrarPublicidad()
        {
            return View();
        }

        [Route("MostrarPublicidadActual")]
        [HttpGet]
        public string MostrarPublicidadActual()
        {
            string html = "";
            PublicidadBusiness publicidadBusiness = new PublicidadBusiness(Configuration);
            List<PublicidadModel> listaPublicidad = new List<PublicidadModel>();
            listaPublicidad = publicidadBusiness.ObtenerPublicidad();
            foreach(PublicidadModel publicidad in listaPublicidad)
            {
                html += "<tr>"
                + "<td class='text-center'>" + publicidad.ID_Publicidad + "</td>"
                + "<td class='text-center'>" + "<a href = 'https://"+ publicidad.Link+"' target = '_blank'>" + publicidad.Link + "</a></td>"
                + "<td class='text-center'>" + "<img src = '../Imagenes/" + publicidad.Imagen + "' class='img-fluid' alt=''>" + "</td>"
                + "<td class='text-center'><a href='javascript:;' onclick='modificarPublicidad(" + publicidad.ID_Publicidad + ");'>Modificar</a></td>"
                + "<td class='text-center'><a href='javascript:;' onclick='eliminarPublicidad(" + publicidad.ID_Publicidad + ");'>Eliminar</a></td></tr>";
            }
            return html;
        }

        [Route("Imagen")]
        [HttpPost]
        public async Task<String> AgregarImagen(IList<IFormFile> files)
        {
            Imagen = "";
            var uploads = Path.Combine(_iweb.WebRootPath, "Imagenes");
            string ruta = "";
            foreach (var doc in files)
            {
                var filePath = Path.Combine(uploads, doc.FileName);
                ruta = filePath;
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                doc.CopyTo(fileStream);
                fileStream.Close();
                Imagen = doc.FileName;
            }

            return "<img src='../Imagenes/" + Imagen + "' class='img-fluid' alt=''>";

        }


        [Route("Crear")]
        [HttpPost]
        public IActionResult CrearPublicidad(PublicidadModel publicidadModel)
        {
            publicidadModel.Imagen = Imagen;
            PublicidadBusiness publicidadBusiness = new PublicidadBusiness(Configuration);
            Imagen = "";
            return publicidadBusiness.CrearPublicidad(publicidadModel);

        }

        [Route("Eliminar/{ID}")]
        [HttpGet]
        public string EliminarPublicidad(int ID)
        {
            PublicidadBusiness publicidadBusiness = new PublicidadBusiness(Configuration);
            Imagen = "";
            publicidadBusiness.EliminarPublicidad(ID);
            return MostrarPublicidadActual();

        }

        [Route("ModificarPublicidad/{ID}")]
        [HttpGet]
        public IActionResult MostrarActualizarPublicidad(int ID)
        {
            Console.WriteLine("Entro");
            PublicidadBusiness publicidadBusiness = new PublicidadBusiness(Configuration);
            Imagen = "";
            PublicidadModel publicidad = publicidadBusiness.ObtenerPublicidadID(ID);
            ViewBag.Publicidad = publicidad;
            return View("ModificarPublicidad");

        }

        [Route("Actualizar")]
        [HttpPost]
        public IActionResult ActualizarPublicidad(PublicidadModel publicidadModel)
        {
            publicidadModel.Imagen = Imagen;
            PublicidadBusiness publicidadBusiness = new PublicidadBusiness(Configuration);
            Imagen = "";
            return publicidadBusiness.ActualizarPublicidad(publicidadModel);

        }

    }
}
