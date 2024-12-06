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
    public partial class REPORTECLIENTE : Form
    {
        public REPORTECLIENTE()
        {
            InitializeComponent();
        }

        private void REPORTECLIENTE_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
