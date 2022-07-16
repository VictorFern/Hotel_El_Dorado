﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado_Admin.Models
{
    public class OfertaModel
    {

        public int ID_Oferta { get; set; }
        public int Oferta { get; set; }
        public string Imagen { get; set; }

        public string Fecha_Inicio { get; set; }

        public string Fecha_Fin { get; set; }

        public string Tipo_Habitacion { get; set; }

        public int Tipo { get; set; }

    }
}
