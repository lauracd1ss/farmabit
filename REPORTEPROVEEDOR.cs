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
    public partial class REPORTEPROVEEDOR : Form
    {
        public REPORTEPROVEEDOR()
        {
            InitializeComponent();
        }

        private void REPORTEPROVEEDOR_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
