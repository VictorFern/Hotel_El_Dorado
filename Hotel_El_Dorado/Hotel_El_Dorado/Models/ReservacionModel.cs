using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado.Models
{
    public class ReservacionModel
    {
        public int ID_Reservacion { get; set; }
        public string Fecha_Reservacion { get; set; }
        public string Fecha_Entrada { get; set; }
        public string Fecha_Salida { get; set; }
        public HabitacionModel Habitacion { get; set; }
        public ClienteModel Cliente { get; set; }
        public int tipoHabitacion { get; set; }
        public int Costo_Total { get; set; }
        public int idHabitacion { get; set; }

        public ReservacionModel()
        {
            Habitacion = new HabitacionModel();
            Cliente = new ClienteModel();
        }
    }
}
