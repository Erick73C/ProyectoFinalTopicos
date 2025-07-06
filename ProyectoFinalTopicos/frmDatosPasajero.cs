using ProyectoFinalTopicos.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTopicos
{
    public partial class frmDatosPasajero : Form
    {
        #region Variables y constantes
        // Propiedades para almacenar los datos del pasajero
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
        private decimal precioBaseVuelo;
        public bool EsMenor { get; set; }
        public decimal Descuento { get; set; }
        public decimal PrecioBase { get; set; }
        private bool esMenor;

        #endregion

        //private string asiento;

        #region Propiedades públicas al cargar el formulario 
        /// <summary>
        /// Conructor de la clase frmDatosPasajero.
        /// </summary>
        /// <param name="numeroAsiento"></param>
        /// <param name="costoPorMaletA"></param>
        /// 
        public frmDatosPasajero(string numeroAsiento, decimal costoPorMaletA, int numeroPasajero, string destinoSeleccionado, bool esMenor, decimal precioBaseVuelo)
        {
            InitializeComponent();
            NumeroAsiento = numeroAsiento;
            CostoPorMaleta = costoPorMaletA;

            lblNombrePasagero.Text = $"Datos del Pasajero #{numeroPasajero}";
            lblAsiento.Text = $"Asiento: {NumeroAsiento}";
            lblCostoMaletas.Text = $"Costo por maleta: ${CostoPorMaleta.ToString("0.00")}";
            lblCostoMaletas.Text = $"Costo total maletas: $0.00";

            CargarDestinos();

            //Obtner el destinp seleccionado en frmReservavuelos
            cbxDestino.SelectedItem = destinoSeleccionado;

            cbxOrigen.Enabled = false;
            cbxDestino.Enabled = false;

            // Configura el NumericUpDown para maletas
            numericNumeroMaletas.Minimum = 0;
            numericNumeroMaletas.Maximum = 5; // Límite de 5 maletas
            numericNumeroMaletas.ValueChanged += numericNumeroMaletas_ValueChanged;

            if (esMenor)
            {
                decimal descuento = precioBaseVuelo * 0.30m; // 30% de descuento
                
                PrecioBase = precioBaseVuelo - descuento;

                lblMenor.Visible = true;
                lblDescuentoMenor.Visible = true;
                lblDescuentoMenor.Text = $"Descuento aplicado: ${descuento:0.00}";
            }
            else
            {
                lblMenor.Visible = false;
                PrecioBase = precioBaseVuelo;
                lblDescuentoMenor.Visible = false;
                Descuento = 0;
            }

            
        }
        /// <summary>
        /// Al carga el formulario los txtbox de origen y destino se desabilitan 
        /// y cargan los datos del formulario de frEscoger 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDatosPasajero_Load(object sender, EventArgs e)
        {
            ///Nuevo
            cbxDestino.Enabled = false; 
            cbxOrigen.Enabled = false;
        }
        #endregion

        #region Metodos auxiliares
        /// <summary>
        /// Carga en las combobox los destinos disponibles
        /// </summary>
        private void CargarDestinos()
        {
            var destinos = new List<string>
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

            cbxOrigen.Items.AddRange(destinos.ToArray());
            cbxDestino.Items.AddRange(destinos.ToArray());

            cbxOrigen.SelectedIndex = 0;

        }

        /// <summary>
        /// valida los datos ingresados por el usuario en el formulario.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Carga los destinos disponibles en los ComboBox de origen y destino.
        /// </summary>
        private List<string> destinosDisponibles = new List<string>
        {
            "Ciudad de México", "Nueva York", "Los Ángeles",
            "París", "Tokio", "Londres", "Madrid", "Buenos Aires"
        };
        #endregion

        #region Logica de eventos de elementos de formulario y botones
        /// <summary>
        /// Cierra el formulario 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Guarda los datos del pasagero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            PrecioBase = precioBaseVuelo;
            Descuento = esMenor ? precioBaseVuelo * 0.20m : 0;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Va sumando el numero de maletas del pasagero
        /// Y lo va poniendo en el lblCostoMaletas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericNumeroMaletas_ValueChanged(object sender, EventArgs e)
        {
            int maletas = (int)numericNumeroMaletas.Value;
            TotalMaletas = maletas * CostoPorMaleta;
            lblCostoMaletas.Text = $"Costo Total por maletas: ${TotalMaletas.ToString("0.00")}";
        }

        private void lblCostoMaletas_Click(object sender, EventArgs e)
        {

        }

        #endregion

        //NUEVO PARTE DE VALIDACION DE CAMPOS AÑADIR TAMBIEN LOS ERRORPRIVIDER
        #region Validacion de datos

        /// <summary>
        /// Valida que el campo no este vacio
        /// y que el numero de caracteres no pase de 30
        /// </summary>
        private void validarNombre()
        {
            string patronNombre = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ'\s]+$";

            if (string.IsNullOrEmpty(txtNombrePasagero.Text) == true)
            {
                txtNombrePasagero.Focus();
                txtNombrePasagero.BackColor = Color.IndianRed;
                errNombre.SetError(txtNombrePasagero, "Debe escribir el nombre");
            }
            else if (!Regex.IsMatch(txtNombrePasagero.Text, patronNombre))
            {
                txtNombrePasagero.Focus();
                txtNombrePasagero.BackColor = Color.IndianRed;
                errNombre.SetError(txtNombrePasagero, "El nombre no puede contener números ni caracteres especiales");
            }
            else if (txtNombrePasagero.Text.Length >= 30)
            {
                txtNombrePasagero.Focus();
                txtNombrePasagero.BackColor = Color.IndianRed;
                errNombre.SetError(txtNombrePasagero, "El nombre debe de ser menor a 30 caracteres");
            }
            else
            {
                errNombre.Clear();
                txtNombrePasagero.BackColor = Color.White;
            }
        }
        /// <summary>
        /// Valida que el campo de los apellidos no este vacio
        /// que no sea igual al nombre
        /// y que no supere los 30 caracteres 
        /// </summary>
        private void validarApellidos()
        {
            string patronApellidos = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ'\s]+$";

            if (string.IsNullOrEmpty(txtApellidoPasageri.Text) == true && txtApellidoPasageri.Text == "")
            {
                txtApellidoPasageri.Focus();
                txtApellidoPasageri.BackColor = Color.IndianRed;
                errApellidos.SetError(txtApellidoPasageri, "Debe escribir el correo");
            }
            else if (!Regex.IsMatch(txtApellidoPasageri.Text, patronApellidos))
            {
                txtApellidoPasageri.Focus();
                txtApellidoPasageri.BackColor = Color.IndianRed;
                errApellidos.SetError(txtApellidoPasageri, "El apellido no puede contener números ni caracteres especiales");
            }
            else if (txtNombrePasagero.Text == txtApellidoPasageri.Text)
            {
                txtApellidoPasageri.Focus();
                txtApellidoPasageri.BackColor = Color.IndianRed;
                errApellidos.SetError(txtApellidoPasageri, "El aplido debe de ser diferente al nombre");
            }
            else if (txtApellidoPasageri.Text.Length >= 30)
            {
                txtApellidoPasageri.Focus();
                txtApellidoPasageri.BackColor = Color.IndianRed;
                errApellidos.SetError(txtApellidoPasageri, "El Apellido debe de ser menor a 30 caracteres");
            }
            else
            {
                errApellidos.Clear();
                txtApellidoPasageri.BackColor = Color.White;
            }
        }

        /// <summary>
        /// valida que el campo no este vacio 
        /// y que coincidaa con el patron de un numero de telefono
        /// </summary>
        private void validarNumeroDeTelefono()
        {
            //Automata para la validacion del numero de telefono
            string patron = @"^\(?\d{2}\)?[- ]?\d{4}[- ]?\d{4}$";

            if (string.IsNullOrEmpty(txtNumeroTelefono.Text))
            {
                txtNumeroTelefono.Focus();
                txtNumeroTelefono.BackColor = Color.IndianRed;
                errNueroTelefono.SetError(txtNumeroTelefono, "Debe escribir el número telefónico");
            }
            else if (!Regex.IsMatch(txtNumeroTelefono.Text, patron))
            {
                txtNumeroTelefono.Focus();
                txtNumeroTelefono.BackColor = Color.IndianRed;
                errNueroTelefono.SetError(txtNumeroTelefono, "Formato de teléfono inválido. Use 10 dígitos (ej. 5512345678 o 55-1234-5678)");
            }
            else
            {
                errNueroTelefono.Clear();
                txtNumeroTelefono.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Valida que el campo del pasaporte no este vacio 
        /// acepta cualquir cosa 
        /// </summary>
        private void validarPasaporte()
        {
            if (string.IsNullOrEmpty(txtnoPasaporte.Text) == true)
            {
                txtnoPasaporte.Focus();
                txtnoPasaporte.BackColor = Color.IndianRed;
                errNoPasaporte.SetError(txtnoPasaporte, "Debe escribir el nombre");
            }
            else
            {
                errNoPasaporte.Clear();
                txtnoPasaporte.BackColor = Color.White;
            }
        }


        #region Validar

        private void txtNombrePasagero_Leave(object sender, EventArgs e)
        {
            validarNombre();
        }

        private void txtApellidoPasageri_Leave(object sender, EventArgs e)
        {
            validarApellidos();
        }
        private void txtNumeroTelefono_Leave(object sender, EventArgs e)
        {
            validarNumeroDeTelefono();
        }

        private void txtnoPasaporte_Leave(object sender, EventArgs e)
        {
            validarPasaporte();
        }


        #endregion

        #endregion

        private void cbxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
