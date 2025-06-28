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
           "server = localhost;  database = DBAeropuerto; uid = root; pwd = ;";

        public void GuardarBoleto(Boleto boleto)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

        }

        public List<Boleto> ObtenerBoletosPorVuelo(string numeroVuelo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            // Implementar lógica para recuperar boletos
            return new List<Boleto>();
        }
    }
}
