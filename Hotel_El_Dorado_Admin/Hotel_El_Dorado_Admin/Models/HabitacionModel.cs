using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado_Admin.Models
{
    public class HabitacionModel
    {

        public int ID_Habitacion { get; set; }
        public int Numero_Habitacion { get; set; }
        public bool Activa { get; set; }
        public string Imagen { get; set; }
        public int Costo { get; set; }
        public int Tipo_Habitacion { get; set; }
        public string Nombre_Tipo_Habitacion { get; set; }
        public string Descripcion { get; set; }

    }
}
