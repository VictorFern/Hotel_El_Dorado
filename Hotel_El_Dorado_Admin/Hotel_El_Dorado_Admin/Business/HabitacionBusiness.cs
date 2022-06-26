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
        public List<HabitacionModel> obtenerTipoHabitacionStandard()
        {
            HabitacionData haData = new HabitacionData(Configuration);
            return haData.obtenerTipoHabitacionStandard();
        }

        public List<HabitacionModel> obtenerTipoHabitacionJunnior()
        {
            HabitacionData haData = new HabitacionData(Configuration);
            return haData.obtenerTipoHabitacionJunnior();
        }

        public List<HabitacionModel> obtenerTipoHabitacionSuit()
        {
            HabitacionData haData = new HabitacionData(Configuration);
            return haData.obtenerTipoHabitacionSuit();
        }

        public List<HabitacionModel> obtenerStandard()
        {
            HabitacionData haData = new HabitacionData(Configuration);
            return haData.obtenerStandard();
        }

        public List<HabitacionModel> obtenerJunnior()
        {
            HabitacionData haData = new HabitacionData(Configuration);
            return haData.obtenerJunnior();
        }

        public List<HabitacionModel> obtenerSuit()
        {
            HabitacionData haData = new HabitacionData(Configuration);
            return haData.obtenerSuit();
        }

        public bool activa(int tipo)
        {
            HabitacionData haData = new HabitacionData(Configuration);
            return haData.activa(tipo);
        }

        public void ActualizarHabitacionConImagen(HabitacionModel model)
        {
            HabitacionData haData = new HabitacionData(Configuration);
            haData.ActualizarHabitacionConImagen(model);
        }

        public void ActualizarHabitacionSinImagen(HabitacionModel model)
        {
            HabitacionData haData = new HabitacionData(Configuration);
            haData.ActualizarHabitacionSinImagen(model);
        }

    }
}
