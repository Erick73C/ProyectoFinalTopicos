namespace ReservaVuelo
{
    partial class frmReservaVuelo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAsientos = new System.Windows.Forms.Button();
            this.gpbDestino = new System.Windows.Forms.GroupBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudMenores = new System.Windows.Forms.NumericUpDown();
            this.nudAdultos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblLlegada = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gpbDestino.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 83);
            this.panel1.TabIndex = 0;
            // 
            // btnAsientos
            // 
            this.btnAsientos.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnAsientos.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsientos.ForeColor = System.Drawing.Color.Purple;
            this.btnAsientos.Location = new System.Drawing.Point(1069, 590);
            this.btnAsientos.Name = "btnAsientos";
            this.btnAsientos.Size = new System.Drawing.Size(241, 66);
            this.btnAsientos.TabIndex = 1;
            this.btnAsientos.Text = "Escoger Asientos";
            this.btnAsientos.UseVisualStyleBackColor = false;
            this.btnAsientos.Click += new System.EventHandler(this.btnAsientos_Click);
            // 
            // gpbDestino
            // 
            this.gpbDestino.BackColor = System.Drawing.Color.DarkMagenta;
            this.gpbDestino.Controls.Add(this.pictureBox9);
            this.gpbDestino.Controls.Add(this.cmbDestino);
            this.gpbDestino.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDestino.ForeColor = System.Drawing.Color.White;
            this.gpbDestino.Location = new System.Drawing.Point(893, 217);
            this.gpbDestino.Name = "gpbDestino";
            this.gpbDestino.Size = new System.Drawing.Size(417, 85);
            this.gpbDestino.TabIndex = 10;
            this.gpbDestino.TabStop = false;
            this.gpbDestino.Text = "Destino:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino.ForeColor = System.Drawing.Color.Black;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(113, 29);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(285, 39);
            this.cmbDestino.TabIndex = 1;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkMagenta;
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.lblOrigen);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(487, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 85);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origen:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.ForeColor = System.Drawing.Color.White;
            this.lblOrigen.Location = new System.Drawing.Point(119, 29);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(214, 38);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "  C.d México";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkMagenta;
            this.groupBox2.Controls.Add(this.pictureBox10);
            this.groupBox2.Controls.Add(this.lblSalida);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(606, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 79);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salida:";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.ForeColor = System.Drawing.Color.White;
            this.lblSalida.Location = new System.Drawing.Point(83, 37);
            this.lblSalida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(79, 25);
            this.lblSalida.TabIndex = 2;
            this.lblSalida.Text = "label4";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkMagenta;
            this.groupBox3.Controls.Add(this.pictureBox8);
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.nudMenores);
            this.groupBox3.Controls.Add(this.nudAdultos);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(487, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(823, 129);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pasajeros:";
            // 
            // nudMenores
            // 
            this.nudMenores.ForeColor = System.Drawing.Color.Black;
            this.nudMenores.Location = new System.Drawing.Point(551, 49);
            this.nudMenores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMenores.Name = "nudMenores";
            this.nudMenores.Size = new System.Drawing.Size(120, 29);
            this.nudMenores.TabIndex = 17;
            this.nudMenores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMenores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMenores.ValueChanged += new System.EventHandler(this.nudMenores_ValueChanged);
            // 
            // nudAdultos
            // 
            this.nudAdultos.ForeColor = System.Drawing.Color.Black;
            this.nudAdultos.Location = new System.Drawing.Point(119, 50);
            this.nudAdultos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdultos.Name = "nudAdultos";
            this.nudAdultos.Size = new System.Drawing.Size(120, 29);
            this.nudAdultos.TabIndex = 16;
            this.nudAdultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAdultos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdultos.ValueChanged += new System.EventHandler(this.nudAdultos_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(245, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Adulto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(677, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menor";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkMagenta;
            this.groupBox4.Controls.Add(this.pictureBox11);
            this.groupBox4.Controls.Add(this.lblLlegada);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(989, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 79);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Horario:";
            // 
            // lblLlegada
            // 
            this.lblLlegada.AutoSize = true;
            this.lblLlegada.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlegada.ForeColor = System.Drawing.Color.White;
            this.lblLlegada.Location = new System.Drawing.Point(83, 37);
            this.lblLlegada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLlegada.Name = "lblLlegada";
            this.lblLlegada.Size = new System.Drawing.Size(79, 25);
            this.lblLlegada.TabIndex = 3;
            this.lblLlegada.Text = "label4";
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnregresar.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.ForeColor = System.Drawing.Color.Purple;
            this.btnregresar.Location = new System.Drawing.Point(729, 590);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(241, 66);
            this.btnregresar.TabIndex = 14;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(46, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 96);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mayores de 18 Años.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(629, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "De 3 a 17 Años.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 33.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(129, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 74);
            this.label5.TabIndex = 0;
            this.label5.Text = "Despegar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(229, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(672, 47);
            this.label6.TabIndex = 0;
            this.label6.Text = "¡Con tu Asistencia de viaje explora el mundo sin preocupaciones!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(293, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(507, 47);
            this.label7.TabIndex = 1;
            this.label7.Text = " Aprovecha tarifas especiales al realizar tu Vuelo";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::ProyectoFinalTopicos.Properties.Resources.Captura_de_pantalla_2025_07_07_023451;
            this.pictureBox12.Location = new System.Drawing.Point(46, 205);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(404, 468);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 18;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_maletín_150;
            this.pictureBox5.Location = new System.Drawing.Point(69, -6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(143, 106);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_tiempo_94;
            this.pictureBox11.Location = new System.Drawing.Point(12, 23);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(66, 50);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 26;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_niño_48;
            this.pictureBox8.Location = new System.Drawing.Point(454, 40);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(81, 73);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_hombre_con_barba_en_camiseta_verde_100;
            this.pictureBox6.Location = new System.Drawing.Point(6, 28);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(107, 95);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_destino_100;
            this.pictureBox9.Location = new System.Drawing.Point(24, 23);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(66, 56);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 24;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_menú_64;
            this.pictureBox4.Location = new System.Drawing.Point(1287, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_ayuda_48;
            this.pictureBox3.Location = new System.Drawing.Point(1198, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_avión_94;
            this.pictureBox2.Location = new System.Drawing.Point(23, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_virus_search_64;
            this.pictureBox7.Location = new System.Drawing.Point(47, 23);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(66, 56);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::ProyectoFinalTopicos.Properties.Resources.icons8_despegue_94;
            this.pictureBox10.Location = new System.Drawing.Point(12, 23);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(66, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 25;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProyectoFinalTopicos.Properties.Resources.photo_1516889782132_fb580815f8f9;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 749);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmReservaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAsientos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gpbDestino);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmReservaVuelo";
            this.Text = "Despegar";
            this.Load += new System.EventHandler(this.frmReservaVuelo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbDestino.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAsientos;
        private System.Windows.Forms.GroupBox gpbDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMenores;
        private System.Windows.Forms.NumericUpDown nudAdultos;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblLlegada;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}

