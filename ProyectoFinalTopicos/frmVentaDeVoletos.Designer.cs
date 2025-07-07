namespace ProyectoFinalTopicos
{
    partial class frmVentaDeVoletos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdAsientos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnlPrecio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntiket = new System.Windows.Forms.Button();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.numAsientos = new System.Windows.Forms.NumericUpDown();
            this.btnEstablecerAsientos = new System.Windows.Forms.Button();
            this.lblPrecioVuelo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCostoMaleta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPasajeros = new System.Windows.Forms.GroupBox();
            this.lblContadorPasageros = new System.Windows.Forms.Label();
            this.btnEliminarPasajero = new System.Windows.Forms.Button();
            this.btnMoverAsiento = new System.Windows.Forms.Button();
            this.lstPasajeros = new System.Windows.Forms.ListBox();
            this.lblNombreVuelo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAsientos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAsientos)).BeginInit();
            this.grpPasajeros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAsientos
            // 
            this.grdAsientos.AllowUserToAddRows = false;
            this.grdAsientos.AllowUserToResizeColumns = false;
            this.grdAsientos.AllowUserToResizeRows = false;
            this.grdAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAsientos.ColumnHeadersVisible = false;
            this.grdAsientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAsientos.Location = new System.Drawing.Point(0, 0);
            this.grdAsientos.Name = "grdAsientos";
            this.grdAsientos.ReadOnly = true;
            this.grdAsientos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdAsientos.RowHeadersVisible = false;
            this.grdAsientos.RowHeadersWidth = 51;
            this.grdAsientos.Size = new System.Drawing.Size(604, 339);
            this.grdAsientos.TabIndex = 0;
            this.grdAsientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAsientos_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.grdAsientos);
            this.panel1.Location = new System.Drawing.Point(568, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 339);
            this.panel1.TabIndex = 1;
            // 
            // lnlPrecio
            // 
            this.lnlPrecio.AutoSize = true;
            this.lnlPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lnlPrecio.Location = new System.Drawing.Point(278, 41);
            this.lnlPrecio.Name = "lnlPrecio";
            this.lnlPrecio.Size = new System.Drawing.Size(155, 25);
            this.lnlPrecio.TabIndex = 2;
            this.lnlPrecio.Text = "___________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio Total: ";
            // 
            // btntiket
            // 
            this.btntiket.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btntiket.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntiket.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btntiket.Location = new System.Drawing.Point(324, 86);
            this.btntiket.Name = "btntiket";
            this.btntiket.Size = new System.Drawing.Size(177, 60);
            this.btntiket.TabIndex = 4;
            this.btntiket.Text = "Ticket";
            this.btntiket.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btntiket.UseVisualStyleBackColor = false;
            this.btntiket.Click += new System.EventHandler(this.btntiket_Click);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.ForeColor = System.Drawing.Color.White;
            this.lblInstruccion.Location = new System.Drawing.Point(6, 12);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(347, 54);
            this.lblInstruccion.TabIndex = 5;
            this.lblInstruccion.Text = "Número de Asientos a Elegir\r\n";
            // 
            // numAsientos
            // 
            this.numAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAsientos.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numAsientos.Location = new System.Drawing.Point(359, 24);
            this.numAsientos.Name = "numAsientos";
            this.numAsientos.Size = new System.Drawing.Size(77, 26);
            this.numAsientos.TabIndex = 6;
            // 
            // btnEstablecerAsientos
            // 
            this.btnEstablecerAsientos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEstablecerAsientos.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstablecerAsientos.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEstablecerAsientos.Location = new System.Drawing.Point(25, 86);
            this.btnEstablecerAsientos.Name = "btnEstablecerAsientos";
            this.btnEstablecerAsientos.Size = new System.Drawing.Size(272, 60);
            this.btnEstablecerAsientos.TabIndex = 7;
            this.btnEstablecerAsientos.Text = "Confirmar Asientos";
            this.btnEstablecerAsientos.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEstablecerAsientos.UseVisualStyleBackColor = false;
            this.btnEstablecerAsientos.Click += new System.EventHandler(this.btnEstablecerAsientos_Click_1);
            // 
            // lblPrecioVuelo
            // 
            this.lblPrecioVuelo.AutoSize = true;
            this.lblPrecioVuelo.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVuelo.Location = new System.Drawing.Point(258, 86);
            this.lblPrecioVuelo.Name = "lblPrecioVuelo";
            this.lblPrecioVuelo.Size = new System.Drawing.Size(73, 43);
            this.lblPrecioVuelo.TabIndex = 12;
            this.lblPrecioVuelo.Text = "______";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(75, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 43);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio del vuelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(75, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 43);
            this.label5.TabIndex = 10;
            this.label5.Text = "Maletas:";
            // 
            // lblCostoMaleta
            // 
            this.lblCostoMaleta.AutoSize = true;
            this.lblCostoMaleta.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoMaleta.Location = new System.Drawing.Point(258, 129);
            this.lblCostoMaleta.Name = "lblCostoMaleta";
            this.lblCostoMaleta.Size = new System.Drawing.Size(73, 43);
            this.lblCostoMaleta.TabIndex = 9;
            this.lblCostoMaleta.Text = "______";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightBlue;
            this.label3.Location = new System.Drawing.Point(29, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 43);
            this.label3.TabIndex = 8;
            this.label3.Text = "Montos extra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Elige tus asientos";
            // 
            // grpPasajeros
            // 
            this.grpPasajeros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpPasajeros.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpPasajeros.Controls.Add(this.pictureBox6);
            this.grpPasajeros.Controls.Add(this.pictureBox3);
            this.grpPasajeros.Controls.Add(this.lblContadorPasageros);
            this.grpPasajeros.Controls.Add(this.btnEliminarPasajero);
            this.grpPasajeros.Controls.Add(this.btnMoverAsiento);
            this.grpPasajeros.Controls.Add(this.lstPasajeros);
            this.grpPasajeros.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPasajeros.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grpPasajeros.Location = new System.Drawing.Point(12, 90);
            this.grpPasajeros.Name = "grpPasajeros";
            this.grpPasajeros.Size = new System.Drawing.Size(329, 559);
            this.grpPasajeros.TabIndex = 10;
            this.grpPasajeros.TabStop = false;
            this.grpPasajeros.Text = "Lista de Pasajeros ";
            // 
            // lblContadorPasageros
            // 
            this.lblContadorPasageros.AutoSize = true;
            this.lblContadorPasageros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorPasageros.ForeColor = System.Drawing.Color.SlateGray;
            this.lblContadorPasageros.Location = new System.Drawing.Point(98, 499);
            this.lblContadorPasageros.Name = "lblContadorPasageros";
            this.lblContadorPasageros.Size = new System.Drawing.Size(129, 25);
            this.lblContadorPasageros.TabIndex = 3;
            this.lblContadorPasageros.Text = "_________";
            this.lblContadorPasageros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContadorPasageros.Click += new System.EventHandler(this.lblContadorPasageros_Click);
            // 
            // btnEliminarPasajero
            // 
            this.btnEliminarPasajero.BackColor = System.Drawing.Color.SlateGray;
            this.btnEliminarPasajero.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPasajero.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPasajero.Location = new System.Drawing.Point(42, 407);
            this.btnEliminarPasajero.Name = "btnEliminarPasajero";
            this.btnEliminarPasajero.Size = new System.Drawing.Size(244, 58);
            this.btnEliminarPasajero.TabIndex = 2;
            this.btnEliminarPasajero.Text = "Eliminar pasajero";
            this.btnEliminarPasajero.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEliminarPasajero.UseVisualStyleBackColor = false;
            this.btnEliminarPasajero.Click += new System.EventHandler(this.btnEliminarPasajero_Click);
            // 
            // btnMoverAsiento
            // 
            this.btnMoverAsiento.BackColor = System.Drawing.Color.SlateGray;
            this.btnMoverAsiento.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverAsiento.ForeColor = System.Drawing.Color.White;
            this.btnMoverAsiento.Location = new System.Drawing.Point(42, 327);
            this.btnMoverAsiento.Name = "btnMoverAsiento";
            this.btnMoverAsiento.Size = new System.Drawing.Size(244, 58);
            this.btnMoverAsiento.TabIndex = 1;
            this.btnMoverAsiento.Text = "Mover Asiento";
            this.btnMoverAsiento.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMoverAsiento.UseVisualStyleBackColor = false;
            this.btnMoverAsiento.Click += new System.EventHandler(this.btnMoverAsiento_Click);
            // 
            // lstPasajeros
            // 
            this.lstPasajeros.BackColor = System.Drawing.Color.White;
            this.lstPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPasajeros.FormattingEnabled = true;
            this.lstPasajeros.ItemHeight = 18;
            this.lstPasajeros.Location = new System.Drawing.Point(58, 38);
            this.lstPasajeros.Name = "lstPasajeros";
            this.lstPasajeros.Size = new System.Drawing.Size(217, 256);
            this.lstPasajeros.TabIndex = 0;
            this.lstPasajeros.SelectedIndexChanged += new System.EventHandler(this.lstPasajeros_SelectedIndexChanged);
            // 
            // lblNombreVuelo
            // 
            this.lblNombreVuelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreVuelo.AutoSize = true;
            this.lblNombreVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVuelo.ForeColor = System.Drawing.Color.White;
            this.lblNombreVuelo.Location = new System.Drawing.Point(798, 22);
            this.lblNombreVuelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreVuelo.Name = "lblNombreVuelo";
            this.lblNombreVuelo.Size = new System.Drawing.Size(142, 24);
            this.lblNombreVuelo.TabIndex = 11;
            this.lblNombreVuelo.Text = "Nombre vuelo";
            this.lblNombreVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.lnlPrecio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEstablecerAsientos);
            this.groupBox1.Controls.Add(this.btntiket);
            this.groupBox1.Location = new System.Drawing.Point(823, 476);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 173);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.lblPrecioVuelo);
            this.groupBox2.Controls.Add(this.numAsientos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblInstruccion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblCostoMaleta);
            this.groupBox2.Location = new System.Drawing.Point(347, 464);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 185);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox7.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_aplicación_taxi_car_cab_transport_vehicle_transport_services_18_50;
            this.pictureBox7.Location = new System.Drawing.Point(17, 132);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(52, 35);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox8.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_precio_64;
            this.pictureBox8.Location = new System.Drawing.Point(17, 86);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(52, 35);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox10.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_boleto_64;
            this.pictureBox10.Location = new System.Drawing.Point(342, 100);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(52, 35);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox9.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_confirmar_128;
            this.pictureBox9.Location = new System.Drawing.Point(42, 100);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(52, 35);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox6.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_eliminar_64__1_;
            this.pictureBox6.Location = new System.Drawing.Point(51, 419);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(52, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox3.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_asiento_80;
            this.pictureBox3.Location = new System.Drawing.Point(51, 338);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProyectoFinalTopicos.Properties.Resources.Captura_de_pantalla_2025_07_07_005150;
            this.pictureBox5.Location = new System.Drawing.Point(363, 405);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1016, 53);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoFinalTopicos.Properties.Resources.Captura_de_pantalla_2025_07_07_004338;
            this.pictureBox4.Location = new System.Drawing.Point(363, -3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1016, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalTopicos.Properties.Resources.Captura_de_pantalla_2025_07_07_004705;
            this.pictureBox1.Location = new System.Drawing.Point(363, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinalTopicos.Properties.Resources.Captura_de_pantalla_2025_07_07_004457;
            this.pictureBox2.Location = new System.Drawing.Point(1170, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 355);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // frmVentaDeVoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPasajeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblNombreVuelo);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Name = "frmVentaDeVoletos";
            this.Text = "frmVentaDeVoletos";
            this.Load += new System.EventHandler(this.frmVentaDeVoletos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAsientos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAsientos)).EndInit();
            this.grpPasajeros.ResumeLayout(false);
            this.grpPasajeros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAsientos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lnlPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntiket;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.NumericUpDown numAsientos;
        private System.Windows.Forms.Button btnEstablecerAsientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCostoMaleta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpPasajeros;
        private System.Windows.Forms.ListBox lstPasajeros;
        private System.Windows.Forms.Button btnEliminarPasajero;
        private System.Windows.Forms.Button btnMoverAsiento;
        private System.Windows.Forms.Label lblContadorPasageros;
        private System.Windows.Forms.Label lblNombreVuelo;
        private System.Windows.Forms.Label lblPrecioVuelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}