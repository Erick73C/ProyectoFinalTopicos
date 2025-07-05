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
        #region Variables y Objetos
        //Variable para almacenar el destino seleccionado por defecto
        private string destinoSeleccionado;
        private clsDaoDatos dao = new clsDaoDatos();
        #endregion

        #region Eventos del Formulario
        /// <summary>
        /// Constructor de la clase frmReservaVuelo.
        /// Inicializa el formulario y establece el destino por defecto.
        /// </summary>
        /// <param name="destinoPorDefecto"></param>
        public frmReservaVuelo(string destinoPorDefecto)
        {
            InitializeComponent();
            destinoSeleccionado = destinoPorDefecto;
        }

        /// <summary>
        /// carga los destinos disponibles en el ComboBox al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// Al cambiar el destino seleccionado en el ComboBox, actualiza las etiquetas de salida y llegada con los datos del vuelo correspondiente.
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

        /// <summary>
        /// Maneja el evento de clic en el botón de selección de asientos.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (botón).</param>
        /// <param name="e">Argumentos del evento.</param>
        /// <remarks>
        /// Este método realiza las siguientes acciones:
        /// 1. Calcula el total de pasajeros sumando adultos y menores
        /// 2. Valida que se haya seleccionado al menos un pasajero
        /// 3. Muestra mensaje de advertencia si no hay pasajeros seleccionados
        /// 4. Crea y muestra el formulario de venta de boletos con:
        ///    - El total de pasajeros
        ///    - La cantidad de pasajeros menores
        /// 
        /// El formulario se muestra de forma modal, bloqueando la interacción con el formulario padre
        /// hasta que se cierre.
        /// </remarks>
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

        #region Eventos de los controles numéricos
        /// <summary>
        /// Maneja el evento de cambio de valor en el control numérico de adultos.
        /// </summary>
        private void nudAdultos_ValueChanged(object sender, EventArgs e)
        {
            ValidarLimitePasajeros();
        }
        private void nudMenores_ValueChanged(object sender, EventArgs e)
        {
            ValidarLimitePasajeros();
        }

        /// <summary>
        /// Valida que el número total de pasajeros (adultos + menores) no exceda el límite permitido.
        /// </summary>
        /// <remarks>
        /// Este método realiza las siguientes acciones:
        /// 1. Calcula el total de pasajeros sumando adultos y menores
        /// 2. Si el total excede 9 pasajeros:
        ///    - Muestra un mensaje de advertencia
        ///    - Ajusta automáticamente la cantidad de menores para cumplir con el límite
        ///    - Prioriza mantener la cantidad de adultos seleccionada
        /// 
        /// Comportamiento específico:
        /// - Cuando se excede el límite, siempre se ajustan los menores, nunca los adultos
        /// - El valor mínimo de menores se establece en 0 (no permite valores negativos)
        /// - La validación se dispara desde los eventos ValueChanged de los controles numéricos
        /// </remarks>
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

        #endregion

    }
}
