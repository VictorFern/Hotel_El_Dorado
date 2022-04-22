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
    public class PublicidadData
    {
        public IConfiguration Configuration { get; }

        public PublicidadData(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor
        public List<PublicidadModel> ObtenerPublicidad()
        {
            List<PublicidadModel> listaPublicidad = new List<PublicidadModel>();
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec ObtenerPublicidad";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (productoReader.Read())
                    {
                        PublicidadModel publicidad = new PublicidadModel();
                        publicidad.ID_Publicidad = Int32.Parse(productoReader["ID_Publicidad"].ToString());
                        publicidad.Link = productoReader["Link"].ToString();
                        publicidad.Imagen = productoReader["Imagen"].ToString();

                        listaPublicidad.Add(publicidad);
                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }
            return listaPublicidad;
        }

        public PublicidadModel ObtenerPublicidadID(int ID)
        {
            PublicidadModel publicidad = new PublicidadModel();
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec ObtenerPublicidadID @param_ID_Publicidad={ID}";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (productoReader.Read())
                    {
                        publicidad.ID_Publicidad = Int32.Parse(productoReader["ID_Publicidad"].ToString());
                        publicidad.Link = productoReader["Link"].ToString();
                        publicidad.Imagen = productoReader["Imagen"].ToString();
                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }
            return publicidad;
        }

        public IActionResult CrearPublicidad(PublicidadModel publicidadModel)
        {

            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec CrearPublicidad @param_ID_Publicidad={publicidadModel.ID_Publicidad}, @param_Link='{publicidadModel.Link}', @param_Imagen='{publicidadModel.Imagen}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
                return null;
            }
        }

        public void EliminarPublicidad(int ID)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec EliminarPublicidad @param_ID_Publicidad={ID}";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }
        }

        public IActionResult ActualizarPublicidad(PublicidadModel publicidadModel)
        {

            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec ActualizarPublicidad @param_ID_Publicidad={publicidadModel.ID_Publicidad}, @param_Link='{publicidadModel.Link}', @param_Imagen='{publicidadModel.Imagen}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
                return null;
            }
        }
    }

}
