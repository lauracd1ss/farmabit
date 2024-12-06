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
    public partial class REPORTEPRODUCTO : Form
    {
        public REPORTEPRODUCTO()
        {
            InitializeComponent();
        }

        private void REPORTEPRODUCTO_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
