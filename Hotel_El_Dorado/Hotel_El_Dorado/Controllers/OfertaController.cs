using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Hotel_El_Dorado.Business;
using Hotel_El_Dorado.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado.Controllers
{
    [Route("Oferta")]
    public class OfertaController : Controller
    {
        public IConfiguration Configuration { get; }
        private readonly ILogger<OfertaController> _logger;
        private readonly IWebHostEnvironment _iweb;
        private static string Imagen = "";

        public OfertaController(IConfiguration configuration, ILogger<OfertaController> logger, IWebHostEnvironment iweb)
        {
            _logger = logger;
            _iweb = iweb;
            Configuration = configuration;
        } // constructor

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

            return "<img src='" + ruta + "'>";

        }

        [Route("Crear")]
        [HttpPost]
        public IActionResult CrearOferta(OfertaModel ofertaModel)
        {
            ofertaModel.Imagen = Imagen;
            OfertaBusiness ofertaBusiness = new OfertaBusiness(Configuration);
            Imagen = "";
            Console.WriteLine(ofertaModel.ID_Oferta);
            Console.WriteLine(ofertaModel.Oferta);
            Console.WriteLine(ofertaModel.Imagen);
            Console.WriteLine(ofertaModel.Fecha_Inicio);
            Console.WriteLine(ofertaModel.Fecha_Fin);
            return ofertaBusiness.CrearOferta(ofertaModel);
        }

        [Route("Obtener")]
        public IActionResult ObtenerOferta()
        {
            OfertaBusiness ofertaBusiness = new OfertaBusiness(Configuration);
            List<OfertaModel> listaOferta = new List<OfertaModel>();
            listaOferta = ofertaBusiness.ObtenerOferta();
            ViewBag.ListaOferta = listaOferta;
            return View("/Views/Home/Index.cshtml");
        }

        [Route("Eliminar")]
        [HttpPost]
        public IActionResult EliminarOferta(OfertaModel ofertaModel)
        {
            OfertaBusiness ofertaBusiness = new OfertaBusiness(Configuration);
            Imagen = "";
            return ofertaBusiness.EliminarOferta(ofertaModel);
        }

        [Route("Actualizar")]
        [HttpPost]
        public IActionResult ActualizarOferta(OfertaModel ofertaModel)
        {
            ofertaModel.Imagen = Imagen;
            OfertaBusiness ofertaBusiness = new OfertaBusiness(Configuration);
            Imagen = "";
            return ofertaBusiness.ActualizarOferta(ofertaModel);
        }

    }
}
