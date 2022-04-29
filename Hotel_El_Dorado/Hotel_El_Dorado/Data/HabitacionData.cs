using Hotel_El_Dorado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado.Data
{
    public class HabitacionData
    {

        public IConfiguration Configuration { get; }

        public HabitacionData(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor


        public HabitacionModel ObtenerHabitacionesIDTipo(int id)
        {
            HabitacionModel habitacion = new HabitacionModel();
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec ObtenerHabitacionesIDTipo @param_ID_TIPO={id}";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (productoReader.Read())
                    {

                        habitacion.ID_Habitacion = Int32.Parse(productoReader["ID_HABITACION"].ToString());
                        habitacion.Numero_Habitacion = Int32.Parse(productoReader["NUMERO_HABITACION"].ToString());
                        habitacion.Activa = bool.Parse(productoReader["ACTIVA"].ToString());
                        habitacion.Imagen = productoReader["IMAGEN"].ToString();
                        habitacion.Costo = Int32.Parse(productoReader["COSTO"].ToString());
                        habitacion.Tipo_Habitacion = Int32.Parse(productoReader["ID_TIPO"].ToString());
                        habitacion.Descripcion = productoReader["DESCRIPCION"].ToString();

                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }
            return habitacion;
        }

    }
}
