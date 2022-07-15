using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Hotel_El_Dorado.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado.Data
{
    public class OfertaData
    {
        public IConfiguration Configuration { get; }

        public OfertaData(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor

        public IActionResult CrearOferta(OfertaModel ofertaModel)
        {

            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec CrearOferta @param_ID_Oferta={ofertaModel.ID_Oferta}, @param_Oferta={ofertaModel.Oferta}, @param_Imagen='{ofertaModel.Imagen}', @param_Fecha_Inicio='{ofertaModel.Fecha_Inicio}', @param_Fecha_Fin='{ofertaModel.Fecha_Fin}'";
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

        public List<OfertaModel> ObtenerOferta()
        {
            List<OfertaModel> listaOferta = new List<OfertaModel>();
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec ObtenerOferta";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader ofertaReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (ofertaReader.Read())
                    {
                        OfertaModel oferta = new OfertaModel();
                        oferta.ID_Oferta = Int32.Parse(ofertaReader["ID_Oferta"].ToString());
                        oferta.Oferta = Int32.Parse(ofertaReader["Oferta"].ToString());
                        oferta.Imagen = ofertaReader["Imagen"].ToString();
                        oferta.Fecha_Inicio = ofertaReader["Fecha_Inicio"].ToString();
                        oferta.Fecha_Fin = ofertaReader["Fecha_Fin"].ToString();
                        oferta.tipo = ofertaReader["TIPO"].ToString();
                        listaOferta.Add(oferta);
                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }
            return listaOferta;
        }

        public IActionResult EliminarOferta(OfertaModel ofertaModel)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec EliminarOferta @param_ID_Oferta={ofertaModel.ID_Oferta}";
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

        public IActionResult ActualizarOferta(OfertaModel ofertaModel)
        {

            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec ActualizarOferta @param_ID_Oferta={ofertaModel.ID_Oferta}, @param_Oferta={ofertaModel.Oferta}, @param_Imagen='{ofertaModel.Imagen}', @param_Fecha_Inicio='{ofertaModel.Fecha_Inicio}', @param_Fecha_Fin='{ofertaModel.Fecha_Fin}'";
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
