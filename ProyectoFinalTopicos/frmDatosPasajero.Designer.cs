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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeroMaletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNoPasaporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNueroTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errApellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDestino
            // 
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(470, 98);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(239, 21);
            this.cbxDestino.TabIndex = 0;
            // 
            // cbxOrigen
            // 
            this.cbxOrigen.FormattingEnabled = true;
            this.cbxOrigen.Items.AddRange(new object[] {
            "Ciudad de México (MEX)"});
            this.cbxOrigen.Location = new System.Drawing.Point(99, 98);
            this.cbxOrigen.Name = "cbxOrigen";
            this.cbxOrigen.Size = new System.Drawing.Size(239, 21);
            this.cbxOrigen.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblMenor);
            this.panel1.Controls.Add(this.lblNombrePasagero);
            this.panel1.Controls.Add(this.lblAsiento);
            this.panel1.Controls.Add(this.lblCostoMaletas);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtnoPasaporte);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericNumeroMaletas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNumeroTelefono);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtApellidoPasageri);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombrePasagero);
            this.panel1.Controls.Add(this.cbxOrigen);
            this.panel1.Controls.Add(this.cbxDestino);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 369);
            this.panel1.TabIndex = 2;
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.Location = new System.Drawing.Point(678, 13);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(105, 29);
            this.lblMenor.TabIndex = 19;
            this.lblMenor.Text = "(Menor)";
            this.lblMenor.Visible = false;
            // 
            // lblNombrePasagero
            // 
            this.lblNombrePasagero.AutoSize = true;
            this.lblNombrePasagero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePasagero.Location = new System.Drawing.Point(483, 13);
            this.lblNombrePasagero.Name = "lblNombrePasagero";
            this.lblNombrePasagero.Size = new System.Drawing.Size(226, 29);
            this.lblNombrePasagero.TabIndex = 18;
            this.lblNombrePasagero.Text = "Nombre Pasagero";
            // 
            // lblAsiento
            // 
            this.lblAsiento.AutoSize = true;
            this.lblAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento.Location = new System.Drawing.Point(347, 13);
            this.lblAsiento.Name = "lblAsiento";
            this.lblAsiento.Size = new System.Drawing.Size(235, 29);
            this.lblAsiento.TabIndex = 17;
            this.lblAsiento.Text = "Numero de asiento";
            // 
            // lblCostoMaletas
            // 
            this.lblCostoMaletas.AutoSize = true;
            this.lblCostoMaletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoMaletas.Location = new System.Drawing.Point(506, 319);
            this.lblCostoMaletas.Name = "lblCostoMaletas";
            this.lblCostoMaletas.Size = new System.Drawing.Size(89, 25);
            this.lblCostoMaletas.TabIndex = 15;
            this.lblCostoMaletas.Text = "_______";
            this.lblCostoMaletas.Click += new System.EventHandler(this.lblCostoMaletas_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(506, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Numero de Pasaporte ";
            // 
            // txtnoPasaporte
            // 
            this.txtnoPasaporte.Location = new System.Drawing.Point(539, 227);
            this.txtnoPasaporte.Name = "txtnoPasaporte";
            this.txtnoPasaporte.Size = new System.Drawing.Size(192, 20);
            this.txtnoPasaporte.TabIndex = 13;
            this.txtnoPasaporte.Leave += new System.EventHandler(this.txtnoPasaporte_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Destino";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Origen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 52);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datos del usuario ";
            // 
            // numericNumeroMaletas
            // 
            this.numericNumeroMaletas.Location = new System.Drawing.Point(218, 322);
            this.numericNumeroMaletas.Name = "numericNumeroMaletas";
            this.numericNumeroMaletas.Size = new System.Drawing.Size(120, 20);
            this.numericNumeroMaletas.TabIndex = 9;
            this.numericNumeroMaletas.ValueChanged += new System.EventHandler(this.numericNumeroMaletas_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero de maletas";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(246, 274);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(192, 20);
            this.txtNumeroTelefono.TabIndex = 7;
            this.txtNumeroTelefono.Leave += new System.EventHandler(this.txtNumeroTelefono_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero de telefono";
            // 
            // txtApellidoPasageri
            // 
            this.txtApellidoPasageri.Location = new System.Drawing.Point(218, 218);
            this.txtApellidoPasageri.Name = "txtApellidoPasageri";
            this.txtApellidoPasageri.Size = new System.Drawing.Size(192, 20);
            this.txtApellidoPasageri.TabIndex = 5;
            this.txtApellidoPasageri.Leave += new System.EventHandler(this.txtApellidoPasageri_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre: ";
            // 
            // txtNombrePasagero
            // 
            this.txtNombrePasagero.Location = new System.Drawing.Point(218, 164);
            this.txtNombrePasagero.Name = "txtNombrePasagero";
            this.txtNombrePasagero.Size = new System.Drawing.Size(192, 20);
            this.txtNombrePasagero.TabIndex = 2;
            this.txtNombrePasagero.Leave += new System.EventHandler(this.txtNombrePasagero_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(405, 405);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(176, 42);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Confirmar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(612, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(176, 42);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
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
            this.lblDescuentoMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentoMenor.Location = new System.Drawing.Point(29, 427);
            this.lblDescuentoMenor.Name = "lblDescuentoMenor";
            this.lblDescuentoMenor.Size = new System.Drawing.Size(89, 25);
            this.lblDescuentoMenor.TabIndex = 20;
            this.lblDescuentoMenor.Text = "_______";
            this.lblDescuentoMenor.Visible = false;
            // 
            // frmDatosPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
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
    }
}