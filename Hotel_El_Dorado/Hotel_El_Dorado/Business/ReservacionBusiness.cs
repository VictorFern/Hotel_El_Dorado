using Hotel_El_Dorado.Data;
using Hotel_El_Dorado.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado.Business
{
    public class ReservacionBusiness
    {
        public IConfiguration Configuration { get; }
        public ReservacionBusiness(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor

        public List<ReservacionModel> ObtenerReservaciones()
        {
            ReservacionData reservacionData = new ReservacionData(Configuration);
            return reservacionData.ObtenerReservaciones();
        }

        public int VerificarFechas(string fechaEntrada, string fechaSalida, int tipoHabitacion)
        {

            ReservacionData reservacionData = new ReservacionData(Configuration);

            return reservacionData.VerificarFechas(fechaEntrada, fechaSalida, tipoHabitacion);
        }

        public int RealizarReservacion(ReservacionModel reservacionModel)
        {

            ReservacionData reservacionData = new ReservacionData(Configuration);

            return reservacionData.RealizarReservacion(reservacionModel);
        }


    }
}
