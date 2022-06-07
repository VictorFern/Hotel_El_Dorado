using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado_Admin.Models
{
    public class TemporadaModel
    {
        public int id { get; set; }

        public string fechaInicio { get; set; }

        public string fechaFin { get; set; }

        public float descuento { get; set; }

    }
}
