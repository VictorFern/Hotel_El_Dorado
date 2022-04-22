using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Hotel_El_Dorado.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_El_Dorado.Models;

namespace Hotel_El_Dorado.Business
{
    public class PublicidadBusiness
    {
        public IConfiguration Configuration { get; }
        public PublicidadBusiness(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor
        public List<PublicidadModel> ObtenerPublicidad()
        {
            PublicidadData publicidadData = new PublicidadData(Configuration);
            return publicidadData.ObtenerPublicidad();
        }

        public PublicidadModel ObtenerPublicidadID(int ID)
        {
            PublicidadData publicidadData = new PublicidadData(Configuration);
            return publicidadData.ObtenerPublicidadID(ID);
        }

        public IActionResult CrearPublicidad(PublicidadModel publicidadModel)
        {
            PublicidadData publicidadData = new PublicidadData(Configuration);
            return publicidadData.CrearPublicidad(publicidadModel);
        }

        public void EliminarPublicidad(int ID)
        {
            PublicidadData publicidadData = new PublicidadData(Configuration);
            publicidadData.EliminarPublicidad(ID);
        }

        public IActionResult ActualizarPublicidad(PublicidadModel publicidadModel)
        {
            PublicidadData publicidadData = new PublicidadData(Configuration);
            return publicidadData.ActualizarPublicidad(publicidadModel);
        }
    }
}
