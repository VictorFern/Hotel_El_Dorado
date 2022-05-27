using Hotel_El_Dorado_Admin.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_El_Dorado_Admin.Data
{
    public class HabitacionData
    {
        public IConfiguration Configuration { get; }
        public HabitacionData(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public List<HabitacionModel> ConsultarDisponibilidad(string fEntrada, string fSalida, int tipo) 
        {
            List<HabitacionModel> list = new List<HabitacionModel>();
            
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec ComprobarDisponibilidad @fEntrada='" + fEntrada + "', @fSalida='" + fSalida + "', @tipo=" + tipo;
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    HabitacionModel habitacion;
                    while (productoReader.Read())
                    {
                        habitacion = new HabitacionModel();
                        habitacion.Numero_Habitacion = Int32.Parse(productoReader["NUMERO"].ToString());
                        habitacion.Costo = Int32.Parse(productoReader["COSTO"].ToString());
                        habitacion.Tipo_HabitacionT = productoReader["TIPO"].ToString();
                        list.Add(habitacion);
                    }
                    connection.Close();
                }
            }

            return list;
        }
    }
}
