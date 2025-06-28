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
    public partial class frmDatosPasajero : Form
    {
        public string NombrePasajero { get; private set; }
        public string ApellidoPasajero { get; private set; }
        public string Telefono { get; private set; }
        public int NumeroMaletas { get; private set; }
        public string NumeroPasaporte { get; private set; }
        public string Origen { get; private set; }
        public string Destino { get; private set; }
        public string NumeroAsiento { get; set; }
        public decimal CostoPorMaleta { get; private set; }
        public decimal TotalMaletas { get; private set; }


        //private string asiento;

        public frmDatosPasajero(string numeroAsiento, decimal costoPorMaletA)
        {
            InitializeComponent();
            NumeroAsiento = numeroAsiento;
            CostoPorMaleta = costoPorMaletA;

            lblAsiento.Text = $"Asiento: {NumeroAsiento}";
            lblCostoMaletas.Text = $"Costo por maleta: ${CostoPorMaleta.ToString("0.00")}";
            lblCostoMaletas.Text = $"Costo total maletas: $0.00";

            CargarDestinos();

            // Configura el NumericUpDown para maletas
            numericNumeroMaletas.Minimum = 0;
            numericNumeroMaletas.Maximum = 5; // Límite de 5 maletas
            numericNumeroMaletas.ValueChanged += numericNumeroMaletas_ValueChanged;
        }


        private List<string> destinosDisponibles = new List<string>
        {
            "Ciudad de México", "Nueva York", "Los Ángeles",
            "París", "Tokio", "Londres", "Madrid", "Buenos Aires"
        };

        private void CargarDestinos()
        {
            cbxOrigen.Items.AddRange(destinosDisponibles.ToArray());
            cbxDestino.Items.AddRange(destinosDisponibles.ToArray());

            // Establecer valores por defecto
            cbxOrigen.SelectedIndex = 0;
            cbxDestino.SelectedIndex = 1;
        }

        private void frmDatosPasajero_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            NombrePasajero = txtNombrePasagero.Text.Trim();
            ApellidoPasajero = txtApellidoPasageri.Text.Trim();
            Telefono = txtNumeroTelefono.Text.Trim();
            NumeroMaletas = (int)numericNumeroMaletas.Value;
            NumeroPasaporte = txtnoPasaporte.Text.Trim();
            Origen = cbxOrigen.Text;
            Destino = cbxDestino.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombrePasagero.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del pasajero",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombrePasagero.Text))
            {
                MessageBox.Show("Por favor ingrese el apellido del pasajero",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtnoPasaporte.Text))
            {
                MessageBox.Show("Por favor ingrese el número de pasaporte",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxOrigen.SelectedItem == null || cbxDestino.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione origen y destino",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxOrigen.Text == cbxDestino.Text)
            {
                MessageBox.Show("El origen y destino no pueden ser iguales",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void numericNumeroMaletas_ValueChanged(object sender, EventArgs e)
        {
            int maletas = (int)numericNumeroMaletas.Value;
            TotalMaletas = maletas * CostoPorMaleta;
            lblCostoMaletas.Text = $"Costo Total por maletas: ${TotalMaletas.ToString("0.00")}";
        }

        private void lblCostoMaletas_Click(object sender, EventArgs e)
        {

        }
    }


}
