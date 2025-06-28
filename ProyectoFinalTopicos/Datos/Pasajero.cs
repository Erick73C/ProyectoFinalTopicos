using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalTopicos.Datos
{
    public class Pasajero
    {
        public string NumeroPasajero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Asiento { get; set; }
        public decimal PrecioBase { get; set; }
        public decimal PrecioMaletas { get; set; }
        public decimal PrecioTotal => PrecioBase + PrecioMaletas;
        public string Telefono { get; set; }
        public int NumeroMaletas { get; set; }
        public string NumeroPasaporte { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }
}
