using Hotel_El_Dorado.Data;
using Hotel_El_Dorado.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado.Business
{
    public class HabitacionBusiness
    {

        public IConfiguration Configuration { get; }
        public HabitacionBusiness(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor

        public HabitacionModel ObtenerHabitacionesIDTipo(int id)
        {
            HabitacionData habitacionData = new HabitacionData(Configuration);
            return habitacionData.ObtenerHabitacionesIDTipo(id);
        }

    }
}
