using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Hotel_El_Dorado_Admin.Models;
namespace Hotel_El_Dorado_Admin.Data
{
    public class AdministradorData
    {
        public IConfiguration Configuration { get; }

        public AdministradorData(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public List<AdministradorModel> login(AdministradorModel model)
        {
            List<AdministradorModel> lista = new List<AdministradorModel>();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec sp_LOGIN @param_NOMBRE= '{model.nombre}', @param_PASS= '{model.contrasenna}'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta

                    while (productoReader.Read())
                    {
                        model = new AdministradorModel();
                        model.id = int.Parse(productoReader["ID_ADMINISTRADOR"].ToString());
                        model.nombre = productoReader["NOMBRE_ADMINISTRADOR"].ToString();
                        model.contrasenna = productoReader["CONTRASENNA"].ToString();
                        lista.Add(model);
                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }

            return lista;
        }

        public List<HabitacionModel> ObtenerHabitaciones()
        {
            List<HabitacionModel> listaHabitaciones = new List<HabitacionModel>();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec ObtenerHabitaciones";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta

                    while (productoReader.Read())
                    {
                        HabitacionModel habitacion = new HabitacionModel();
                        habitacion.ID_Habitacion = int.Parse(productoReader["ID_HABITACION"].ToString());
                        habitacion.Numero_Habitacion = int.Parse(productoReader["NUMERO_HABITACION"].ToString());
                        habitacion.Activa = bool.Parse(productoReader["ACTIVA"].ToString());
                        habitacion.Imagen = productoReader["IMAGEN"].ToString();
                        habitacion.Costo = int.Parse(productoReader["COSTO"].ToString());
                        habitacion.Tipo_Habitacion = int.Parse(productoReader["ID_TIPO"].ToString());
                        habitacion.Descripcion = productoReader["DESCRIPCION"].ToString();
                        listaHabitaciones.Add(habitacion);
                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }

            return listaHabitaciones;
        }

        public List<ReservacionModel> ObtenerReservaciones()
        {
            List<ReservacionModel> listaReservaciones = new List<ReservacionModel>();
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec ObtenerReservaciones";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (productoReader.Read())
                    {
                        ReservacionModel reservacion = new ReservacionModel();
                        reservacion.ID_Reservacion = Int32.Parse(productoReader["ID_RESERVACION"].ToString());
                        reservacion.Fecha_Reservacion = productoReader["FECHA_RESERVACION"].ToString();
                        reservacion.Fecha_Entrada = productoReader["FECHA_ENTRADA"].ToString();
                        reservacion.Fecha_Salida = productoReader["FECHA_SALIDA"].ToString();
                        reservacion.Habitacion.ID_Habitacion = Int32.Parse(productoReader["ID_HABITACION"].ToString());

                        listaReservaciones.Add(reservacion);
                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }
            return listaReservaciones;
        }

    }
}
