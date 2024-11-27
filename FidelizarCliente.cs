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
    public partial class FidelizarCliente : Form
    {
        public FidelizarCliente()
        {
            InitializeComponent();
        }

        private void FidelizarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'boseDataSet2.Puntos_transacciones' Puede moverla o quitarla según sea necesario.
            this.puntos_transaccionesTableAdapter.Fill(this.boseDataSet2.Puntos_transacciones);

        }
    }
}
