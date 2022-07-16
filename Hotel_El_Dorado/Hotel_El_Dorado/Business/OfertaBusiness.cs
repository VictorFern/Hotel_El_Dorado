using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Hotel_El_Dorado.Data;
using Hotel_El_Dorado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado.Business
{
    public class OfertaBusiness
    {
        public IConfiguration Configuration { get; }
        public OfertaBusiness(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor

        public IActionResult CrearOferta(OfertaModel ofertaModel)
        {
            OfertaData ofertaData = new OfertaData(Configuration);
            return ofertaData.CrearOferta(ofertaModel);
        }

        public List<OfertaModel> ObtenerOferta()
        {
            OfertaData ofertaData = new OfertaData(Configuration);
            return ofertaData.ObtenerOferta();
        }

        public IActionResult EliminarOferta(OfertaModel ofertaModel)
        {
            OfertaData ofertaData = new OfertaData(Configuration);
            return ofertaData.EliminarOferta(ofertaModel);
        }

        public IActionResult ActualizarOferta(OfertaModel ofertaModel)
        {
            OfertaData ofertaData = new OfertaData(Configuration);
            return ofertaData.ActualizarOferta(ofertaModel);
        }

    }
}
