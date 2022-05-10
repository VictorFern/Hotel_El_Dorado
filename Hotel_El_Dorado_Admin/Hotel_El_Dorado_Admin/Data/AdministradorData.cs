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
    }
}
