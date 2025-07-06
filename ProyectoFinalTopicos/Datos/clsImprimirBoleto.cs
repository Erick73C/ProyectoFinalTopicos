using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalTopicos.Datos
{
    /// <summary>
    /// Se encarga de imprimir los boletos de los pasajeros en formato de ticket.
    /// </summary>
    public class clsImprimirBoleto
    {
        private readonly List<Boleto> boletos;
        private int indiceActual;
        private Bitmap ticketBitmap;
        private clsImprimirBoleto impresor;

        public clsImprimirBoleto(List<Boleto> boletos)
        {
            this.boletos = boletos;
            this.indiceActual = 0;
        }

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

            int x = 50, y = 50, ancho = 700, alto = 400;

            g.FillRectangle(gris, x, y, ancho, alto);
            g.FillRectangle(azul, x, y, ancho, 50);
            g.DrawString("Vuelos Itsur", fuenteTitulo, blanco, x + 10, y + 10);

            y += 60;
            g.DrawString("PASAJERO:", fuenteCampo, negro, x + 10, y);
            g.DrawString($"{boleto.Pasajero.Nombre} {boleto.Pasajero.Apellido}", fuenteNormal, negro, x + 150, y);
            if (boleto.Pasajero.EsMenor)
            {
                g.DrawString(" (MENOR)", new Font("Arial", 11, FontStyle.Italic), Brushes.Red, x + 370, y);
            }
            y += 25;

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

            g.DrawString("PRECIO VUELO:", fuenteCampo, negro, x + 10, y);
            g.DrawString($"${boleto.Vuelo.PrecioBase}", fuenteNormal, negro, x + 150, y); y += 25;

            decimal total = boleto.Pasajero.PrecioBase + boleto.Pasajero.PrecioMaletas + boleto.Vuelo.PrecioBase - boleto.Pasajero.Descuento;

            g.DrawString("TOTAL PAGADO:", fuenteCampo, negro, x + 10, y);
            g.DrawString($"${total:0.00}", fuenteNormal, negro, x + 150, y); y += 25;

            g.DrawString($"(Asiento: ${boleto.Pasajero.PrecioBase} + Maletas: ${boleto.Pasajero.PrecioMaletas:0.00})", fuenteNormal, negro, x + 10, y);
            if (boleto.Pasajero.Descuento > 0)
            {
                y += 25;
                g.DrawString($"Descuento menor aplicado: -${boleto.Pasajero.Descuento:0.00}", new Font("Arial", 10, FontStyle.Bold), Brushes.DarkGreen, x + 10, y);
            }

            g.DrawString("Nota: Debe estar en la puerta de abordaje una hora antes del vuelo ", new Font("Arial", 10, FontStyle.Italic), negro, x + 10, y + 40);

            indiceActual++;
            e.HasMorePages = indiceActual < boletos.Count;
        }

    }
}
