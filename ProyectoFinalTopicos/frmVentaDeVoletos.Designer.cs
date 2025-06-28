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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCostoMaleta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAsientos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAsientos)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.grdAsientos.Size = new System.Drawing.Size(604, 345);
            this.grdAsientos.TabIndex = 0;
            this.grdAsientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAsientos_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.grdAsientos);
            this.panel1.Location = new System.Drawing.Point(239, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 345);
            this.panel1.TabIndex = 1;
            // 
            // lnlPrecio
            // 
            this.lnlPrecio.AutoSize = true;
            this.lnlPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlPrecio.Location = new System.Drawing.Point(562, 23);
            this.lnlPrecio.Name = "lnlPrecio";
            this.lnlPrecio.Size = new System.Drawing.Size(84, 25);
            this.lnlPrecio.TabIndex = 2;
            this.lnlPrecio.Text = "______";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio total";
            // 
            // btntiket
            // 
            this.btntiket.Location = new System.Drawing.Point(592, 71);
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
            this.lblInstruccion.Location = new System.Drawing.Point(36, 23);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(127, 20);
            this.lblInstruccion.TabIndex = 5;
            this.lblInstruccion.Text = "NumeroAsientos";
            // 
            // numAsientos
            // 
            this.numAsientos.Location = new System.Drawing.Point(169, 21);
            this.numAsientos.Name = "numAsientos";
            this.numAsientos.Size = new System.Drawing.Size(120, 20);
            this.numAsientos.TabIndex = 6;
            // 
            // btnEstablecerAsientos
            // 
            this.btnEstablecerAsientos.Location = new System.Drawing.Point(429, 71);
            this.btnEstablecerAsientos.Name = "btnEstablecerAsientos";
            this.btnEstablecerAsientos.Size = new System.Drawing.Size(157, 38);
            this.btnEstablecerAsientos.TabIndex = 7;
            this.btnEstablecerAsientos.Text = "Confirmar Asientos";
            this.btnEstablecerAsientos.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblCostoMaleta);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btntiket);
            this.panel2.Controls.Add(this.btnEstablecerAsientos);
            this.panel2.Controls.Add(this.lnlPrecio);
            this.panel2.Controls.Add(this.numAsientos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblInstruccion);
            this.panel2.Location = new System.Drawing.Point(169, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 122);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Elige tus asientos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Montos extra";
            // 
            // lblCostoMaleta
            // 
            this.lblCostoMaleta.AutoSize = true;
            this.lblCostoMaleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoMaleta.Location = new System.Drawing.Point(121, 83);
            this.lblCostoMaleta.Name = "lblCostoMaleta";
            this.lblCostoMaleta.Size = new System.Drawing.Size(84, 25);
            this.lblCostoMaleta.TabIndex = 9;
            this.lblCostoMaleta.Text = "______";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Maletas";
            // 
            // frmVentaDeVoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 588);
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
    }
}