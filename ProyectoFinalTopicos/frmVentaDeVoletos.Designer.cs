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
            this.panel2 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdAsientos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAsientos)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpPasajeros.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(397, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 339);
            this.panel1.TabIndex = 1;
            // 
            // lnlPrecio
            // 
            this.lnlPrecio.AutoSize = true;
            this.lnlPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlPrecio.Location = new System.Drawing.Point(558, 49);
            this.lnlPrecio.Name = "lnlPrecio";
            this.lnlPrecio.Size = new System.Drawing.Size(179, 31);
            this.lnlPrecio.TabIndex = 2;
            this.lnlPrecio.Text = "___________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio total";
            // 
            // btntiket
            // 
            this.btntiket.Location = new System.Drawing.Point(592, 99);
            this.btntiket.Name = "btntiket";
            this.btntiket.Size = new System.Drawing.Size(121, 38);
            this.btntiket.TabIndex = 4;
            this.btntiket.Text = "Ir al titet";
            this.btntiket.UseVisualStyleBackColor = true;
            this.btntiket.Click += new System.EventHandler(this.btntiket_Click);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(3, 5);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(257, 25);
            this.lblInstruccion.TabIndex = 5;
            this.lblInstruccion.Text = "Numero de Asientos a elegir\r\n";
            // 
            // numAsientos
            // 
            this.numAsientos.Location = new System.Drawing.Point(51, 33);
            this.numAsientos.Name = "numAsientos";
            this.numAsientos.Size = new System.Drawing.Size(120, 20);
            this.numAsientos.TabIndex = 6;
            // 
            // btnEstablecerAsientos
            // 
            this.btnEstablecerAsientos.Location = new System.Drawing.Point(420, 99);
            this.btnEstablecerAsientos.Name = "btnEstablecerAsientos";
            this.btnEstablecerAsientos.Size = new System.Drawing.Size(157, 38);
            this.btnEstablecerAsientos.TabIndex = 7;
            this.btnEstablecerAsientos.Text = "Confirmar Asientos";
            this.btnEstablecerAsientos.UseVisualStyleBackColor = true;
            this.btnEstablecerAsientos.Click += new System.EventHandler(this.btnEstablecerAsientos_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.Controls.Add(this.lblPrecioVuelo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblCostoMaleta);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btntiket);
            this.panel2.Controls.Add(this.btnEstablecerAsientos);
            this.panel2.Controls.Add(this.lnlPrecio);
            this.panel2.Controls.Add(this.numAsientos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblInstruccion);
            this.panel2.Location = new System.Drawing.Point(316, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 168);
            this.panel2.TabIndex = 8;
            // 
            // lblPrecioVuelo
            // 
            this.lblPrecioVuelo.AutoSize = true;
            this.lblPrecioVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVuelo.Location = new System.Drawing.Point(128, 90);
            this.lblPrecioVuelo.Name = "lblPrecioVuelo";
            this.lblPrecioVuelo.Size = new System.Drawing.Size(104, 31);
            this.lblPrecioVuelo.TabIndex = 12;
            this.lblPrecioVuelo.Text = "______";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio vuelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Maletas";
            // 
            // lblCostoMaleta
            // 
            this.lblCostoMaleta.AutoSize = true;
            this.lblCostoMaleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoMaleta.Location = new System.Drawing.Point(76, 121);
            this.lblCostoMaleta.Name = "lblCostoMaleta";
            this.lblCostoMaleta.Size = new System.Drawing.Size(104, 31);
            this.lblCostoMaleta.TabIndex = 9;
            this.lblCostoMaleta.Text = "______";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Montos extra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "Elige tus asientos";
            // 
            // grpPasajeros
            // 
            this.grpPasajeros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpPasajeros.Controls.Add(this.lblContadorPasageros);
            this.grpPasajeros.Controls.Add(this.btnEliminarPasajero);
            this.grpPasajeros.Controls.Add(this.btnMoverAsiento);
            this.grpPasajeros.Controls.Add(this.lstPasajeros);
            this.grpPasajeros.Location = new System.Drawing.Point(19, 63);
            this.grpPasajeros.Name = "grpPasajeros";
            this.grpPasajeros.Size = new System.Drawing.Size(229, 504);
            this.grpPasajeros.TabIndex = 10;
            this.grpPasajeros.TabStop = false;
            this.grpPasajeros.Text = "Lista de Pasageros ";
            // 
            // lblContadorPasageros
            // 
            this.lblContadorPasageros.AutoSize = true;
            this.lblContadorPasageros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorPasageros.Location = new System.Drawing.Point(54, 467);
            this.lblContadorPasageros.Name = "lblContadorPasageros";
            this.lblContadorPasageros.Size = new System.Drawing.Size(139, 29);
            this.lblContadorPasageros.TabIndex = 3;
            this.lblContadorPasageros.Text = "_________";
            // 
            // btnEliminarPasajero
            // 
            this.btnEliminarPasajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPasajero.Location = new System.Drawing.Point(47, 396);
            this.btnEliminarPasajero.Name = "btnEliminarPasajero";
            this.btnEliminarPasajero.Size = new System.Drawing.Size(116, 41);
            this.btnEliminarPasajero.TabIndex = 2;
            this.btnEliminarPasajero.Text = "Eliminar pasagero";
            this.btnEliminarPasajero.UseVisualStyleBackColor = true;
            this.btnEliminarPasajero.Click += new System.EventHandler(this.btnEliminarPasajero_Click);
            // 
            // btnMoverAsiento
            // 
            this.btnMoverAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverAsiento.Location = new System.Drawing.Point(47, 337);
            this.btnMoverAsiento.Name = "btnMoverAsiento";
            this.btnMoverAsiento.Size = new System.Drawing.Size(116, 35);
            this.btnMoverAsiento.TabIndex = 1;
            this.btnMoverAsiento.Text = "Mover Asiento";
            this.btnMoverAsiento.UseVisualStyleBackColor = true;
            this.btnMoverAsiento.Click += new System.EventHandler(this.btnMoverAsiento_Click);
            // 
            // lstPasajeros
            // 
            this.lstPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPasajeros.FormattingEnabled = true;
            this.lstPasajeros.ItemHeight = 24;
            this.lstPasajeros.Location = new System.Drawing.Point(6, 39);
            this.lstPasajeros.Name = "lstPasajeros";
            this.lstPasajeros.Size = new System.Drawing.Size(217, 268);
            this.lstPasajeros.TabIndex = 0;
            this.lstPasajeros.SelectedIndexChanged += new System.EventHandler(this.lstPasajeros_SelectedIndexChanged);
            // 
            // lblNombreVuelo
            // 
            this.lblNombreVuelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreVuelo.AutoSize = true;
            this.lblNombreVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVuelo.Location = new System.Drawing.Point(650, 29);
            this.lblNombreVuelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreVuelo.Name = "lblNombreVuelo";
            this.lblNombreVuelo.Size = new System.Drawing.Size(177, 29);
            this.lblNombreVuelo.TabIndex = 11;
            this.lblNombreVuelo.Text = "Nombre vuelo";
            // 
            // frmVentaDeVoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 588);
            this.Controls.Add(this.lblNombreVuelo);
            this.Controls.Add(this.grpPasajeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmVentaDeVoletos";
            this.Text = "frmVentaDeVoletos";
            this.Load += new System.EventHandler(this.frmVentaDeVoletos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAsientos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAsientos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpPasajeros.ResumeLayout(false);
            this.grpPasajeros.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
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
    }
}