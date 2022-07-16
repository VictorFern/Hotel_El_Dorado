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
    public class TipoHabitacionBusiness
    {
        public IConfiguration Configuration { get; }
        public TipoHabitacionBusiness(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor
        public List<object> ObtenerTipohabitacion()
        {
            TipoHabitacionData tipoHabitacionData = new TipoHabitacionData(Configuration);
            return tipoHabitacionData.ObtenerTipohabitacion();
        }
    }
}
