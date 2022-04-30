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
    public class TipoHabitacionData
    {
        public IConfiguration Configuration { get; }

        public TipoHabitacionData(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor
        public List<object> ObtenerTipohabitacion()
        {
            List<object> lista = new List<object>();

            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec sp_TARIFAS";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (productoReader.Read())
                    {
                        TipoHabitacionModel tipoHabitacionModel = new TipoHabitacionModel();
                        tipoHabitacionModel.tipo = productoReader["TIPO"].ToString();
                        tipoHabitacionModel.descripcion = productoReader["DESCRIPCION"].ToString();
                        tipoHabitacionModel.caracteristicas = productoReader["CARACTERISTICAS"].ToString();
                        tipoHabitacionModel.costo = int.Parse(productoReader["COSTO"].ToString());
                        tipoHabitacionModel.imagen = productoReader["IMAGEN"].ToString();
                        lista.Add(tipoHabitacionModel);
                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }
            return lista;
        }
    }
}
