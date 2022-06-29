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

        public AdministradorBusiness()
        {
        }

        public List<AdministradorModel> login(AdministradorModel model)
        {
            AdministradorData administradorData = new AdministradorData(Configuration);
            return administradorData.login(model);
        }

        public List<TemporadaModel> ObtenerTemporada()
        {
            AdministradorData administradorData = new AdministradorData(Configuration);
            return administradorData.ObtenerTemporada();
        }

        public TemporadaModel ObtenerTemporadaID()
        {
            AdministradorData administradorData = new AdministradorData(Configuration);
            return administradorData.ObtenerTemporadaID();
        }


        public bool guardarTemporada(TemporadaModel temporada)
        {
            AdministradorData adminData = new AdministradorData(Configuration);
            return adminData.guardarTemporada(temporada);
        }

        public bool editarTemporada(TemporadaModel temporada)
        {
            AdministradorData adminData = new AdministradorData(Configuration);
            return adminData.editarTemporada(temporada);
        }

        public bool eliminarTemporada(TemporadaModel temporada)
        {
            AdministradorData adminData = new AdministradorData(Configuration);
            return adminData.eliminarTemporada(temporada);
        }


        public bool guardarOferta(OfertaModel temp)
        {
            AdministradorData adminData = new AdministradorData(Configuration);
            return adminData.guardarOferta(temp);
        }

        public List<OfertaModel> ObtenerOfertas()
        {
            AdministradorData administradorData = new AdministradorData(Configuration);
            return administradorData.ObtenerOfertas();
        }
        public bool eliminarOferta(OfertaModel temp)
        {
            AdministradorData adminData = new AdministradorData(Configuration);
            return adminData.eliminarOferta(temp);
        }

        public bool editarOferta(OfertaModel temp)
        {
            AdministradorData adminData = new AdministradorData(Configuration);
            return adminData.editarOferta(temp);
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

        public List<ReservacionModel> verListadoReservacion()
        {
            AdministradorData administradorData = new AdministradorData(Configuration);
            return administradorData.verListadoReservaciones();
        }

        public List<ReservacionModel> verListadoReservacionId(int id)
        {
            AdministradorData administradorData = new AdministradorData(Configuration);
            return administradorData.verListadoReservacionId(id);
        }

        public bool eliminarReporteReservacionId(int id)
        {
            AdministradorData administradorData = new AdministradorData(Configuration);
            return administradorData.eliminarReporteReservacionId(id);
        }

    }
}
