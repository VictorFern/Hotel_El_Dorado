using Hotel_El_Dorado_Admin.Data;
using Hotel_El_Dorado_Admin.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Hotel_El_Dorado_Admin.Business
{
    public class HabitacionBusiness
    {
        public IConfiguration Configuration { get; }
        public HabitacionBusiness(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public List<HabitacionModel> ConsultarDisponibilidad(string fEntrada, string fSalida, int tipo)
        {
            HabitacionData haData = new HabitacionData(Configuration);
            return haData.ConsultarDisponibilidad(fEntrada, fSalida, tipo);
        }
    }
}
