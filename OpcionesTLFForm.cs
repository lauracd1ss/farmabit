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
    public partial class OpcionesTLFForm : Form
    {
        private string compania;
        public OpcionesTLFForm(string compania)
        {
            InitializeComponent();
            this.compania = compania;
        }

        private void btnrecarga_Click(object sender, EventArgs e)
        {
            AbrirFormularioRecarga();

        }

        private void btnpago_Click(object sender, EventArgs e)
        {
            AbrirFormularioPagoTelefono();

        }
        private void AbrirFormularioRecarga()
        {
            switch (compania)
            {
                case "Claro":
                    RecargaCLaroForm recargaClaro = new RecargaCLaroForm();
                    recargaClaro.ShowDialog();
                    break;

                case "Altice":
                    RecargaAlticeForm recargaAltice = new RecargaAlticeForm();
                    recargaAltice.ShowDialog();
                    break;

                case "Viva":
                    RecargaVivaForm recargaViva = new RecargaVivaForm();
                    recargaViva.ShowDialog();
                    break;

                default:
                    MessageBox.Show("Compañía no reconocida.");
                    break;
            }
        }

        private void AbrirFormularioPagoTelefono()
        {
            switch (compania)
            {
                case "Claro":
                    PagoTLFClaroForm pagoClaro = new PagoTLFClaroForm();
                    pagoClaro.ShowDialog();
                    break;

                case "Altice":
                    PagoTLFAlticeForm pagoAltice = new PagoTLFAlticeForm();
                    pagoAltice.ShowDialog();
                    break;

                case "Viva":
                    PagoTLFVivaForm pagoViva = new PagoTLFVivaForm();
                    pagoViva.ShowDialog();
                    break;

                default:
                    MessageBox.Show("Compañía no reconocida.");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagosServiciosForm opciones = new PagosServiciosForm();
            opciones.ShowDialog();
        }
    }
}
