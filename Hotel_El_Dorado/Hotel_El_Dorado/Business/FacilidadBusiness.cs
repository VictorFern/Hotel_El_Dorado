using Hotel_El_Dorado.Data;
using Hotel_El_Dorado.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Hotel_El_Dorado.Business
{
    public class FacilidadBusiness
    {
        public IConfiguration Configuration { get; }
        public FacilidadBusiness(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public List<FacilidadModel> ObtenerFacilidades()
        {
            FacilidadData data = new FacilidadData(Configuration);
            return data.ObtenerFacilidades();
        }

    }
}
