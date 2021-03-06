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
                        habitacion.Nombre_Tipo_Habitacion = productoReader["TIPO"].ToString();
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


        public List<TemporadaModel> ObtenerTemporada()
        {
            List<TemporadaModel> temp = new List<TemporadaModel>();
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec sp_OBTENERTEMPORADA";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader temporadaReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (temporadaReader.Read())
                    {
                        TemporadaModel var = new TemporadaModel();
                        var.id = Int32.Parse(temporadaReader["ID_TEMPORADA"].ToString());
                        var.fechaInicio =  temporadaReader["FECHA_INICIO"].ToString();
                        var.fechaFin = temporadaReader["FECHA_FIN"].ToString();
                        var.descuento = float.Parse(temporadaReader["COSTO"].ToString());

                        temp.Add(var);
                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }
            return temp;
        }

        public TemporadaModel ObtenerTemporadaID()
        {
            TemporadaModel temp = new TemporadaModel();
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec sp_OBTENERTEMPORADA_ID";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader temporadaReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (temporadaReader.Read())
                    {
                        temp.id = Int32.Parse(temporadaReader["ID_TEMPORADA"].ToString());
                        temp.fechaInicio = temporadaReader["FECHA_INICIO"].ToString();
                        temp.fechaFin = temporadaReader["FECHA_FIN"].ToString();
                        temp.descuento = float.Parse(temporadaReader["COSTO"].ToString());

                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }
            return temp;
        }


        public bool guardarTemporada(TemporadaModel temporada)
        {
            Console.WriteLine("DENMTRO DE GUARDAR");
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec sp_INSERTARTEMPORADA @param_TIPO='Alta', @param_FECHA_I='{temporada.fechaInicio}', @param_FECHA_F='{temporada.fechaFin}',  @param_COSTO='{temporada.descuento}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }
            Console.WriteLine("SALIENDO DE GUARDAR");
            return true;
        }

        public bool editarTemporada(TemporadaModel temporada)
        {
            Console.WriteLine("DENMTRO DE ACTUALIZAR" + temporada.id);
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec sp_ACTUALIZARTEMPORADA @param_ID='{temporada.id}', @param_FECHA_I='{temporada.fechaInicio}', @param_FECHA_F='{temporada.fechaFin}',  @param_COSTO='{temporada.descuento}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }
            Console.WriteLine("SALIENDO DE ACTUALIZAR");
            return true;
        }

        public bool eliminarTemporada(TemporadaModel temporada)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec sp_ELIMINARTEMPORADA  @param_ID='{temporada.id}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }
            Console.WriteLine("SALIENDO DE ELIMINAR");
            return true;
        }


        public bool guardarOferta(OfertaModel temp)
        {
            Console.WriteLine("DENMTRO DE GUARDAR OFERTA");
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec CrearOferta @param_ID_Oferta={0}, @param_Oferta='{temp.Oferta}', @param_Imagen='{temp.Imagen}',  @param_Fecha_Inicio='{temp.Fecha_Inicio}',  @param_Fecha_Fin='{temp.Fecha_Fin}', @param_Tipo_Habitacion='{temp.Tipo_Habitacion}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }
            Console.WriteLine("SALIENDO DE GUARDAR");
            return true;
        }

        public List<OfertaModel> ObtenerOfertas()
        {
            List<OfertaModel> temp = new List<OfertaModel>();
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
                    SqlDataReader OfertaReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (OfertaReader.Read())
                    {
                        OfertaModel var = new OfertaModel();
                        var.ID_Oferta = Int32.Parse(OfertaReader["ID_OFERTA"].ToString());
                        var.Oferta = Int32.Parse(OfertaReader["OFERTA"].ToString());
                        var.Imagen = OfertaReader["IMAGEN"].ToString();
                        var.Fecha_Inicio = OfertaReader["FECHA_INICIO"].ToString();
                        var.Fecha_Fin = OfertaReader["FECHA_FIN"].ToString();
                        var.Tipo_Habitacion = OfertaReader["TIPO_HABITACION"].ToString();
                        temp.Add(var);
                    } // while
                      //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }
            return temp;
        }

        public bool eliminarOferta(OfertaModel temp)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec EliminarOferta  @param_ID_Oferta='{temp.ID_Oferta}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }
            Console.WriteLine("SALIENDO DE ELIMINAR");
            return true;
        }

        public bool editarOferta(OfertaModel temp)
        {
            Console.WriteLine("DENMTRO DE ACTUALIZAR" + temp.ID_Oferta);
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec ActualizarOferta @param_ID_Oferta='{temp.ID_Oferta}', @param_Oferta='{temp.Oferta}', @param_Imagen='{temp.Imagen}',  @param_Fecha_Inicio='{temp.Fecha_Inicio}', @param_Fecha_Fin='{temp.Fecha_Fin}', @param_Tipo_Habitacion='{temp.Tipo}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }
            Console.WriteLine("SALIENDO DE ACTUALIZAR");
            return true;
        }

        public List<ReservacionModel> verListadoReservaciones()
        {
            List<ReservacionModel> temp = new List<ReservacionModel>();
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec sp_LISTA_RESERVACION";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader listaReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (listaReader.Read())
                    {
                        ClienteModel clienteModel = new ClienteModel();

                        clienteModel.Nombre = listaReader["NOMBRE_CLIENTE"].ToString();
                        clienteModel.Apellidos = listaReader["APELLIDOS_CLIENTE"].ToString();
                        clienteModel.Email = listaReader["EMAIL"].ToString();
                        clienteModel.Tarjeta = listaReader["TARJETA"].ToString();
                        HabitacionModel habitacionModel = new HabitacionModel();
                        habitacionModel.Tipo_HabitacionT = listaReader["TIPO"].ToString();
                        ReservacionModel reservacionModel = new ReservacionModel();
                        reservacionModel.Fecha_Reservacion = listaReader["FECHA_RESERVACION"].ToString();
                        reservacionModel.ID_Reservacion = Int32.Parse(listaReader["ID_RESERVACION"].ToString());
                        reservacionModel.Fecha_Entrada = listaReader["FECHA_ENTRADA"].ToString();
                        reservacionModel.Fecha_Salida = listaReader["FECHA_SALIDA"].ToString();
                        reservacionModel.Habitacion = habitacionModel;
                        reservacionModel.Cliente = clienteModel;

                        temp.Add(reservacionModel);

                    }// while
                     //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }
            return temp;
        }

        public List<ReservacionModel> verListadoReservacionId(int id)
        {
            List<ReservacionModel> temp = new List<ReservacionModel>();
            //se crea la conexion
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //se escribe la consulta
                string sqlQuery = $"exec sp_LISTA_RESERVACIONID @param_ID='{id}'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Se abre y se ejecuta la consulta
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader listaReader = command.ExecuteReader();
                    //Se hace lectura de lo que nos retorno la consulta
                    while (listaReader.Read())
                    {
                        ClienteModel clienteModel = new ClienteModel();

                        clienteModel.Nombre = listaReader["NOMBRE_CLIENTE"].ToString();
                        clienteModel.Apellidos = listaReader["APELLIDOS_CLIENTE"].ToString();
                        clienteModel.Email = listaReader["EMAIL"].ToString();
                        clienteModel.Tarjeta = listaReader["TARJETA"].ToString();
                        HabitacionModel habitacionModel = new HabitacionModel();
                        habitacionModel.Tipo_HabitacionT = listaReader["TIPO"].ToString();
                        ReservacionModel reservacionModel = new ReservacionModel();
                        reservacionModel.Fecha_Reservacion = listaReader["FECHA_RESERVACION"].ToString();
                        reservacionModel.ID_Reservacion = Int32.Parse(listaReader["ID_RESERVACION"].ToString());
                        reservacionModel.Fecha_Entrada = listaReader["FECHA_ENTRADA"].ToString();
                        reservacionModel.Fecha_Salida = listaReader["FECHA_SALIDA"].ToString();
                        reservacionModel.Habitacion = habitacionModel;
                        reservacionModel.Cliente = clienteModel;

                        temp.Add(reservacionModel);

                    }// while
                     //Se cierra la conexion a la base de datos
                    connection.Close();
                }
            }
            return temp;
        }

       public bool eliminarReporteReservacionId(int id)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec sp_ELIMIANR_REPORTE_ID  @param_ID='{id}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }
            Console.WriteLine("SALIENDO DE ELIMINAR");
            return true;
        }

        public HotelModel ObtenerSobreNosotros()
        {
            HotelModel hotel = new HotelModel();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec ObtenerSobreNosotros";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    while (productoReader.Read())
                    {
                        hotel.SobreNosotros = productoReader["INFO_SOBRENOSOTROS"].ToString();
                    }
                    connection.Close();
                }
            }
            Console.WriteLine(hotel.SobreNosotros+ " dkshvbvdsckcsdncdsc");
            return hotel;
        }


        public void actualizarSN(HotelModel hotel)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec InsertarSobreNosotros @data='{hotel.SobreNosotros}'";
                Console.WriteLine("consulta -> "+ consultaSQL);
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }
        }

        public HotelModel ObtenerComoLlegar()
        {
            HotelModel hotel = new HotelModel();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec sp_GetInfoComoLlegar";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    while (productoReader.Read())
                    {
                        hotel.ComoLlegar = productoReader["INFO_COMO_LLEGAR"].ToString();
                    }
                    connection.Close();
                }
            }
           
            return hotel;
        }

        public void actualizarComoLlegar(HotelModel hotel)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec sp_UPDATECOMOLLEGAR @param_COMOLLEGAR='{hotel.ComoLlegar}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }
        }

        public HotelModel ObtenerHome()
        {
            HotelModel hotel = new HotelModel();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec sp_ObtenerHome";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    while (productoReader.Read())
                    {
                        hotel.InfoHotel = productoReader["INFO_HOME"].ToString();
                        hotel.imagen = productoReader["IMAGEN"].ToString();
                    }
                    connection.Close();
                }
            }

            return hotel;
        }

        public void actualizarHome(HotelModel hotel)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            Console.WriteLine(hotel.InfoHotel);
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec sp_UPDATEHOME @param_INFO='{hotel.InfoHotel}', @param_IMAGEN = '{hotel.imagen}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }
        }

        public List<FacilidadModel> ObtenerFacilidad()
        {
            
            List<FacilidadModel> temp = new List<FacilidadModel>();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec sp_GETFACILIDADES";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    while (productoReader.Read())
                    {
                        FacilidadModel facilidad = new FacilidadModel();
                        facilidad.id = Int32.Parse(productoReader["ID_FACILIDAD"].ToString());
                        facilidad.Nombre = productoReader["NOMBRE_FACILIDAD"].ToString();
                        facilidad.Descripcion = productoReader["DESCRIPCION"].ToString();

                        temp.Add(facilidad);
                    }
                    connection.Close();
                }
            }

            return temp;
        }

        public FacilidadModel GetFacilidad(int id)
        {
            FacilidadModel facilidad = new FacilidadModel();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec sp_GETFACILIDADESID @param_ID='{id}'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    while (productoReader.Read())
                    {
                        
                        facilidad.id = Int32.Parse(productoReader["ID_FACILIDAD"].ToString());
                        facilidad.Nombre = productoReader["NOMBRE_FACILIDAD"].ToString();
                        facilidad.Descripcion = productoReader["DESCRIPCION"].ToString();
                    }
                    connection.Close();
                }
            }

            return facilidad;
        }

        public void actualizarFacilidad(FacilidadModel facilidad)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec sp_UPDATEFACILIDAD @param_NOMBRE='{facilidad.Nombre}', @param_DESCRIPCION='{facilidad.Descripcion}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }
        }

        public List<PublicidadModel> ObtenerPublicidad()
        {
            List<PublicidadModel> temp = new List<PublicidadModel>();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec ObtenerPublicidad";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    while (productoReader.Read())
                    {
                        PublicidadModel publicidad = new PublicidadModel();
                        publicidad.id = Int32.Parse(productoReader["ID_PUBLICIDAD"].ToString());
                        publicidad.link = productoReader["LINK"].ToString();
                        publicidad.Imagen = productoReader["IMAGEN"].ToString();

                        temp.Add(publicidad);
                    }
                    connection.Close();
                }
            }

            return temp;
        }

        public bool guardarPublicidad(PublicidadModel temp)
        {
            
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec CrearPublicidad @param_Link='{temp.link}', @param_Imagen='{temp.Imagen}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }

            return true;
        }

        public bool eliminarPublicidad(PublicidadModel temp)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec EliminarPublicidad  @param_ID_Publicidad='{temp.id}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }
            Console.WriteLine("SALIENDO DE ELIMINAR");
            return true;
        }

        public PublicidadModel ObtenerPublicidadId(PublicidadModel publicidad)
        {
            PublicidadModel publicidadModel = new PublicidadModel();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec ObtenerPublicidadID @param_ID_Publicidad='{publicidad.id}'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    while (productoReader.Read())
                    {

                        publicidadModel.id = Int32.Parse(productoReader["ID_PUBLICIDAD"].ToString());
                        publicidadModel.link = productoReader["LINK"].ToString();
                        publicidadModel.Imagen = productoReader["IMAGEN"].ToString();
                    }
                    connection.Close();
                }
            }

            return publicidadModel;
        }

        public bool ActualizarPublicidad(PublicidadModel temp)
        {

            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consultaSQL = $"exec ActualizarPublicidad @param_ID_Publicidad='{temp.id}', @param_Link='{temp.link}', @param_Imagen='{temp.Imagen}'";
                using (SqlCommand command = new SqlCommand(consultaSQL, conexion))
                {
                    command.CommandType = CommandType.Text;
                    conexion.Open();
                    command.ExecuteReader();
                    conexion.Close();
                }
            }

            return true;
        }

    }
}
