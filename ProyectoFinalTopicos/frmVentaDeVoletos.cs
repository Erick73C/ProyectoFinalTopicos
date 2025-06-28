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

namespace ProyectoFinalTopicos
{
    public partial class frmVentaDeVoletos : Form
    {
        #region variables y constantes
        // Lista para almacenar los asientos ocupados
        private List<string> asientosOcupados = new List<string>();
        // Lista para almacenar los pasajeros
        private List<Pasajero> pasajeros = new List<Pasajero>();
        // Variables para manejar la selección de asientos
        private int asientosASeleccionar = 0;
        private int asientosSeleccionados = 0;
        //Poner el precio del asiento y maleta
        private const decimal PRECIO_ASIENTO = 500.00m;
        private const decimal PRECIO_MALETA = 150.00m;
        #endregion

        #region Metodos y eventos principales y auxiliares 
        public frmVentaDeVoletos()
        {
            InitializeComponent();
            asientosOcupados = new List<string>();
            grdAsientos.CellClick += grdAsientos_CellClick;
            numAsientos.Value = 1;
        }

        private void frmVentaDeVoletos_Load(object sender, EventArgs e)
        {
            btntiket.Enabled = false;   

            ConfigurarGridAsientos();
            DibujarMapaAsientos();
            lnlPrecio.Text = "Total: $0.00";
        }
        

        /// <summary>
        /// Actualiza el total de la venta sumando los precios de todos los pasajeros y las meletas que llevan.
        /// </summary>
        private void ActualizarTotal()
        {
            decimal totalAsientos = pasajeros.Sum(p => p.PrecioBase);
            decimal totalMaletas = pasajeros.Sum(p => p.PrecioMaletas);
            decimal totalGeneral = totalAsientos + totalMaletas;

            //Aqui modificas el texto de los labels para mostrar los totales
            lblCostoMaleta.Text = $"Total por maletas: ${totalMaletas.ToString("0.00")}";

            lnlPrecio.Text = $"Total: ${totalGeneral.ToString("0.00")}\n";
                /*
                           $"  (Asientos: ${totalAsientos.ToString("0.00")}\n" +
                           $"  Maletas: ${totalMaletas.ToString("0.00")})";
                */
        
        }
        #endregion

        #region configuración del DataGridView
        /// <summary>
        /// Configura las propiedades básicas del DataGridView para mostrar los asientos
        /// </summary>
        private void ConfigurarGridAsientos()
        {
            grdAsientos.Columns.Clear();
            grdAsientos.Rows.Clear();

            grdAsientos.RowHeadersVisible = false;
            grdAsientos.ColumnHeadersVisible = false;
            grdAsientos.AllowUserToAddRows = false;
            grdAsientos.AllowUserToResizeRows = false;
            grdAsientos.AllowUserToResizeColumns = false;
            grdAsientos.ReadOnly = true;
            grdAsientos.ScrollBars = ScrollBars.None;
            grdAsientos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdAsientos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            int anchoTotal = grdAsientos.Width - 2;
            int altoTotal = grdAsientos.Height - 2;

            for (int i = 0; i < 7; i++)
            {
                DataGridViewColumn columna = new DataGridViewColumn();

                if (i == 3)
                {
                    columna.CellTemplate = new DataGridViewTextBoxCell();
                    columna.Width = (int)(anchoTotal * 0.25);
                }
                else
                {
                    columna.CellTemplate = new DataGridViewButtonCell();
                    columna.Width = (int)((anchoTotal * 0.75) / 6);
                }

                grdAsientos.Columns.Add(columna);
            }

            grdAsientos.Rows.Add(16);

            int alturaFila = altoTotal / 16;
            foreach (DataGridViewRow row in grdAsientos.Rows)
            {
                row.Height = alturaFila;
            }

            grdAsientos.AutoSize = true;
        }

        /// <summary>
        /// Dibuja el mapa de asientos en el DataGridView con el diseño 3x16 a cada lado y pasillo central
        /// </summary>
        private void DibujarMapaAsientos()
        {
            grdAsientos.Rows.Clear();
            grdAsientos.Rows.Add(16);

            int alturaFila = grdAsientos.Height / 16;
            foreach (DataGridViewRow row in grdAsientos.Rows)
            {
                row.Height = alturaFila;
            }

            string[] asientosA = { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10",
                      "A11", "A12", "A13", "A14", "A15", "A16", "A17", "A18", "A19", "A20",
                      "A21", "A22", "A23", "A24", "A25", "A26", "A27", "A28", "A29", "A30",
                      "A31", "A32", "A33", "A34", "A35", "A36", "A37", "A38", "A39", "A40",
                      "A41", "A42", "A43", "A44", "A45", "A46", "A47", "A48" };

            string[] asientosB = { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10",
                      "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20",
                      "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30",
                      "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40",
                      "B41", "B42", "B43", "B44", "B45", "B46", "B47", "B48" };

            for (int fila = 0; fila < 16; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    int indexAsiento = fila * 3 + col;
                    if (indexAsiento < asientosA.Length)
                    {
                        grdAsientos[col, fila].Value = asientosA[indexAsiento];
                        grdAsientos[col, fila].Style.BackColor = asientosOcupados.Contains(asientosA[indexAsiento]) ?
                            Color.FromArgb(60, 179, 113) : Color.LightGray;
                        grdAsientos[col, fila].Style.ForeColor = Color.Black;
                        grdAsientos[col, fila].Style.Font = new Font("Arial", 9, FontStyle.Bold);
                    }
                }
            }

            grdAsientos[3, 0].Value = "PASILLO PRINCIPAL";
            grdAsientos[3, 0].Style.BackColor = Color.White;
            grdAsientos[3, 0].Style.Font = new Font(grdAsientos.Font, FontStyle.Bold);
            grdAsientos[3, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            for (int fila = 1; fila < 16; fila++)
            {
                grdAsientos[3, fila].Style.BackColor = Color.White;
            }

            for (int fila = 0; fila < 16; fila++)
            {
                for (int col = 4; col < 7; col++)
                {
                    int indexAsiento = fila * 3 + (col - 4);
                    if (indexAsiento < asientosB.Length)
                    {
                        grdAsientos[col, fila].Value = asientosB[indexAsiento];
                        grdAsientos[col, fila].Style.BackColor = asientosOcupados.Contains(asientosB[indexAsiento]) ?
                            Color.FromArgb(60, 179, 113) : Color.LightGray;
                        grdAsientos[col, fila].Style.ForeColor = Color.Black;
                        grdAsientos[col, fila].Style.Font = new Font("Arial", 9, FontStyle.Bold);
                    }
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic en una celda del DataGridView de asientos.
        /// Permite seleccionar un asiento disponible, solicita los datos del pasajero
        /// y actualiza el estado del asiento y la lista de pasajeros.
        /// Valida que no se exceda la cantidad de asientos a seleccionar y que el asiento no esté ocupado.
        /// </summary>
        private void grdAsientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Obtenemos la cantidad de asientos del NumericUpDown
            asientosASeleccionar = (int)numAsientos.Value;

            if (asientosASeleccionar <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida de asientos a reservar",
                              "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (asientosSeleccionados >= asientosASeleccionar)
            {
                MessageBox.Show("Ya ha seleccionado todos los asientos requeridos",
                              "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewCell celda = grdAsientos[e.ColumnIndex, e.RowIndex];

            if (celda.Value == null)
                return;

            string numeroAsiento = celda.Value.ToString();

            if (celda.Style.BackColor == Color.FromArgb(60, 179, 113) ||
                asientosOcupados.Contains(numeroAsiento))
            {
                MessageBox.Show($"El asiento {numeroAsiento} ya está ocupado",
                              "Asiento ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (frmDatosPasajero formDatos = new frmDatosPasajero(numeroAsiento, PRECIO_MALETA))
            {
                formDatos.NumeroAsiento = numeroAsiento; // Pasamos el número de asiento

                if (formDatos.ShowDialog() == DialogResult.OK)
                {
                    celda.Style.BackColor = Color.FromArgb(60, 179, 113);
                    celda.Style.ForeColor = Color.White;
                    celda.Value = numeroAsiento + "\n" + formDatos.NombrePasajero + " " + formDatos.ApellidoPasajero;

                    asientosOcupados.Add(numeroAsiento);
                    pasajeros.Add(new Pasajero
                    {
                        Nombre = formDatos.NombrePasajero,
                        Apellido = formDatos.ApellidoPasajero,
                        Asiento = numeroAsiento,
                        PrecioBase = PRECIO_ASIENTO,
                        PrecioMaletas = formDatos.TotalMaletas,
                        Telefono = formDatos.Telefono,
                        NumeroMaletas = formDatos.NumeroMaletas,
                        NumeroPasaporte = formDatos.NumeroPasaporte,
                        Origen = formDatos.Origen,
                        Destino = formDatos.Destino
                    });

                    asientosSeleccionados++;
                    ActualizarTotal();

                    if (asientosSeleccionados == asientosASeleccionar)
                    {
                        btntiket.Enabled = true;
                    }
                }
            }
        
        }
        #endregion

        #region Eventos de botones
        private void btnEstablecerAsientos_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numAsientos.Value;

            if (cantidad > 0)
            {
                asientosASeleccionar = cantidad;
                asientosSeleccionados = 0;
                btntiket.Enabled = false;
                lblInstruccion.Text = $"Seleccione {cantidad} asientos";
            }
            else
            {
                MessageBox.Show("Ingrese un número válido de asientos",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            asientosOcupados.Clear();
            pasajeros.Clear();
            asientosASeleccionar = 0;
            asientosSeleccionados = 0;
            numAsientos.Value = 1;
            lnlPrecio.Text = "Total: $0.00";
            lblCostoMaleta.Text = "Total por maletas: $0.00";
            btntiket.Enabled = false;
            lblInstruccion.Text = "Ingrese cantidad de asientos";
            DibujarMapaAsientos();
        }

        private void btntiket_Click(object sender, EventArgs e)
        {
            frmTicket tk = new frmTicket();
            tk.ShowDialog();
        }
        #endregion
        
    }
}
