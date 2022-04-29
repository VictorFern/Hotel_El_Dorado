using Hotel_El_Dorado.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_El_Dorado.Data
{
    public class ComoLlegarData
    {
        public IConfiguration Configuration { get; }

        public ComoLlegarData(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ComoLlegarModel obtenerComoLlegar()
        {
            ComoLlegarModel comoLlegarModel = new ComoLlegarModel();

            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec sp_GetInfoComoLlegar";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    while (productoReader.Read())
                    {
                        comoLlegarModel.Titulo = productoReader["TITULO"].ToString();
                        comoLlegarModel.Descripcion = productoReader["DESCRIPCION"].ToString();
                    }
                    connection.Close();
                }
            }
            return comoLlegarModel;
        }
    }
}
