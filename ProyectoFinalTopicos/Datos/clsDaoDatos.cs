using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoFinalTopicos.Datos
{
    /// <summary>
    /// Se encarga de manejar la conexión a la base de datos y realizar operaciones CRUD sobre los boletos.
    /// </summary>
    public class clsDaoDatos
    {
        private readonly string conexion =
           //Poner los datos de la conexión a la base de datos
           //IMPORTANTE: Cambiar la cadena de conexión según tu configuración de base de datos
           //La base de datos se llama "DBAeropuerto" 
           "server = localhost;  database = dbaeropuerto; uid = root; pwd = ;";

        /// <summary>
        /// Inserta un nuevo boleto en la base de datos asociado a un pasajero específico.
        /// </summary>
        /// <param name="boleto">Objeto Boleto que contiene la información del boleto a insertar.</param>
        /// <param name="idPasajero">ID del pasajero al que se asociará el boleto.</param>
        /// <returns>
        ///   <c>true</c> si la inserción fue exitosa; 
        ///   de lo contrario, lanza una excepción ApplicationException con el error ocurrido.
        /// </returns>
        public bool InsertarBoleto(Boleto boleto, int idPasajero)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "INSERT INTO Boletos (NumeroBoleto, NumeroPasajero, NumeroVuelo, NumeroAsiento, TieneMaleta, CheckInRealizado, HaAbordado) " +
                               "VALUES (@NumeroBoleto, @NumeroPasajero, @NumeroVuelo, @NumeroAsiento, @TieneMaleta, @CheckInRealizado, @HaAbordado)";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NumeroBoleto", boleto.NumeroBoleto);
                cmd.Parameters.AddWithValue("@NumeroPasajero", idPasajero);
                cmd.Parameters.AddWithValue("@NumeroVuelo", boleto.Vuelo.NumeroVuelo);
                cmd.Parameters.AddWithValue("@NumeroAsiento", boleto.NumeroAsiento);
                cmd.Parameters.AddWithValue("@TieneMaleta", boleto.TieneMaleta);
                cmd.Parameters.AddWithValue("@CheckInRealizado", boleto.CheckInRealizado);
                cmd.Parameters.AddWithValue("@HaAbordado", boleto.HaAbordado);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al insertar el boleto.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        /// <summary>
        /// Obtiene todos los boletos asociados a un número de vuelo específico, incluyendo la información de los pasajeros.
        /// </summary>
        /// <param name="numeroVuelo">Número de vuelo para filtrar la búsqueda de boletos.</param>
        /// <returns>
        /// Una lista de objetos <see cref="Boleto"/> que contiene todos los boletos encontrados para el vuelo especificado,
        /// cada uno con su información completa y los datos del pasajero asociado.
        /// </returns>
        public List<Boleto> ObtenerBoletosPorVuelo(string numeroVuelo)
        {
            List<Boleto> boletos = new List<Boleto>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "SELECT b.NumeroBoleto, b.NumeroAsiento, b.TieneMaleta, b.CheckInRealizado, b.HaAbordado, " +
                               "p.Nombre, p.Apellido, p.Asiento, p.NumeroPasaporte, p.Origen, p.Destino, p.PrecioBase, p.PrecioMaletas " +
                               "FROM Boletos b " +
                               "JOIN Pasajeros p ON b.NumeroPasajero = p.NumeroPasajero " +
                               "WHERE b.NumeroVuelo = @NumeroVuelo";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NumeroVuelo", numeroVuelo);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var pasajero = new Pasajero
                    {
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Asiento = reader["Asiento"].ToString(),
                        NumeroPasaporte = reader["NumeroPasaporte"].ToString(),
                        Origen = reader["Origen"].ToString(),
                        Destino = reader["Destino"].ToString(),
                        PrecioBase = Convert.ToDecimal(reader["PrecioBase"]),
                        PrecioMaletas = Convert.ToDecimal(reader["PrecioMaletas"])
                    };

                    var boleto = new Boleto
                    {
                        NumeroBoleto = reader["NumeroBoleto"].ToString(),
                        NumeroAsiento = reader["NumeroAsiento"].ToString(),
                        TieneMaleta = Convert.ToBoolean(reader["TieneMaleta"]),
                        CheckInRealizado = Convert.ToBoolean(reader["CheckInRealizado"]),
                        HaAbordado = Convert.ToBoolean(reader["HaAbordado"]),
                        Pasajero = pasajero
                    };

                    boletos.Add(boleto);
                }

                return boletos;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener los boletos del vuelo.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        /// <summary>
        /// Obtiene una lista de los números de asiento que ya están ocupados en un vuelo específico.
        /// </summary>
        /// <param name="numeroVuelo">Número de vuelo para el cual se consultarán los asientos ocupados.</param>
        /// <returns>
        /// Lista de strings que contiene los números de asiento ocupados en el vuelo especificado.
        /// La lista estará vacía si no hay asientos ocupados o si el vuelo no existe.
        /// </returns>
        public List<string> ObtenerAsientosOcupados(string numeroVuelo)
        {
            List<string> asientos = new List<string>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "SELECT NumeroAsiento FROM Boletos WHERE NumeroVuelo = @NumeroVuelo";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NumeroVuelo", numeroVuelo);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    asientos.Add(reader["NumeroAsiento"].ToString());
                }

                return asientos;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener los asientos ocupados.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        //Se actualizo el metodo de insertar pasagero para saber si es menor o no. 

        /// <summary>
        /// Inserta un nuevo pasajero en la base de datos y retorna el ID generado.
        /// </summary>
        /// <param name="pasajero">Objeto <see cref="Pasajero"/> que contiene la información del pasajero a insertar.</param>
        /// <param name="idInsertado">Parámetro de salida que contendrá el ID autogenerado del pasajero insertado.
        /// Será -1 si ocurre un error durante la inserción.</param>
        /// <returns>
        /// <c>true</c> si la inserción fue exitosa; 
        /// de lo contrario, lanza una <see cref="ApplicationException"/> con el error ocurrido.
        /// </returns>
        public bool InsertarPasajero(Pasajero pasajero, out int idInsertado)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            idInsertado = -1;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                string query = "INSERT INTO Pasajeros (Nombre, Apellido, Telefono, Asiento, PrecioBase, NumeroMaletas, NumeroPasaporte, PrecioMaletas, Origen, Destino, EsMenor, Descuento) " +
                               "VALUES (@Nombre, @Apellido, @Telefono, @Asiento, @PrecioBase, @NumeroMaletas, @NumeroPasaporte, @PrecioMaletas, @Origen, @Destino, @EsMenor, @Descuento); " +
                               "SELECT LAST_INSERT_ID();";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", pasajero.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", pasajero.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", pasajero.Telefono);
                cmd.Parameters.AddWithValue("@Asiento", pasajero.Asiento);
                cmd.Parameters.AddWithValue("@PrecioBase", pasajero.PrecioBase);
                cmd.Parameters.AddWithValue("@NumeroMaletas", pasajero.NumeroMaletas);
                cmd.Parameters.AddWithValue("@NumeroPasaporte", pasajero.NumeroPasaporte);
                cmd.Parameters.AddWithValue("@PrecioMaletas", pasajero.PrecioMaletas);
                cmd.Parameters.AddWithValue("@Origen", pasajero.Origen);
                cmd.Parameters.AddWithValue("@Destino", pasajero.Destino);
                cmd.Parameters.AddWithValue("@EsMenor", pasajero.EsMenor);
                cmd.Parameters.AddWithValue("@Descuento", pasajero.Descuento);

                idInsertado = Convert.ToInt32(cmd.ExecuteScalar());
                return true;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error al insertar el pasajero en la base de datos.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        /// <summary>
        /// Inserta un nuevo vuelo en la base de datos solo si no existe previamente un vuelo con el mismo número.
        /// </summary>
        /// <param name="vuelo">Objeto <see cref="Vuelo"/> que contiene la información del vuelo a insertar.</param>
        /// <returns>
        /// <c>true</c> si el vuelo fue insertado correctamente o si ya existía en la base de datos;
        /// En caso de error, lanza una <see cref="ApplicationException"/>.
        /// </returns>
        public bool InsertarVueloSiNoExiste(Vuelo vuelo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string verificar = "SELECT COUNT(*) FROM Vuelos WHERE NumeroVuelo = @NumeroVuelo";
                cmd = new MySqlCommand(verificar, conn);
                cmd.Parameters.AddWithValue("@NumeroVuelo", vuelo.NumeroVuelo);
                int existe = Convert.ToInt32(cmd.ExecuteScalar());

                if (existe > 0)
                    return true;

                cmd.Dispose();

                string insertar = "INSERT INTO Vuelos (NumeroVuelo, AeropuertoOrigen, AeropuertoDestino, FechaHoraSalida, FechaHoraLlegada) " +
                                  "VALUES (@NumeroVuelo, @AeropuertoOrigen, @AeropuertoDestino, @FechaHoraSalida, @FechaHoraLlegada)";
                cmd = new MySqlCommand(insertar, conn);
                cmd.Parameters.AddWithValue("@NumeroVuelo", vuelo.NumeroVuelo);
                cmd.Parameters.AddWithValue("@AeropuertoOrigen", vuelo.AeropuertoOrigen);
                cmd.Parameters.AddWithValue("@AeropuertoDestino", vuelo.AeropuertoDestino);
                cmd.Parameters.AddWithValue("@FechaHoraSalida", vuelo.FechaHoraSalida);
                cmd.Parameters.AddWithValue("@FechaHoraLlegada", vuelo.FechaHoraLlegada);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al insertar/verificar el vuelo.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        /// <summary>
        /// Inserta un nuevo vuelo en la base de datos solo si no existe previamente un vuelo con el mismo número.
        /// </summary>
        /// <param name="vuelo">Objeto <see cref="Vuelo"/> que contiene la información del vuelo a insertar.</param>
        /// <returns>
        /// <c>true</c> si el vuelo fue insertado correctamente o si ya existía en la base de datos;
        /// En caso de error, lanza una <see cref="ApplicationException"/>.
        /// </returns>
        public Vuelo ObtenerDatosVueloPorDestino(string destino)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT * FROM Vuelos WHERE AeropuertoDestino = @Destino LIMIT 1;";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Destino", destino);

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Vuelo vuelo = new Vuelo
                    {
                        NumeroVuelo = reader["NumeroVuelo"].ToString(),
                        AeropuertoOrigen = reader["AeropuertoOrigen"].ToString(),
                        AeropuertoDestino = reader["AeropuertoDestino"].ToString(),
                        FechaHoraSalida = Convert.ToDateTime(reader["FechaHoraSalida"]),
                        FechaHoraLlegada = Convert.ToDateTime(reader["FechaHoraLlegada"]),
                        PrecioBase = Convert.ToDecimal(reader["PrecioBase"])
                    };

                    return vuelo;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener los datos del vuelo.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        /// <summary>
        /// Obtiene el número de vuelo asociado a un destino específico.
        /// </summary>
        /// <param name="destino">Nombre del aeropuerto destino a buscar.</param>
        /// <returns>
        /// El número de vuelo como cadena si se encuentra un vuelo al destino especificado;
        /// de lo contrario, retorna una cadena vacía.
        /// </returns>
        public string ObtenerNumeroVueloPorDestino(string destino)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT NumeroVuelo FROM Vuelos WHERE AeropuertoDestino = @Destino LIMIT 1";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Destino", destino);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return reader["NumeroVuelo"].ToString();
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener el número de vuelo por destino.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        /// <summary>
        /// Obtiene el precio base de un vuelo según el destino especificado.
        /// </summary>
        /// <param name="destino">Nombre del aeropuerto destino para buscar el precio.</param>
        /// <returns>
        /// El precio base como <see cref="decimal"/> si se encuentra un vuelo al destino;
        /// de lo contrario, retorna 0.
        /// </returns>
        public decimal ObtenerPrecioBasePorDestino(string destino)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT PrecioBase FROM Vuelos WHERE AeropuertoDestino LIKE CONCAT('%', @Destino, '%') LIMIT 1";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Destino", destino);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return Convert.ToDecimal(reader["PrecioBase"]);
                }

                return 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener el precio base del vuelo.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

    }
}
