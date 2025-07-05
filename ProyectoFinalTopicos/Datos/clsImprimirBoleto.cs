using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalTopicos.Datos
{
    public class clsImprimirBoleto
    {
        private readonly List<Boleto> boletos;
        private int indiceActual;

        /// <summary>
        /// Contructor de la clase 
        /// </summary>
        /// <param name="boletos"></param>
        public clsImprimirBoleto(List<Boleto> boletos)
        {
            this.boletos = boletos;
            this.indiceActual = 0;
        }


        /// <summary>
        /// Imprime el tiket con el diseño y los datos del pasagero(s)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Imprimir(object sender, PrintPageEventArgs e)
        {
            if (indiceActual >= boletos.Count)
            {
                e.HasMorePages = false;
                return;
            }

            Boleto boleto = boletos[indiceActual];
            Graphics g = e.Graphics;

            // === TICKET DESIGN ===
            Font fuenteTitulo = new Font("Arial", 16, FontStyle.Bold);
            Font fuenteNormal = new Font("Arial", 11);
            Font fuenteCampo = new Font("Arial", 12, FontStyle.Bold);
            Brush negro = Brushes.Black;
            Brush blanco = Brushes.White;
            Brush azul = new SolidBrush(Color.FromArgb(60, 130, 200));
            Brush gris = new SolidBrush(Color.FromArgb(230, 230, 230));

            int x = 50, y = 50, ancho = 700, alto = 300;

            g.FillRectangle(gris, x, y, ancho, alto);
            g.FillRectangle(azul, x, y, ancho, 50);
            g.DrawString("Vuelos Itsur", fuenteTitulo, blanco, x + 10, y + 10);

            y += 60;
            g.DrawString("PASAJERO:", fuenteCampo, negro, x + 10, y);
            g.DrawString($"{boleto.Pasajero.Nombre} {boleto.Pasajero.Apellido}", fuenteNormal, negro, x + 150, y); y += 25;

            g.DrawString("PASAPORTE:", fuenteCampo, negro, x + 10, y);
            g.DrawString(boleto.Pasajero.NumeroPasaporte, fuenteNormal, negro, x + 150, y); y += 25;

            g.DrawString("ORIGEN:", fuenteCampo, negro, x + 10, y);
            g.DrawString(boleto.Vuelo.AeropuertoOrigen, fuenteNormal, negro, x + 150, y);

            g.DrawString("DESTINO:", fuenteCampo, negro, x + 400, y);
            g.DrawString(boleto.Vuelo.AeropuertoDestino, fuenteNormal, negro, x + 500, y); y += 25;

            g.DrawString("SALIDA:", fuenteCampo, negro, x + 10, y);
            g.DrawString(boleto.Vuelo.FechaHoraSalida.ToString("dd/MM/yyyy HH:mm"), fuenteNormal, negro, x + 150, y);

            g.DrawString("LLEGADA:", fuenteCampo, negro, x + 400, y);
            g.DrawString(boleto.Vuelo.FechaHoraLlegada.ToString("dd/MM/yyyy HH:mm"), fuenteNormal, negro, x + 500, y); y += 25;

            g.DrawString("ASIENTO:", fuenteCampo, negro, x + 10, y);
            g.DrawString(boleto.NumeroAsiento, fuenteNormal, negro, x + 150, y);

            g.DrawString("BOLETO:", fuenteCampo, negro, x + 400, y);
            g.DrawString(boleto.NumeroBoleto, fuenteNormal, negro, x + 500, y); y += 30;

            decimal total = boleto.Pasajero.PrecioBase + boleto.Pasajero.PrecioMaletas;
            g.DrawString("TOTAL PAGADO:", fuenteCampo, negro, x + 10, y);
            g.DrawString($"${total:0.00}", fuenteNormal, negro, x + 150, y); y += 25;

            g.DrawString($"(Asiento: ${boleto.Pasajero.PrecioBase:0.00} + Maletas: ${boleto.Pasajero.PrecioMaletas:0.00})", fuenteNormal, negro, x + 10, y);
            g.DrawString("Nota: Debe estar en la puerta de abordaje antes de las 20:05", new Font("Arial", 10, FontStyle.Italic), negro, x + 10, y + 40);

            // IMPORTANTE
            indiceActual++;
            e.HasMorePages = indiceActual < boletos.Count;
        }
    }

}
