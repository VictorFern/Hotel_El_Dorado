using Hotel_El_Dorado.Data;
using Hotel_El_Dorado.Models;
using Microsoft.Extensions.Configuration;

namespace Hotel_El_Dorado.Business
{
    public class ComoLlegarBusiness
    {
        public IConfiguration Configuration { get; }
        public ComoLlegarBusiness(IConfiguration configuration)
        {
            Configuration = configuration;
        } 
        public ComoLlegarModel ObtenerHome()
        {
            ComoLlegarData data = new ComoLlegarData(Configuration);
            return data.obtenerComoLlegar();
        }
    }
}
