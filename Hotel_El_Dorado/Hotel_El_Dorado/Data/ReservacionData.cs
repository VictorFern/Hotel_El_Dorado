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

            List<ReservacionModel> listaReservaciones = new List<ReservacionModel>();
            bool ocupado = false;
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec ObtenerReservacionesID @param_tipoHabitacion={tipoHabitacion}";
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
                        reservacion.Fecha_Entrada = productoReader["FECHA_ENTRADA"].ToString();
                        reservacion.Fecha_Salida = productoReader["FECHA_SALIDA"].ToString();
                        reservacion.Habitacion.ID_Habitacion = Int32.Parse(productoReader["ID_HABITACION"].ToString());

                        listaReservaciones.Add(reservacion);

                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }

            int habitacionActual = listaReservaciones[0].Habitacion.ID_Habitacion;
            List<int> habitacionesDisponibles = new List<int>();

            foreach(ReservacionModel reservacionModel in listaReservaciones)
            {

                if(reservacionModel.Fecha_Entrada != "")
                {

                    if (habitacionActual != reservacionModel.Habitacion.ID_Habitacion)
                    {
                        int iteraciones = habitacionesDisponibles.Count();

                        for (int i = 0; i < iteraciones; i++)
                        {

                            if (habitacionesDisponibles[i] == reservacionModel.Habitacion.ID_Habitacion)
                            {
                                habitacionesDisponibles.Remove(reservacionModel.Habitacion.ID_Habitacion);
                            }

                        }

                        ocupado = false;
                    }


                    if (!(((DateTime.Parse(fechaEntrada) <= DateTime.Parse(reservacionModel.Fecha_Entrada)) && (DateTime.Parse(fechaSalida) <= DateTime.Parse(reservacionModel.Fecha_Entrada))) || ((DateTime.Parse(fechaEntrada) >= DateTime.Parse(reservacionModel.Fecha_Salida)) && (DateTime.Parse(fechaSalida) >= DateTime.Parse(reservacionModel.Fecha_Salida)))))
                    {
                        ocupado = true;

                    }
                    
                    if (!ocupado)
                    {
                        if (!habitacionesDisponibles.Contains(reservacionModel.Habitacion.ID_Habitacion))
                        {
                            habitacionesDisponibles.Add(reservacionModel.Habitacion.ID_Habitacion);
                        }
                    }
                        

                }
                else
                {
                    return reservacionModel.Habitacion.ID_Habitacion;
                }
                


            }

            if (ocupado)
            {
                int iteraciones = habitacionesDisponibles.Count();

                for (int i = 0; i < iteraciones; i++)
                {

                    if (habitacionesDisponibles[i] == listaReservaciones[listaReservaciones.Count()-1].Habitacion.ID_Habitacion)
                    {
                        habitacionesDisponibles.Remove(listaReservaciones[listaReservaciones.Count() - 1].Habitacion.ID_Habitacion);
                    }

                }

                ocupado = false;
            }

            if (habitacionesDisponibles.Count() > 0)
            {
                return habitacionesDisponibles.Min();
            }
            else
            {
                return 0;
            }

            
            
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

        public int ObtenerDescuentoTemporada()
        {

            int descuentoTemporada = 0;
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec ObtenerDescuentoTemporada";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (productoReader.Read())
                    {
                        descuentoTemporada = Int32.Parse(productoReader["DESCUENTO_TEMPORADA"].ToString());

                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }

            return descuentoTemporada;

        }

        public int ObtenerDescuentoOferta(int ID_Habitacion)
        {

            int descuentoOferta = 0;
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec ObtenerDescuentoOferta @param_ID_Habitacion={ID_Habitacion}";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (productoReader.Read())
                    {
                        descuentoOferta = Int32.Parse(productoReader["DESCUENTO_OFERTA"].ToString());

                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }

            return descuentoOferta;

        }

    }
}
