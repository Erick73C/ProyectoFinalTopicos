using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalTopicos.Datos
{
    public class Vuelo
    {
        public string NumeroVuelo { get; set; }
        public string AeropuertoOrigen { get; set; }
        public string AeropuertoDestino { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraLlegada { get; set; }
    }
}
