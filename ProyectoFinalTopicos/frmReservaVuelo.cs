using ProyectoFinalTopicos;
using ProyectoFinalTopicos.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaVuelo
{
    public partial class frmReservaVuelo : Form
    {
        //Variable para almacenar el destino seleccionado por defecto
        private string destinoSeleccionado;
        private clsDaoDatos dao = new clsDaoDatos();

        #region Eventos del Formulario
        public frmReservaVuelo(string destinoPorDefecto)
        {
            InitializeComponent();
            destinoSeleccionado = destinoPorDefecto;
        }

        private void frmReservaVuelo_Load(object sender, EventArgs e)
        {
            List<string> destinos = new List<string>
            {
                "Cancún (CUN)",
                "Los Cabos (SJD)",
                "Puerto Vallarta (PVR)",
                "Hermosillo (HMO)",
                "Bogotá (BOG)",
                "Washington (DCA)",
                "Nueva York (JFK)",
                "San Francisco (SFO)"
            };

            cmbDestino.DataSource = destinos;

            if (!string.IsNullOrEmpty(destinoSeleccionado))
            {
                int index = cmbDestino.FindStringExact(destinoSeleccionado);
                if (index >= 0)
                    cmbDestino.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Al
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            string destino = cmbDestino.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(destino))
            {
                Vuelo vuelo = dao.ObtenerDatosVueloPorDestino(destino);
                if (vuelo != null)
                {
                    lblSalida.Text = vuelo.FechaHoraSalida.ToString("dd/MM/yyyy HH:mm");
                    lblLlegada.Text = vuelo.FechaHoraLlegada.ToString("dd/MM/yyyy HH:mm");
                }
                else
                {
                    lblSalida.Text = "No disponible";
                    lblLlegada.Text = "No disponible";
                }
            }
            cmbDestino.SelectedIndexChanged += cmbDestino_SelectedIndexChanged;

        }
        #endregion

        #region eventos de los botones
        /// <summary>
        /// Cierra el formulario de reserva de vuelo cuando se hace clic en el botón "Cerrar".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAsientos_Click(object sender, EventArgs e)
        {
            int totalPasajeros = (int)nudAdultos.Value + (int)nudMenores.Value;

            if (totalPasajeros == 0)
            {
                MessageBox.Show("Selecciona al menos un pasajero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frmVenta = new frmVentaDeVoletos(totalPasajeros, (int)nudMenores.Value);
            frmVenta.ShowDialog();
        }


        #endregion

        private void nudAdultos_ValueChanged(object sender, EventArgs e)
        {
            ValidarLimitePasajeros();
        }

        private void nudMenores_ValueChanged(object sender, EventArgs e)
        {
            ValidarLimitePasajeros();
        }


        private void ValidarLimitePasajeros()
        {
            int total = (int)nudAdultos.Value + (int)nudMenores.Value;

            if (total > 9)
            {
                MessageBox.Show("No puedes seleccionar más de 9 pasajeros en total.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Restaurar valores válidos (prioriza adultos, ajusta menores)
                int permitidosMenores = 9 - (int)nudAdultos.Value;
                nudMenores.Value = Math.Max(0, permitidosMenores);
            }
        }

    }
}
