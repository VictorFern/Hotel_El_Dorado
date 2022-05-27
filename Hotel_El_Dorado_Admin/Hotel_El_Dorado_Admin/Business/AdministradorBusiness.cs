using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Hotel_El_Dorado_Admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_El_Dorado_Admin.Models;
namespace Hotel_El_Dorado_Admin.Business
{
    public class AdministradorBusiness
    {
        public IConfiguration Configuration { get; }

        public AdministradorBusiness(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public List<AdministradorModel> login(AdministradorModel model)
        {
            AdministradorData administradorData = new AdministradorData(Configuration);
            return administradorData.login(model);
        }

        public List<HabitacionModel> ObtenerHabitaciones()
        {
            AdministradorData administradorData = new AdministradorData(Configuration);
            return administradorData.ObtenerHabitaciones();
        }

        public List<ReservacionModel> ObtenerReservaciones()
        {
            AdministradorData administradorData = new AdministradorData(Configuration);
            return administradorData.ObtenerReservaciones();
        }

    }
}
