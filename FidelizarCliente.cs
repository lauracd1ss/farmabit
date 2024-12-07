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
            // Asociar eventos a los controles programáticamente
            descuentosToolStripMenuItem.Click += descuentosToolStripMenuItem_Click;
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            comprasToolStripMenuItem.Click += comprasToolStripMenuItem_Click;
            ventasToolStripMenuItem1.Click += ventasToolStripMenuItem1_Click;
            cajaToolStripMenuItem.Click += cajaToolStripMenuItem_Click;
            fidelizacionClientesToolStripMenuItem.Click += fidelizacionClientesToolStripMenuItem_Click;
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click_1;
            compraToolStripMenuItem.Click += compraToolStripMenuItem_Click;
            productosToolStripMenuItem1.Click += productosToolStripMenuItem1_Click;
            proveedoresToolStripMenuItem1.Click += proveedoresToolStripMenuItem1_Click;
            ventasToolStripMenuItem2.Click += ventasToolStripMenuItem2_Click;
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            clientesToolStripMenuItem1.Click += clientesToolStripMenuItem1_Click;
            productosToolStripMenuItem2.Click += productosToolStripMenuItem2_Click;
            proveedoresToolStripMenuItem2.Click += proveedoresToolStripMenuItem2_Click;
            empleadosToolStripMenuItem1.Click += empleadosToolStripMenuItem1_Click;
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;



        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal dc = new FrmMenuPrincipal();
            dc.Show();
        }
        private void FidelizarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'boseDataSet2.Puntos_transacciones' Puede moverla o quitarla según sea necesario.
            this.puntos_transaccionesTableAdapter.Fill(this.boseDataSet2.Puntos_transacciones);

        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaComprasForm dc = new ConsultaComprasForm();
            dc.Show();
        }

        private void descuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_producto dc = new Mant_producto();
            dc.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClienteForm dc = new ClienteForm();
            dc.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpleadoForm dc = new EmpleadoForm();
            dc.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProveedorForm dc = new ProveedorForm();
            dc.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUsuario dc = new FormUsuario();
            dc.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComprasForm dc = new ComprasForm();
            dc.Show();

        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentasForm dc = new VentasForm();
            dc.Show();
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CajaForm dc = new CajaForm();
            dc.Show();
        }

        private void fidelizacionClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FidelizarCliente dc = new FidelizarCliente();
            dc.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPedidos dc = new FrmPedidos();
            dc.Show();
        }

        private void ventasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaVentasForm dc = new ConsultaVentasForm();
            dc.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaEmpleadoForm dc = new ConsultaEmpleadoForm();
            dc.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaProductoForm dc = new ConsultaProductoForm();
            dc.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaProveedorForm dc = new ConsultaProveedorForm();
            dc.Show();
        }

        private void ventasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaVentasForm dc = new ConsultaVentasForm();
            dc.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaUsuariosForm dc = new ConsultaUsuariosForm();
            dc.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteClienteForm dc = new ReporteClienteForm();
            dc.Show();
        }

        private void productosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteProductoForm dc = new ReporteProductoForm();
            dc.Show();
        }

        private void proveedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteProovedorForm dc = new ReporteProovedorForm();
            dc.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteEmpleadoForm dc = new ReporteEmpleadoForm();
            dc.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagosServiciosForm dc = new PagosServiciosForm();
            dc.Show();
        }

    }
}
