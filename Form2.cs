using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmabit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label3.Text = "BIENVENID@ "+Form1.UsuarioActual;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Descuentos dc = new Descuentos();
            dc.Show();
        }
    }
}
