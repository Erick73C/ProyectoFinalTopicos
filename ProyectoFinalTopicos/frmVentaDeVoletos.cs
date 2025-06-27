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

        private List<string> asientosOcupados = new List<string>();

        public frmVentaDeVoletos()
        {
            InitializeComponent();
            asientosOcupados = new List<string>();
            //grdAsientos.CellClick += grdAsientos_CellClick;
        }

        private void frmVentaDeVoletos_Load(object sender, EventArgs e)
        {
            ConfigurarGridAsientos();
            DibujarMapaAsientos();
        }


        /// <summary>
        /// Configura las propiedades básicas del DataGridView para mostrar los asientos
        /// </summary>
        private void ConfigurarGridAsientos()
        {
            // Limpiar configuración previa
            grdAsientos.Columns.Clear();
            grdAsientos.Rows.Clear();

            // Configuración básica
            grdAsientos.RowHeadersVisible = false;
            grdAsientos.ColumnHeadersVisible = false;
            grdAsientos.AllowUserToAddRows = false;
            grdAsientos.AllowUserToResizeRows = false;
            grdAsientos.AllowUserToResizeColumns = false;
            grdAsientos.ReadOnly = true;
            grdAsientos.ScrollBars = ScrollBars.None;
            grdAsientos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdAsientos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Calcular tamaños basados en el tamaño del control
            int anchoTotal = grdAsientos.Width - 2; // -2 para los bordes
            int altoTotal = grdAsientos.Height - 2;

            // Crear 7 columnas (3A + 1 pasillo + 3B)
            for (int i = 0; i < 7; i++)
            {
                DataGridViewColumn columna = new DataGridViewColumn();

                if (i == 3) // Columna del pasillo
                {
                    columna.CellTemplate = new DataGridViewTextBoxCell();
                    columna.Width = (int)(anchoTotal * 0.25); // 25% del ancho para el pasillo
                }
                else // Columnas de asientos
                {
                    columna.CellTemplate = new DataGridViewButtonCell();
                    columna.Width = (int)((anchoTotal * 0.75) / 6); // 75% restante dividido entre 6 columnas de asientos
                }

                grdAsientos.Columns.Add(columna);
            }

            // Crear 4 filas
            grdAsientos.Rows.Add(4);

            // Calcular altura de filas (igual para todas)
            int alturaFila = altoTotal / 4;
            foreach (DataGridViewRow row in grdAsientos.Rows)
            {
                row.Height = alturaFila;
            }

            // Asegurarse de que el DataGridView no sea más grande que su contenedor
            grdAsientos.AutoSize = true;
        }

        /// <summary>
        /// Dibuja el mapa de asientos en el DataGridView con el diseño 3x4 a cada lado y pasillo central
        /// </summary>
        private void DibujarMapaAsientos()
        {
            // Limpiar contenido previo
            foreach (DataGridViewRow row in grdAsientos.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                    cell.Style.BackColor = Color.Empty;
                }
            }

            // Asientos lado izquierdo (A1-A12)
            string[] asientosA = { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10", "A11", "A12", "A13" };

            // Asientos lado derecho (B1-B12)
            string[] asientosB = { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12" };



            // Llenar los asientos A (columnas 0-2)
            for (int fila = 0; fila < 4; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    int indexAsiento = fila * 3 + col;
                    if (indexAsiento < asientosA.Length)
                    {
                        grdAsientos[col, fila].Value = asientosA[indexAsiento];
                        grdAsientos[col, fila].Style.BackColor = Color.LightGray;
                        
                    }
                }
            }

            // Configurar el pasillo (columna 3)
            // Fusionar visualmente las celdas del pasillo
            grdAsientos[3, 0].Value = "PASILLO";
            grdAsientos[3, 0].Style.BackColor = Color.White;
            grdAsientos[3, 0].Style.Font = new Font(grdAsientos.Font, FontStyle.Bold);
            grdAsientos[3, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            // Dejar el resto de celdas del pasillo vacías
            for (int fila = 1; fila < 4; fila++)
            {
                grdAsientos[3, fila].Style.BackColor = Color.White;
            }

            // Llenar los asientos B (columnas 4-6)
            for (int fila = 0; fila < 4; fila++)
            {
                for (int col = 4; col < 7; col++)
                {
                    int indexAsiento = fila * 3 + (col - 4);
                    if (indexAsiento < asientosB.Length)
                    {
                        grdAsientos[col, fila].Value = asientosB[indexAsiento];
                        grdAsientos[col, fila].Style.BackColor = Color.LightGray;
                    }
                }
            }
        }


        /// <summary>
        /// Maneja el evento click en las celdas del DataGridView
        /// </summary>
        private void grdAsientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewCell celda = grdAsientos[e.ColumnIndex, e.RowIndex];

            // Verificar si la celda tiene valor
            if (celda.Value == null)
                return;

            string numeroAsiento = celda.Value.ToString();

            // Verificar si el asiento ya está ocupado (por color o lista)
            if (celda.Style.BackColor == Color.FromArgb(60, 179, 113) ||
                asientosOcupados.Contains(numeroAsiento))
            {
                MessageBox.Show($"El asiento {numeroAsiento} ya está ocupado",
                              "Asiento ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Marcar visualmente como ocupado
            celda.Style.BackColor = Color.FromArgb(60, 179, 113); // Verde
            celda.Style.ForeColor = Color.White;
            celda.Value = "OCUPADO";

            // Actualizar la lista de asientos ocupados
            asientosOcupados.Add(numeroAsiento);

            // Mostrar formulario para datos del pasajero
            
            using (frmDatosPasajero formDatos = new frmDatosPasajero())
            {
                if (formDatos.ShowDialog() == DialogResult.OK)
                {
                    // Guardar en base de datos si es necesario
                    MessageBox.Show($"Asiento {numeroAsiento} asignado a pasagero",
                                  "Reserva exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si el usuario cancela, revertir la selección
                    celda.Style.BackColor = Color.LightGray;
                    celda.Value = numeroAsiento;
                    asientosOcupados.Remove(numeroAsiento);
                }
            }
            
        }
    }
}
