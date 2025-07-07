namespace ProyectoFinalTopicos
{
    partial class frmDatosPasajero
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
            this.components = new System.ComponentModel.Container();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.cbxOrigen = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblNombrePasagero = new System.Windows.Forms.Label();
            this.lblAsiento = new System.Windows.Forms.Label();
            this.lblCostoMaletas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnoPasaporte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericNumeroMaletas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoPasageri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePasagero = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errNoPasaporte = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNueroTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errApellidos = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDescuentoMenor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeroMaletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNoPasaporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNueroTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errApellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNombre)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDestino
            // 
            this.cbxDestino.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDestino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(74, 60);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(356, 55);
            this.cbxDestino.TabIndex = 0;
            this.cbxDestino.SelectedIndexChanged += new System.EventHandler(this.cbxDestino_SelectedIndexChanged);
            // 
            // cbxOrigen
            // 
            this.cbxOrigen.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrigen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxOrigen.FormattingEnabled = true;
            this.cbxOrigen.Items.AddRange(new object[] {
            "Ciudad de México (MEX)"});
            this.cbxOrigen.Location = new System.Drawing.Point(112, 60);
            this.cbxOrigen.Name = "cbxOrigen";
            this.cbxOrigen.Size = new System.Drawing.Size(284, 55);
            this.cbxOrigen.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblMenor);
            this.panel1.Controls.Add(this.lblNombrePasagero);
            this.panel1.Controls.Add(this.lblAsiento);
            this.panel1.Location = new System.Drawing.Point(252, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 59);
            this.panel1.TabIndex = 2;
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMenor.Location = new System.Drawing.Point(687, 14);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(84, 24);
            this.lblMenor.TabIndex = 19;
            this.lblMenor.Text = "(Menor)";
            this.lblMenor.Visible = false;
            // 
            // lblNombrePasagero
            // 
            this.lblNombrePasagero.AutoSize = true;
            this.lblNombrePasagero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePasagero.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNombrePasagero.Location = new System.Drawing.Point(387, 14);
            this.lblNombrePasagero.Name = "lblNombrePasagero";
            this.lblNombrePasagero.Size = new System.Drawing.Size(172, 24);
            this.lblNombrePasagero.TabIndex = 18;
            this.lblNombrePasagero.Text = "Nombre Pasajero";
            // 
            // lblAsiento
            // 
            this.lblAsiento.AutoSize = true;
            this.lblAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAsiento.Location = new System.Drawing.Point(77, 14);
            this.lblAsiento.Name = "lblAsiento";
            this.lblAsiento.Size = new System.Drawing.Size(188, 24);
            this.lblAsiento.TabIndex = 17;
            this.lblAsiento.Text = "Número de asiento";
            // 
            // lblCostoMaletas
            // 
            this.lblCostoMaletas.AutoSize = true;
            this.lblCostoMaletas.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoMaletas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCostoMaletas.Location = new System.Drawing.Point(40, 231);
            this.lblCostoMaletas.Name = "lblCostoMaletas";
            this.lblCostoMaletas.Size = new System.Drawing.Size(101, 23);
            this.lblCostoMaletas.TabIndex = 15;
            this.lblCostoMaletas.Text = "_______";
            this.lblCostoMaletas.Click += new System.EventHandler(this.lblCostoMaletas_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(40, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Número de Pasaporte ";
            // 
            // txtnoPasaporte
            // 
            this.txtnoPasaporte.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoPasaporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtnoPasaporte.Location = new System.Drawing.Point(44, 175);
            this.txtnoPasaporte.Name = "txtnoPasaporte";
            this.txtnoPasaporte.Size = new System.Drawing.Size(192, 26);
            this.txtnoPasaporte.TabIndex = 13;
            this.txtnoPasaporte.Leave += new System.EventHandler(this.txtnoPasaporte_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSlateGray;
            this.label7.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(216, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Destino";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSlateGray;
            this.label6.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(191, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Origen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(471, 74);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datos del usuario ";
            // 
            // numericNumeroMaletas
            // 
            this.numericNumeroMaletas.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNumeroMaletas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericNumeroMaletas.Location = new System.Drawing.Point(236, 260);
            this.numericNumeroMaletas.Name = "numericNumeroMaletas";
            this.numericNumeroMaletas.Size = new System.Drawing.Size(85, 26);
            this.numericNumeroMaletas.TabIndex = 9;
            this.numericNumeroMaletas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNumeroMaletas.ValueChanged += new System.EventHandler(this.numericNumeroMaletas_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(20, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número de maletas:";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNumeroTelefono.Location = new System.Drawing.Point(236, 218);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(271, 26);
            this.txtNumeroTelefono.TabIndex = 7;
            this.txtNumeroTelefono.Leave += new System.EventHandler(this.txtNumeroTelefono_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(16, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número de teléfono:";
            // 
            // txtApellidoPasageri
            // 
            this.txtApellidoPasageri.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPasageri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtApellidoPasageri.Location = new System.Drawing.Point(236, 175);
            this.txtApellidoPasageri.Name = "txtApellidoPasageri";
            this.txtApellidoPasageri.Size = new System.Drawing.Size(271, 26);
            this.txtApellidoPasageri.TabIndex = 5;
            this.txtApellidoPasageri.Leave += new System.EventHandler(this.txtApellidoPasageri_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(118, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(127, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre: ";
            // 
            // txtNombrePasagero
            // 
            this.txtNombrePasagero.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePasagero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombrePasagero.Location = new System.Drawing.Point(236, 131);
            this.txtNombrePasagero.Name = "txtNombrePasagero";
            this.txtNombrePasagero.Size = new System.Drawing.Size(271, 26);
            this.txtNombrePasagero.TabIndex = 2;
            this.txtNombrePasagero.Leave += new System.EventHandler(this.txtNombrePasagero_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.BackColor = System.Drawing.Color.SlateGray;
            this.btnAceptar.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(552, 550);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(185, 49);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Confirmar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.SlateGray;
            this.btnCancelar.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(759, 550);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(185, 49);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // errNoPasaporte
            // 
            this.errNoPasaporte.ContainerControl = this;
            // 
            // errNueroTelefono
            // 
            this.errNueroTelefono.ContainerControl = this;
            // 
            // errApellidos
            // 
            this.errApellidos.ContainerControl = this;
            // 
            // errNombre
            // 
            this.errNombre.ContainerControl = this;
            // 
            // lblDescuentoMenor
            // 
            this.lblDescuentoMenor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescuentoMenor.AutoSize = true;
            this.lblDescuentoMenor.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentoMenor.Location = new System.Drawing.Point(1000, 574);
            this.lblDescuentoMenor.Name = "lblDescuentoMenor";
            this.lblDescuentoMenor.Size = new System.Drawing.Size(117, 25);
            this.lblDescuentoMenor.TabIndex = 20;
            this.lblDescuentoMenor.Text = "_______";
            this.lblDescuentoMenor.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1372, 74);
            this.panel2.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxOrigen);
            this.groupBox1.Controls.Add(this.txtNombrePasagero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApellidoPasageri);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumeroTelefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericNumeroMaletas);
            this.groupBox1.Location = new System.Drawing.Point(184, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 315);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbxDestino);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblCostoMaletas);
            this.groupBox2.Controls.Add(this.txtnoPasaporte);
            this.groupBox2.Location = new System.Drawing.Point(851, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 315);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProyectoFinalTopicos.Properties.Resources.Captura_de_pantalla_2025_07_07_030405;
            this.pictureBox6.Location = new System.Drawing.Point(0, 596);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1372, 124);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_destino_1001;
            this.pictureBox5.Location = new System.Drawing.Point(159, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_virus_search_641;
            this.pictureBox4.Location = new System.Drawing.Point(131, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_adolescente_80;
            this.pictureBox3.Location = new System.Drawing.Point(620, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_asiento_80__1_;
            this.pictureBox2.Location = new System.Drawing.Point(330, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_pasajero_80;
            this.pictureBox1.Location = new System.Drawing.Point(20, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmDatosPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDescuentoMenor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel1);
            this.Name = "frmDatosPasajero";
            this.Text = "frmDatosPasajero";
            this.Load += new System.EventHandler(this.frmDatosPasajero_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeroMaletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNoPasaporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNueroTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errApellidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNombre)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.ComboBox cbxOrigen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombrePasagero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoPasageri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericNumeroMaletas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnoPasaporte;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCostoMaletas;
        private System.Windows.Forms.Label lblAsiento;
        private System.Windows.Forms.Label lblNombrePasagero;
        private System.Windows.Forms.ErrorProvider errNoPasaporte;
        private System.Windows.Forms.ErrorProvider errNueroTelefono;
        private System.Windows.Forms.ErrorProvider errApellidos;
        private System.Windows.Forms.ErrorProvider errNombre;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblDescuentoMenor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}