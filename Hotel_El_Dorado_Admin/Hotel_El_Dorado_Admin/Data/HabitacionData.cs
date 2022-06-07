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
        public List<HabitacionModel> obtenerTipoHabitacionStandard()
        {
            List<HabitacionModel> list = new List<HabitacionModel>();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec ObtenerHabitacionesIDTipo @param_ID_TIPO = 1";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    HabitacionModel habitacion;
                    while (productoReader.Read())
                    {
                        habitacion = new HabitacionModel();
                        habitacion.ID_Habitacion = Int32.Parse(productoReader["ID_HABITACION"].ToString());
                        habitacion.Numero_Habitacion = Int32.Parse(productoReader["NUMERO_HABITACION"].ToString());
                        habitacion.Activa = bool.Parse(productoReader["ACTIVA"].ToString());
                        habitacion.Imagen = productoReader["IMAGEN"].ToString();
                        habitacion.Costo = Int32.Parse(productoReader["COSTO"].ToString());
                        habitacion.Tipo_Habitacion = Int32.Parse(productoReader["ID_TIPO"].ToString());
                        habitacion.Descripcion = productoReader["DESCRIPCION"].ToString();

                        list.Add(habitacion);
                    }
                    connection.Close();
                }
            }
            return list;
        }
        public List<HabitacionModel> obtenerTipoHabitacionJunnior()
        {
            List<HabitacionModel> list = new List<HabitacionModel>();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec ObtenerHabitacionesIDTipo @param_ID_TIPO = 2";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    HabitacionModel habitacion;
                    while (productoReader.Read())
                    {
                        habitacion = new HabitacionModel();
                        habitacion.ID_Habitacion = Int32.Parse(productoReader["ID_HABITACION"].ToString());
                        habitacion.Numero_Habitacion = Int32.Parse(productoReader["NUMERO_HABITACION"].ToString());
                        habitacion.Activa = bool.Parse(productoReader["ACTIVA"].ToString());
                        habitacion.Imagen = productoReader["IMAGEN"].ToString();
                        habitacion.Costo = Int32.Parse(productoReader["COSTO"].ToString());
                        habitacion.Tipo_Habitacion = Int32.Parse(productoReader["ID_TIPO"].ToString());
                        habitacion.Descripcion = productoReader["DESCRIPCION"].ToString();

                        list.Add(habitacion);
                    }
                    connection.Close();
                }
            }
            return list;
        }
        public List<HabitacionModel> obtenerTipoHabitacionSuit()
        {
            List<HabitacionModel> list = new List<HabitacionModel>();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec ObtenerHabitacionesIDTipo @param_ID_TIPO = 3";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    HabitacionModel habitacion;
                    while (productoReader.Read())
                    {
                        habitacion = new HabitacionModel();
                        habitacion.ID_Habitacion = Int32.Parse(productoReader["ID_HABITACION"].ToString());
                        habitacion.Numero_Habitacion = Int32.Parse(productoReader["NUMERO_HABITACION"].ToString());
                        habitacion.Activa = bool.Parse(productoReader["ACTIVA"].ToString());
                        habitacion.Imagen = productoReader["IMAGEN"].ToString();
                        habitacion.Costo = Int32.Parse(productoReader["COSTO"].ToString());
                        habitacion.Tipo_Habitacion = Int32.Parse(productoReader["ID_TIPO"].ToString());
                        habitacion.Descripcion = productoReader["DESCRIPCION"].ToString();

                        list.Add(habitacion);
                    }
                    connection.Close();
                }
            }
            return list;
        }
        public List<HabitacionModel> obtenerStandard()
        {
            List<HabitacionModel> list = new List<HabitacionModel>();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec sp_OBTENERTIPOHABITACION @param_ID_TIPO = 1";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    HabitacionModel habitacion;
                    while (productoReader.Read())
                    {
                        habitacion = new HabitacionModel();
                        habitacion.Imagen = productoReader["IMAGEN"].ToString();
                        habitacion.Costo = Int32.Parse(productoReader["COSTO"].ToString());
                        habitacion.Tipo_Habitacion = Int32.Parse(productoReader["ID_TIPO"].ToString());
                        habitacion.Descripcion = productoReader["DESCRIPCION"].ToString();

                        list.Add(habitacion);
                    }
                    connection.Close();
                }
            }
            return list;
        }

        public List<HabitacionModel> obtenerJunnior()
        {
            List<HabitacionModel> list = new List<HabitacionModel>();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec sp_OBTENERTIPOHABITACION @param_ID_TIPO = 2";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    HabitacionModel habitacion;
                    while (productoReader.Read())
                    {
                        habitacion = new HabitacionModel();
                        habitacion.Imagen = productoReader["IMAGEN"].ToString();
                        habitacion.Costo = Int32.Parse(productoReader["COSTO"].ToString());
                        habitacion.Tipo_Habitacion = Int32.Parse(productoReader["ID_TIPO"].ToString());
                        habitacion.Descripcion = productoReader["DESCRIPCION"].ToString();

                        list.Add(habitacion);
                    }
                    connection.Close();
                }
            }
            return list;
        }

        public List<HabitacionModel> obtenerSuit()
        {
            List<HabitacionModel> list = new List<HabitacionModel>();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec sp_OBTENERTIPOHABITACION @param_ID_TIPO = 3";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    HabitacionModel habitacion;
                    while (productoReader.Read())
                    {
                        habitacion = new HabitacionModel();
                        habitacion.Imagen = productoReader["IMAGEN"].ToString();
                        habitacion.Costo = Int32.Parse(productoReader["COSTO"].ToString());
                        habitacion.Tipo_Habitacion = Int32.Parse(productoReader["ID_TIPO"].ToString());
                        habitacion.Descripcion = productoReader["DESCRIPCION"].ToString();

                        list.Add(habitacion);
                    }
                    connection.Close();
                }
            }
            return list;
        }

        public bool activa(int tipo)
        {

            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec sp_ACTIVA @param_ID = '{tipo}'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    connection.Close();
                }
            }
            return true;
        }
    }
}
