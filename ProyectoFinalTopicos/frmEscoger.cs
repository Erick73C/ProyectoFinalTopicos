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
    public partial class frmEscoger : Form
    {
        public frmEscoger()
        {
            InitializeComponent();
        }

        private void btnCancun_Click(object sender, EventArgs e)
        {
            frmventanaeleccion k = new frmventanaeleccion();
            k.ShowDialog();
        }
    }
}
