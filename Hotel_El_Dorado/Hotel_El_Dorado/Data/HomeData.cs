using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Hotel_El_Dorado.Models;
namespace Hotel_El_Dorado.Data
{
    public class HomeData
    {
        public IConfiguration Configuration { get; }

        public HomeData(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor

        public HomeModel ObtenerHome()
        {
            HomeModel home = new HomeModel();
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec sp_ObtenerHome";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (productoReader.Read())
                    {
                        home.home = productoReader["INFO_HOME"].ToString();
                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }
            return home;
        }
    }
}
