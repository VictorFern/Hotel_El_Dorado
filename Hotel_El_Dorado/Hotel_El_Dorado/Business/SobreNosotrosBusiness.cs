using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Hotel_El_Dorado.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_El_Dorado.Models;

namespace Hotel_El_Dorado.Business
{
    public class SobreNosotrosBusiness
    {
        public IConfiguration Configuration { get; }
        public SobreNosotrosBusiness(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor
        public SobreNosotrosModel ObtenerSobreNosotros()
        {
            SobreNosotrosData sobreNosotrosData = new SobreNosotrosData(Configuration);
            return sobreNosotrosData.ObtenerSobreNosotros();
        }

    }
}
