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
            this.lblDestino = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(-13, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnAsientos
            // 
            this.btnAsientos.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnAsientos.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsientos.ForeColor = System.Drawing.Color.White;
            this.btnAsientos.Location = new System.Drawing.Point(759, 538);
            this.btnAsientos.Name = "btnAsientos";
            this.btnAsientos.Size = new System.Drawing.Size(241, 66);
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
            this.gpbDestino.Location = new System.Drawing.Point(703, 122);
            this.gpbDestino.Name = "gpbDestino";
            this.gpbDestino.Size = new System.Drawing.Size(377, 71);
            this.gpbDestino.TabIndex = 10;
            this.gpbDestino.TabStop = false;
            this.gpbDestino.Text = "Destino:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(162, 31);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(211, 31);
            this.cmbDestino.TabIndex = 1;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.ForeColor = System.Drawing.Color.Black;
            this.lblDestino.Location = new System.Drawing.Point(38, 25);
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
            this.groupBox1.Location = new System.Drawing.Point(270, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 71);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origen:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.ForeColor = System.Drawing.Color.Black;
            this.lblOrigen.Location = new System.Drawing.Point(6, 25);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(214, 38);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "  C.d México";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblSalida);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.groupBox2.Location = new System.Drawing.Point(270, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 71);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salida:";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(45, 35);
            this.lblSalida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(70, 23);
            this.lblSalida.TabIndex = 2;
            this.lblSalida.Text = "label4";
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
            this.groupBox3.Location = new System.Drawing.Point(306, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(726, 108);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pasajeros:";
            // 
            // nudMenores
            // 
            this.nudMenores.Location = new System.Drawing.Point(397, 52);
            this.nudMenores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMenores.Name = "nudMenores";
            this.nudMenores.Size = new System.Drawing.Size(120, 29);
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
            this.nudAdultos.Location = new System.Drawing.Point(151, 52);
            this.nudAdultos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdultos.Name = "nudAdultos";
            this.nudAdultos.Size = new System.Drawing.Size(120, 29);
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
            this.label3.Location = new System.Drawing.Point(6, 52);
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
            this.label2.Location = new System.Drawing.Point(533, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menor";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.lblLlegada);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.groupBox4.Location = new System.Drawing.Point(703, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 71);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Horario:";
            // 
            // lblLlegada
            // 
            this.lblLlegada.AutoSize = true;
            this.lblLlegada.Location = new System.Drawing.Point(112, 35);
            this.lblLlegada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.btnregresar.Location = new System.Drawing.Point(387, 538);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(241, 66);
            this.btnregresar.TabIndex = 14;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // frmReservaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbDestino);
            this.Controls.Add(this.btnAsientos);
            this.Controls.Add(this.panel1);
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

