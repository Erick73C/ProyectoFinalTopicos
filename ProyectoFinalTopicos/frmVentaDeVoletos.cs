using ProyectoFinalTopicos.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        //private List<Pasajero> pasajeros = new List<Pasajero>();
        private BindingList<Pasajero> pasajeros = new BindingList<Pasajero>();
        // Variables para manejar la selección de asientos
        private int asientosASeleccionar = 0;
        private int asientosSeleccionados = 0;
        //Poner el precio del asiento y maleta
        private const decimal PRECIO_ASIENTO = 500.00m;
        private const decimal PRECIO_MALETA = 150.00m;
        // Variables para manejar la reasignación de asientos
        private bool modoReasignacion = false;
        private Pasajero pasajeroReasignando;
        private const int MAX_PASAJEROS = 9; // Límite máximo de pasajeros
        private Pasajero pasajeroSeleccionado = null;
        //Lista de boletos
        private List<Boleto> boletosGuardados = new List<Boleto>();
        //Guardar el total de pasajeros esperados y la cantidad de menores
        private int totalPasajerosEsperados;
        private int cantidadMenores;


        #endregion

        private clsDaoDatos dao = new clsDaoDatos();

        #region Metodos y eventos principales y auxiliares 

        /// <summary>
        /// Constructor del formulario que inicializa los componentes y configura el estado inicial.
        /// </summary>
        /// <param name="totalPasajeros"></param>
        /// <param name="menores"></param>
        public frmVentaDeVoletos(int totalPasajeros, int menores)
        {
            InitializeComponent();

            totalPasajerosEsperados = totalPasajeros;
            cantidadMenores = menores;

            lstPasajeros.DataSource = pasajeros;
            lstPasajeros.DisplayMember = "Descripcion";
            lstPasajeros.ValueMember = "Asiento";

            // Configurar eventos
            lstPasajeros.SelectedIndexChanged += lstPasajeros_SelectedIndexChanged;
            grdAsientos.CellClick += grdAsientos_CellClick;
            numAsientos.Value = 1;

            // Recuperar los asientos ocupados desde la base de datos
            asientosOcupados = dao.ObtenerAsientosOcupados("V123");

            // Configurar el estilo por defecto para las celdas de botón
            grdAsientos.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.LightGray,
                ForeColor = Color.Black,
                Font = new Font("Arial", 9, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                SelectionBackColor = Color.Gray,
                SelectionForeColor = Color.White
            };

            ConfigurarGridAsientos();
            DibujarMapaAsientos();
            lnlPrecio.Text = "Total: $0.00";
        }

        /// <summary>
        /// Carga el formulario y configura los controles iniciales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVentaDeVoletos_Load(object sender, EventArgs e)
        {
            btntiket.Enabled = false;
            numAsientos.ValueChanged += numAsientos_ValueChanged;

            numAsientos.Value = totalPasajerosEsperados;
            numAsientos.Enabled = false;
            lblContadorPasageros.Text = $"0/{totalPasajerosEsperados}";
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

            lblContadorPasageros.Text = $"{pasajeros.Count}/{numAsientos.Value}";

            // Actualizar estado del botón
            btntiket.Enabled = pasajeros.Count == (int)numAsientos.Value;

        }

        /// <summary>
        /// Se encarga de mover el numero de asiento del pasagero que se selecciono
        /// el asiento tiene que estar vacio 
        /// </summary>
        /// <param name="e"></param>
        private void ReasignarAsiento(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                modoReasignacion = false;
                return;
            }

            DataGridViewCell celda = grdAsientos[e.ColumnIndex, e.RowIndex];
            if (celda.Value == null) return;

            string nuevoAsiento = celda.Value.ToString();

            // Validar que el nuevo asiento no esté ocupado
            if (asientosOcupados.Contains(nuevoAsiento) && nuevoAsiento != pasajeroReasignando.Asiento)
            {
                MessageBox.Show($"El asiento {nuevoAsiento} ya está ocupado",
                              "Asiento ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Liberar el asiento anterior (si es diferente)
            if (nuevoAsiento != pasajeroReasignando.Asiento)
            {
                asientosOcupados.Remove(pasajeroReasignando.Asiento);
                asientosOcupados.Add(nuevoAsiento);
            }

            // Actualizar el pasajero
            pasajeroReasignando.Asiento = nuevoAsiento;

            // Actualizar la visualización
            DibujarMapaAsientos();
            ConfigurarListaPasajeros();

            // Salir del modo reasignación
            modoReasignacion = false;
            pasajeroReasignando = null;
            lblInstruccion.Text = "Seleccione pasajeros o asientos";
            lblInstruccion.ForeColor = SystemColors.ControlText;

            // Restaurar controles
            numAsientos.Enabled = true;
        }

        /*
        private void ActualizarListaPasajeros()
        {
            lstPasajeros.DataSource = null;
            lstPasajeros.DataSource = pasajeros;
            lstPasajeros.DisplayMember = "Descripcion";
            lblContadorPasageros.Text = "Pasajeros"+$"{pasajeros.Count}/{MAX_PASAJEROS}";
        }
        */

        /// <summary>
        /// Maneja el evento cuando cambia la selección en la lista de pasajeros.
        /// Si hay un pasajero seleccionado, habilita los botones para mover o eliminar al pasajero.
        /// Si no hay selección, deshabilita estos botones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.lstPasajeros.SelectedIndexChanged += new System.EventHandler(this.lstPasajeros_SelectedIndexChanged);

            if (lstPasajeros.SelectedItem is Pasajero pasajero)
            {
                pasajeroSeleccionado = pasajero;
                btnMoverAsiento.Enabled = true;
                btnEliminarPasajero.Enabled = true;
            }
            else
            {
                pasajeroSeleccionado = null;
                btnMoverAsiento.Enabled = false;
                btnEliminarPasajero.Enabled = false;
            }
        }


        /// <summary>
        /// Configura la lista visual de pasajeros en el control lstPasajeros,
        /// estableciendo los campos a mostrar y el origen de datos con la lista actual de pasajeros.
        /// Además, actualiza el contador visual de pasajeros en la interfaz.
        /// </summary>
        private void ConfigurarListaPasajeros()
        {
            lstPasajeros.DisplayMember = "Descripcion";
            lstPasajeros.ValueMember = "Asiento";
            lstPasajeros.DataSource = new BindingList<Pasajero>(pasajeros);

            // Actualizar contador
            ActualizarContadorPasajeros();
        }

        /// <summary>
        /// Actualiza el contador visual de pasajeros en la interfaz, mostrando la cantidad actual de pasajeros respecto al máximo permitido.
        /// Cambia el color del texto a rojo si se alcanza o supera el límite de pasajeros.
        /// Refresca la lista de pasajeros para asegurar que la información esté actualizada.
        /// </summary>
        private void ActualizarContadorPasajeros()
        {
            lblContadorPasageros.Text = $"{pasajeros.Count}/{MAX_PASAJEROS} pasajeros";
            lblContadorPasageros.ForeColor = pasajeros.Count >= MAX_PASAJEROS ? Color.Red : Color.Black;
            lstPasajeros.Refresh();
        }

        /// <summary>
        /// Maneja el evento cuando cambia el valor del control numAsientos.
        /// Si el nuevo valor es menor que la cantidad de pasajeros ya registrados,
        /// muestra un mensaje de advertencia y revierte el cambio.
        /// Si no, actualiza el contador de pasajeros y el estado del botón de ticket.
        /// </summary>
        private void numAsientos_ValueChanged(object sender, EventArgs e)
        {
            int nuevoValor = (int)numAsientos.Value;

            // Si reducimos el número de asientos y ya hay más pasajeros
            if (nuevoValor < pasajeros.Count)
            {
                MessageBox.Show($"Debe eliminar {pasajeros.Count - nuevoValor} pasajeros primero",
                              "Ajuste no permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numAsientos.Value = pasajeros.Count; // Revertir el cambio
                return;
            }

            // Actualizar el texto del contador
            lblContadorPasageros.Text = $"{pasajeros.Count}/{numAsientos.Value}";

            // Actualizar estado del botón de ticket
            btntiket.Enabled = pasajeros.Count == numAsientos.Value;
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

            // Configuración básica del grid
            grdAsientos.RowHeadersVisible = false;
            grdAsientos.ColumnHeadersVisible = false;
            grdAsientos.AllowUserToAddRows = false;
            grdAsientos.AllowUserToResizeRows = false;
            grdAsientos.AllowUserToResizeColumns = false;
            grdAsientos.ReadOnly = true;
            grdAsientos.ScrollBars = ScrollBars.None;
            grdAsientos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdAsientos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Configurar las columnas
            for (int i = 0; i < 7; i++)
            {
                DataGridViewColumn columna;

                if (i == 3)
                {
                    columna = new DataGridViewTextBoxColumn();
                    columna.Width = (int)(grdAsientos.Width * 0.25);
                }
                else
                {
                    columna = new DataGridViewButtonColumn();
                    columna.Width = (int)((grdAsientos.Width * 0.75) / 6);

                    // Configurar estilo específico para los botones
                    columna.DefaultCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = Color.LightGray,
                        ForeColor = Color.Black,
                        Font = new Font("Arial", 9, FontStyle.Bold),
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    };
                }

                grdAsientos.Columns.Add(columna);
            }

            // Configurar las filas
            grdAsientos.Rows.Add(16);
            int alturaFila = grdAsientos.Height / 16;

            foreach (DataGridViewRow row in grdAsientos.Rows)
            {
                row.Height = alturaFila;
            }
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
                        string asiento = asientosA[indexAsiento];
                        grdAsientos[col, fila].Value = asientosOcupados.Contains(asiento) ? "X" : asiento;
                        grdAsientos[col, fila].Style.BackColor = asientosOcupados.Contains(asiento) ? Color.Red : Color.LightGray;
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
                        string asiento = asientosB[indexAsiento];
                        grdAsientos[col, fila].Value = asientosOcupados.Contains(asiento) ? "X" : asiento;
                        grdAsientos[col, fila].Style.BackColor = asientosOcupados.Contains(asiento) ? Color.Red : Color.LightGray;
                        grdAsientos[col, fila].Style.ForeColor = Color.Black;
                        grdAsientos[col, fila].Style.Font = new Font("Arial", 9, FontStyle.Bold);
                    }
                }
            }

            grdAsientos.Refresh();
        }

        /// <summary>
        /// Maneja el evento de clic en una celda del DataGridView de asientos.
        /// Permite seleccionar un asiento disponible, solicita los datos del pasajero
        /// y actualiza el estado del asiento y la lista de pasajeros.
        /// Valida que no se exceda la cantidad de asientos a seleccionar y que el asiento no esté ocupado.
        /// </summary>
        private void grdAsientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejo de reasignación
            if (modoReasignacion)
            {
                ReasignarAsiento(e);
                return;
            }

            // Validación de celdas no válidas
            if (e.ColumnIndex == 3 || e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Obtener cantidad de asientos a seleccionar
            asientosASeleccionar = (int)numAsientos.Value;

            // Validaciones previas
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

            if (pasajeros.Count >= asientosASeleccionar)
            {
                MessageBox.Show($"Ya ha seleccionado los {asientosASeleccionar} asientos requeridos",
                              "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtener celda seleccionada
            DataGridViewCell celda = grdAsientos[e.ColumnIndex, e.RowIndex];

            if (celda.Value == null)
                return;

            string numeroAsiento = celda.Value.ToString();

            // Verificar si el asiento está ocupado
            if (celda.Style.BackColor == Color.FromArgb(60, 179, 113) ||
                asientosOcupados.Contains(numeroAsiento))
            {
                MessageBox.Show($"El asiento {numeroAsiento} ya está ocupado",
                              "Asiento ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mostrar formulario de datos del pasajero
            using (frmDatosPasajero formDatos = new frmDatosPasajero(numeroAsiento, PRECIO_MALETA, pasajeros.Count + 1))
            {
                formDatos.NumeroAsiento = numeroAsiento;

                if (formDatos.ShowDialog() == DialogResult.OK)
                {
                    // Actualizar apariencia de la celda
                    celda.Style.BackColor = Color.FromArgb(60, 179, 113);
                    celda.Style.ForeColor = Color.White;
                    celda.Value = $"{numeroAsiento}\n{formDatos.NombrePasajero} {formDatos.ApellidoPasajero}";

                    // Agregar a lista de asientos ocupados
                    asientosOcupados.Add(numeroAsiento);

                    bool esMenor = pasajeros.Count(p => p.EsMenor) < cantidadMenores;
                    // Crear nuevo pasajero
                    var nuevoPasajero = new Pasajero
                    {
                        Nombre = formDatos.NombrePasajero,
                        Apellido = formDatos.ApellidoPasajero,
                        EsMenor = esMenor,
                        Asiento = numeroAsiento,
                        PrecioBase = PRECIO_ASIENTO,
                        PrecioMaletas = formDatos.TotalMaletas,
                        Telefono = formDatos.Telefono,
                        NumeroMaletas = formDatos.NumeroMaletas,
                        NumeroPasaporte = formDatos.NumeroPasaporte,
                        Origen = formDatos.Origen,
                        Destino = formDatos.Destino
                    };

                    // Actualizar contadores y listas
                    asientosSeleccionados++;
                    pasajeros.Add(nuevoPasajero);

                    // Forzar actualización de los controles
                    lstPasajeros.DataSource = null;
                    lstPasajeros.DataSource = pasajeros;
                    lstPasajeros.DisplayMember = "Descripcion";
                    lstPasajeros.ValueMember = "Asiento";
                    lstPasajeros.Refresh();

                    DibujarMapaAsientos();
                    ActualizarTotal();

                    // Habilitar botón de ticket si se completaron todos los asientos
                    btntiket.Enabled = (asientosSeleccionados == asientosASeleccionar);
                }
            }
        }
        #endregion

        #region Eventos de botones
        /// <summary>
        /// Mueve al pasagero seleccionado en la lista de pasageros a otro asiento que no este ocupado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoverAsiento_Click(object sender, EventArgs e)
        {
            if (pasajeroSeleccionado == null) return;

            // Mostrar mensaje de instrucción
            lblInstruccion.Text = $"Seleccione nuevo asiento para {pasajeroSeleccionado.NombreCompleto}";
            lblInstruccion.ForeColor = Color.Blue;

            // Activar modo reasignación
            modoReasignacion = true;
            pasajeroReasignando = pasajeroSeleccionado;

            // Deshabilitar botones mientras se reasigna
            btnMoverAsiento.Enabled = false;
            btnEliminarPasajero.Enabled = false;
            numAsientos.Enabled = false;
        }

        /// <summary>
        /// Elimina el pasagero seleccionado en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            if (pasajeroSeleccionado == null) return;

            var confirmacion = MessageBox.Show(
                $"¿Eliminar a {pasajeroSeleccionado.NombreCompleto} del asiento {pasajeroSeleccionado.Asiento}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                // Liberar el asiento
                asientosOcupados.Remove(pasajeroSeleccionado.Asiento);

                // Eliminar al pasajero
                pasajeros.Remove(pasajeroSeleccionado);

                // Actualizar la lista y el mapa
                ConfigurarListaPasajeros();
                DibujarMapaAsientos();
                ActualizarTotal();

                // Reducir contador de asientos seleccionados
                asientosSeleccionados--;

                // Actualizar estado del botón de ticket
                btntiket.Enabled = pasajeros.Count == asientosASeleccionar;

                if (numAsientos.Value > pasajeros.Count)
                {
                    numAsientos.Value = pasajeros.Count;
                }
            }
        }


        /// <summary>
        /// Se encarga recopilar los datos de los asientos y guardarlos en la base de datos 
        /// si no hay ningun error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstablecerAsientos_Click_1(object sender, EventArgs e)
        {
            int cantidad = (int)numAsientos.Value;

            if (cantidad > 0)
            {
                if (pasajeros.Count == 0)
                {
                    MessageBox.Show("Debes seleccionar primero los pasajeros antes de guardar los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool errores = false;

                boletosGuardados.Clear();

                foreach (var pasajero in pasajeros)
                {
                    try
                    {
                        Vuelo vuelo = new Vuelo
                        {
                            NumeroVuelo = "V123",
                            AeropuertoOrigen = pasajero.Origen,
                            AeropuertoDestino = pasajero.Destino,
                            FechaHoraSalida = DateTime.Now.AddHours(2),
                            FechaHoraLlegada = DateTime.Now.AddHours(6)
                        };

                        dao.InsertarVueloSiNoExiste(vuelo);
                        dao.InsertarPasajero(pasajero, out int idPasajero);

                        string identificadorUnico = Guid.NewGuid().ToString("N").Substring(0, 13);

                        Boleto boleto = new Boleto
                        {
                            NumeroBoleto = identificadorUnico,
                            NumeroAsiento = pasajero.Asiento,
                            TieneMaleta = pasajero.NumeroMaletas > 0,
                            CheckInRealizado = false,
                            HaAbordado = false,
                            Pasajero = pasajero,
                            Vuelo = vuelo
                        };
                        boletosGuardados.Add(boleto);
                        dao.InsertarBoleto(boleto, idPasajero);
                    }
                    catch (Exception ex)
                    {
                        errores = true;
                        MessageBox.Show($"Error al guardar pasajero {pasajero.NombreCompleto}:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (!errores)
                {
                    MessageBox.Show("Todos los datos fueron guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pasajeros.Clear();
                    asientosSeleccionados = 0;
                    asientosASeleccionar = 0;
                    numAsientos.Value = 1;
                    //btntiket.Enabled = false;
                    btntiket.Enabled = boletosGuardados.Count > 0;
                    lnlPrecio.Text = "Total: $0.00";
                    lblCostoMaleta.Text = "Total por maletas: $0.00";
                    lblInstruccion.Text = "Ingrese cantidad de asientos";

                    asientosOcupados = dao.ObtenerAsientosOcupados("V123");
                    DibujarMapaAsientos();
                    lstPasajeros.DataSource = null;
                    lstPasajeros.DataSource = pasajeros;
                    lstPasajeros.DisplayMember = "Descripcion";
                    lstPasajeros.ValueMember = "Asiento";
                    lstPasajeros.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido de asientos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Manda a imprimir directamente los boletos con los datos de los pasagero(s)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntiket_Click(object sender, EventArgs e)
        {
            if (boletosGuardados.Count == 0)
            {
                MessageBox.Show("No hay boletos disponibles para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsImprimirBoleto impresor = new clsImprimirBoleto(boletosGuardados);
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(impresor.Imprimir);

            PrintDialog dialogo = new PrintDialog
            {
                Document = pd,
                UseEXDialog = true
            };

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        #endregion

    }
}