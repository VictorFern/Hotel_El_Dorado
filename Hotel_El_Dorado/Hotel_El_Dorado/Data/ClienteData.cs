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
    public class ClienteData
    {
        public IConfiguration Configuration { get; }

        public ClienteData(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor

        public ClienteModel BuscarClienteCedula(int cedula)
        {
            ClienteModel cliente = new ClienteModel();
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec BuscarClienteCedula @param_Cedula={cedula}";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (productoReader.Read())
                    {
                        cliente.Cedula = Int32.Parse(productoReader["CEDULA"].ToString());
                        cliente.Nombre = productoReader["NOMBRE_CLIENTE"].ToString();
                        cliente.Apellidos = productoReader["APELLIDOS_CLIENTE"].ToString();
                        cliente.Email = productoReader["EMAIL"].ToString();

                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }

            return cliente;

        }

    }
}
