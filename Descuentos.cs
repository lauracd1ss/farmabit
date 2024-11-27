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
    public partial class Descuentos : Form
    {
        public Descuentos()
        {
            InitializeComponent();
        }

        private void Descuentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'boseDataSet.DescuentosPromociones' Puede moverla o quitarla según sea necesario.
            this.descuentosPromocionesTableAdapter.Fill(this.boseDataSet.DescuentosPromociones);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ConsultaDes_producto cp = new ConsultaDes_producto();
            cp.Show();
        }
    }
}
