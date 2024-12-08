using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static farmabit.FrmLogin;

namespace farmabit
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
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

        public TextBox txtCalleCliente { get { return txtcalle; } }
public TextBox txtCasaCliente { get { return txtcasa; } }
public ComboBox comboSectorCliente { get { return combosec; } }
public ComboBox comboMunicipioCliente { get { return combomun; } }
public ComboBox comboProvinciaCliente { get { return comboprov; } }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal dc = new FrmMenuPrincipal();
            dc.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }


        private SqlConnection connection;
        private void ClienteForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'boseDataSet6.Municipio' table. You can move, or remove it, as needed.
            this.municipioTableAdapter.Fill(this.boseDataSet6.Municipio);
            // TODO: This line of code loads data into the 'dSProvincia.Provincia' table. You can move, or remove it, as needed.
            this.provinciaTableAdapter.Fill(this.dSProvincia.Provincia);


            try
            {
                // Inicializa la conexión
                connection = ConexionBD.ObtenerConexion();

           

                // Cargar datos iniciales para Provincias
                CargarProvincias();

                // Configurar eventos de selección
                comboprov.SelectedIndexChanged += comboprov_SelectedIndexChanged;
                combomun.SelectedIndexChanged += combomun_SelectedIndexChanged;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }

        private void CargarProvincias()
        {
            string queryProvincias = "SELECT idprov, nombre FROM dbo.Provincia";
            SqlDataAdapter adapter = new SqlDataAdapter(queryProvincias, connection);
            DataTable provincias = new DataTable();
            adapter.Fill(provincias);

            comboprov.DataSource = provincias;
            comboprov.DisplayMember = "nombre";
            comboprov.ValueMember = "idprov";
            comboprov.SelectedIndex = -1; // Desmarcar selección inicial
        }

        private void CargarMunicipios(int provinciaId)
        {
            string queryMunicipios = "SELECT idmuni, nombre FROM dbo.Municipio WHERE idprov_Provincia = @idprov";
            SqlCommand cmd = new SqlCommand(queryMunicipios, connection);
            cmd.Parameters.AddWithValue("@idprov", provinciaId);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable municipios = new DataTable();
            adapter.Fill(municipios);

            combomun.DataSource = municipios;
            combomun.DisplayMember = "nombre";
            combomun.ValueMember = "idmuni";
            combomun.Enabled = true;
            combomun.SelectedIndex = -1; // Desmarcar selección inicial

            combosec.DataSource = null; // Limpiar ComboBox dependiente
        }

        private void CargarSectores(int municipioId)
        {
            string querySectores = "SELECT idsector, nombre FROM dbo.Sector WHERE idmuni_Municipio = @idmuni";
            SqlCommand cmd = new SqlCommand(querySectores, connection);
            cmd.Parameters.AddWithValue("@idmuni", municipioId);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable sectores = new DataTable();
            adapter.Fill(sectores);

            combosec.DataSource = sectores;
            combosec.DisplayMember = "nombre";
            combosec.ValueMember = "idsector";
            combosec.Enabled = sectores.Rows.Count > 0; // Habilitar solo si hay datos
            if (sectores.Rows.Count > 0)
            {
                combosec.SelectedIndex = 0; // Seleccionar automáticamente el primer elemento
            }
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.municipioTableAdapter.FillBy(this.boseDataSet6.Municipio);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void botonBuscarPersona_Click(object sender, EventArgs e)
        {
            
            personaForm dc = new personaForm();
            dc.Show();
        }

        private void botonBuscarDireccion_Click(object sender, EventArgs e)
        {

            direccionForm dc = new direccionForm();
            dc.Show();
        }

        private void comboprov_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboprov.SelectedValue != null && int.TryParse(comboprov.SelectedValue.ToString(), out int selectedProvId))
            {
                CargarMunicipios(selectedProvId);
            }
        }

        private void combomun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combomun.SelectedValue != null && int.TryParse(combomun.SelectedValue.ToString(), out int selectedMuniId))
            {
                CargarSectores(selectedMuniId);
            }
        }

        private void combosec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combomun.SelectedValue != null && int.TryParse(combomun.SelectedValue.ToString(), out int selectedMuniId))
            {
                CargarSectores(selectedMuniId);
            }
        }
    }
}
