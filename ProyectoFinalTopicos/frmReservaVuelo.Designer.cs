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
            this.lblDestino = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudMenores = new System.Windows.Forms.NumericUpDown();
            this.nudAdultos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblLlegada = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            this.gpbDestino.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Location = new System.Drawing.Point(-17, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2065, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnAsientos
            // 
            this.btnAsientos.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnAsientos.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsientos.ForeColor = System.Drawing.Color.White;
            this.btnAsientos.Location = new System.Drawing.Point(1012, 662);
            this.btnAsientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsientos.Name = "btnAsientos";
            this.btnAsientos.Size = new System.Drawing.Size(321, 81);
            this.btnAsientos.TabIndex = 1;
            this.btnAsientos.Text = "Escoger Asientos";
            this.btnAsientos.UseVisualStyleBackColor = false;
            this.btnAsientos.Click += new System.EventHandler(this.btnAsientos_Click);
            // 
            // gpbDestino
            // 
            this.gpbDestino.BackColor = System.Drawing.Color.White;
            this.gpbDestino.Controls.Add(this.cmbDestino);
            this.gpbDestino.Controls.Add(this.lblDestino);
            this.gpbDestino.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDestino.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gpbDestino.Location = new System.Drawing.Point(937, 150);
            this.gpbDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDestino.Name = "gpbDestino";
            this.gpbDestino.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDestino.Size = new System.Drawing.Size(503, 87);
            this.gpbDestino.TabIndex = 10;
            this.gpbDestino.TabStop = false;
            this.gpbDestino.Text = "Destino:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.ForeColor = System.Drawing.Color.Black;
            this.lblDestino.Location = new System.Drawing.Point(51, 31);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(144, 38);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "Destino";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblOrigen);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.groupBox1.Location = new System.Drawing.Point(360, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(503, 87);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origen:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.ForeColor = System.Drawing.Color.Black;
            this.lblOrigen.Location = new System.Drawing.Point(8, 31);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(214, 38);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "  C.d México";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblSalida);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.groupBox2.Location = new System.Drawing.Point(360, 283);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(503, 87);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salida";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.nudMenores);
            this.groupBox3.Controls.Add(this.nudAdultos);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.groupBox3.Location = new System.Drawing.Point(408, 425);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(968, 133);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pasajeros:";
            // 
            // nudMenores
            // 
            this.nudMenores.Location = new System.Drawing.Point(529, 64);
            this.nudMenores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudMenores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMenores.Name = "nudMenores";
            this.nudMenores.Size = new System.Drawing.Size(160, 29);
            this.nudMenores.TabIndex = 17;
            this.nudMenores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMenores.ValueChanged += new System.EventHandler(this.nudMenores_ValueChanged);
            // 
            // nudAdultos
            // 
            this.nudAdultos.Location = new System.Drawing.Point(201, 64);
            this.nudAdultos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudAdultos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdultos.Name = "nudAdultos";
            this.nudAdultos.Size = new System.Drawing.Size(160, 29);
            this.nudAdultos.TabIndex = 16;
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
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Adulto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(711, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menor";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.lblLlegada);
            this.groupBox4.Controls.Add(this.lblHorario);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.groupBox4.Location = new System.Drawing.Point(937, 283);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(503, 87);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Horario:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.Black;
            this.lblHorario.Location = new System.Drawing.Point(45, 31);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(150, 38);
            this.lblHorario.TabIndex = 1;
            this.lblHorario.Text = "Horario";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(216, 38);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(280, 31);
            this.cmbDestino.TabIndex = 1;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(224, 43);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(70, 23);
            this.lblSalida.TabIndex = 2;
            this.lblSalida.Text = "label4";
            // 
            // lblLlegada
            // 
            this.lblLlegada.AutoSize = true;
            this.lblLlegada.Location = new System.Drawing.Point(239, 43);
            this.lblLlegada.Name = "lblLlegada";
            this.lblLlegada.Size = new System.Drawing.Size(70, 23);
            this.lblLlegada.TabIndex = 3;
            this.lblLlegada.Text = "label4";
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnregresar.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.ForeColor = System.Drawing.Color.White;
            this.btnregresar.Location = new System.Drawing.Point(516, 662);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(321, 81);
            this.btnregresar.TabIndex = 14;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // frmReservaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbDestino);
            this.Controls.Add(this.btnAsientos);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReservaVuelo";
            this.Text = "Volaris";
            this.Load += new System.EventHandler(this.frmReservaVuelo_Load);
            this.gpbDestino.ResumeLayout(false);
            this.gpbDestino.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAsientos;
        private System.Windows.Forms.GroupBox gpbDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMenores;
        private System.Windows.Forms.NumericUpDown nudAdultos;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblLlegada;
        private System.Windows.Forms.Button btnregresar;
    }
}

