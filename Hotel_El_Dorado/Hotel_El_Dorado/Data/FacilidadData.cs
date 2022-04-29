using Hotel_El_Dorado.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_El_Dorado.Data
{
    public class FacilidadData
    {

        public IConfiguration Configuration { get; }

        public FacilidadData(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public List<FacilidadModel> ObtenerFacilidades() {
            List <FacilidadModel> lista = new List<FacilidadModel>();

            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec ObtenerInfoFacilidad";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();

                    while (productoReader.Read())
                    {
                        FacilidadModel facilidad = new FacilidadModel();
                        facilidad.Src = productoReader["IMAGEN"].ToString();
                        facilidad.Descripcion = productoReader["DESCRIPCION"].ToString();
                        lista.Add(facilidad);
                    }
                }
            }
            return lista;
        }
    }
}
