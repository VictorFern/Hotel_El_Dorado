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
    public class ReservacionData
    {

        public IConfiguration Configuration { get; }

        public ReservacionData(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor

        public List<ReservacionModel> ObtenerReservaciones()
        {
            List<ReservacionModel> listaReservaciones = new List<ReservacionModel>();
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec ObtenerReservacion";
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
                        reservacion.ID_Reservacion = Int32.Parse(productoReader["ID_Publicidad"].ToString());
                        reservacion.Fecha_Reservacion = productoReader["Link"].ToString();
                        reservacion.Fecha_Entrada = productoReader["Link"].ToString();
                        reservacion.Fecha_Salida = productoReader["Link"].ToString();
                        reservacion.Habitacion.ID_Habitacion = Int32.Parse(productoReader["Link"].ToString());

                        listaReservaciones.Add(reservacion);
                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }
            return listaReservaciones;
        }

        public int VerificarFechas(string fechaEntrada, string fechaSalida, int tipoHabitacion)
        {

            int id_Habitacion = 0;
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec VerificarFechas @param_fechaEntrada='{fechaEntrada}', @param_fechaSalida='{fechaSalida}', @param_tipoHabitacion={tipoHabitacion}";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (productoReader.Read())
                    {
                        id_Habitacion = Int32.Parse(productoReader["ID_HABITACION"].ToString());

                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }

            return id_Habitacion;
            
        }

        public int RealizarReservacion(ReservacionModel reservacionModel)
        {

            int reservacion = 0;
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec RealizarReservacion @param_FechaEntrada='{reservacionModel.Fecha_Entrada}', @param_FechaSalida='{reservacionModel.Fecha_Salida}', @param_IDHabitacion={reservacionModel.Habitacion.ID_Habitacion}, @param_CostoTotal={reservacionModel.Costo_Total}, @param_CedulaCliente={reservacionModel.Cliente.Cedula}, @param_NombreCliente='{reservacionModel.Cliente.Nombre}', @param_ApellidosCliente='{reservacionModel.Cliente.Apellidos}', @param_EmailCliente='{reservacionModel.Cliente.Email}', @param_TarjetaCliente={reservacionModel.Cliente.Tarjeta}";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (productoReader.Read())
                    {
                        reservacion = Int32.Parse(productoReader["ID_RESERVACION"].ToString());

                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }

            return reservacion;

        }

    }
}
