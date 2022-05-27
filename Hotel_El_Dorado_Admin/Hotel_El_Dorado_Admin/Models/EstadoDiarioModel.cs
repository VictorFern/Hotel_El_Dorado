using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado_Admin.Models
{
    public class EstadoDiarioModel
    {
        public int ID_Reservacion { get; set; }
        public string Fecha_Reservacion { get; set; }
        public string Fecha_Entrada { get; set; }
        public string Fecha_Salida { get; set; }
        public HabitacionModel Habitacion { get; set; }
        public string Estado { get; set; }

        public EstadoDiarioModel()
        {
            Habitacion = new HabitacionModel();
        }
    }
}
