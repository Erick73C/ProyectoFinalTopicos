using ReservaVuelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTopicos
{
    public partial class frmEscoger : Form
    {
        public frmEscoger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abre un formulario de reserva de vuelo con el destino especificado.
        /// </summary>
        /// <param name="destino">El destino del vuelo que se utilizará para inicializar el formulario de reserva.</param>
        private void AbrirFormularioReserva(string destino)
        {
            frmReservaVuelo reserva = new frmReservaVuelo(destino);
            reserva.ShowDialog();
        }

        private void btnCancun_Click(object sender, EventArgs e)
        {
            AbrirFormularioReserva("Cancún (CUN)");

        }

        private void btnLosCabos_Click(object sender, EventArgs e)
        {
            AbrirFormularioReserva("Los Cabos (SJD)");
        }

        private void btnPuertoVallasta_Click(object sender, EventArgs e)
        {
            AbrirFormularioReserva("Puerto Vallarta (PVR)");
        }

        private void btnHermosillo_Click(object sender, EventArgs e)
        {
            AbrirFormularioReserva("Hermosillo (HMO)");
        }

        private void btnBogota_Click(object sender, EventArgs e)
        {
            AbrirFormularioReserva("Bogotá (BOG)");
        }

        private void btnwashington_Click(object sender, EventArgs e)
        {
            AbrirFormularioReserva("Washington (DCA)");
        }

        private void btnNuevaYork_Click(object sender, EventArgs e)
        {
            AbrirFormularioReserva("Nueva York (JFK)");
        }

        private void btnSanFrancisco_Click(object sender, EventArgs e)
        {
            AbrirFormularioReserva("San Francisco (SFO)");
        }
    }
}
