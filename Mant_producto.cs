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
    public partial class Mant_producto : Form
    {
        public Mant_producto()
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
            txtIdProducto.KeyPress += txtSoloNumeros_KeyPress;
            txtPrecioDetalle.KeyPress += txtSoloNumeros_KeyPress;
            txtCosto.KeyPress += txtSoloNumeros_KeyPress;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;




        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal dc = new FrmMenuPrincipal();
            dc.Show();
        }

        private void Mant_producto_Load(object sender, EventArgs e)
        {

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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya llenado al menos un campo necesario (ej. nombre)
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Por favor, ingresa un nombre de producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la conexión abierta
                SqlConnection conexion = ConexionBD.ObtenerConexion();

                // Consulta SQL para insertar un producto
                string consulta = @"
            INSERT INTO dbo.Producto (nombre, laboratorio, precio_detalle, costo, fechacaducidad, 
                                      Registro_sanitario, necesita_receta, estado, concentracion, presentacion)
            VALUES (@nombre, @laboratorio, @precio_detalle, @costo, @fechacaducidad, 
                    @Registro_sanitario, @necesita_receta, @estado, @concentracion, @presentacion)";

                // Crear el comando SQL
                SqlCommand comando = new SqlCommand(consulta, conexion);

                // Agregar los parámetros con los valores del formulario
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@laboratorio", txtLaboratorio.Text);
                comando.Parameters.AddWithValue("@precio_detalle", decimal.Parse(txtPrecioDetalle.Text));
                comando.Parameters.AddWithValue("@costo", decimal.Parse(txtCosto.Text));
                comando.Parameters.AddWithValue("@fechacaducidad", dtpFecha.Checked ? dtpFecha.Value.Date : (object)DBNull.Value);
                comando.Parameters.AddWithValue("@Registro_sanitario", txtRegistroSanitario.Text);

                // Obtener valor del RadioButton para necesita_receta (1 para Sí, 0 para No)
                comando.Parameters.AddWithValue("@necesita_receta", rbtnNecesitaRecetaSi.Checked ? 1 : 0);

                // Obtener valor del RadioButton para estado (1 para Activo, 0 para Inactivo)
                comando.Parameters.AddWithValue("@estado", rbtnActivo.Checked ? 1 : 0);

                comando.Parameters.AddWithValue("@concentracion", txtConcentracion.Text);
                comando.Parameters.AddWithValue("@presentacion", txtPresentacion.Text);

                // Ejecutar el comando
                int filasAfectadas = comando.ExecuteNonQuery();

                // Mostrar un mensaje de éxito
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Producto guardado exitosamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el producto.");
                }
            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                ConexionBD.CerrarConexion();
            }

        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFecha.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de caducidad no puede ser anterior a hoy.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Value = DateTime.Now.Date;
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya ingresado un nombre o ID para el producto
                if (string.IsNullOrWhiteSpace(txtNombre.Text) && string.IsNullOrWhiteSpace(txtIdProducto.Text))
                {
                    MessageBox.Show("Por favor, ingresa un nombre o ID de producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la conexión abierta
                SqlConnection conexion = ConexionBD.ObtenerConexion();

                // Consulta SQL para eliminar un producto
                string consulta = @"
            DELETE FROM dbo.Producto
            WHERE idproducto = @idproducto OR nombre = @nombre";

                // Crear el comando SQL
                SqlCommand comando = new SqlCommand(consulta, conexion);

                // Agregar los parámetros con los valores del formulario
                comando.Parameters.AddWithValue("@idproducto", string.IsNullOrWhiteSpace(txtIdProducto.Text) ? (object)DBNull.Value : txtIdProducto.Text);
                comando.Parameters.AddWithValue("@nombre", string.IsNullOrWhiteSpace(txtNombre.Text) ? (object)DBNull.Value : txtNombre.Text);

                // Ejecutar el comando
                int filasAfectadas = comando.ExecuteNonQuery();

                // Mostrar un mensaje de éxito
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Producto eliminado exitosamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto.");
                }
            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                ConexionBD.CerrarConexion();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Limpiar todos los TextBox
            txtNombre.Clear();
            txtLaboratorio.Clear();
            txtPrecioDetalle.Clear();
            txtCosto.Clear();
            txtRegistroSanitario.Clear();
            txtConcentracion.Clear();
            txtPresentacion.Clear();

            // Limpiar los controles DateTimePicker
            dtpFecha.Checked = false;

            // Limpiar los RadioButton
            rbtnNecesitaRecetaSi.Checked = false;
            rbtnNecesitaRecetaNo.Checked = false;
            rbtnActivo.Checked = false;
            rbtnDesactivo.Checked = false;

            // Opcionalmente, puedes agregar un mensaje de éxito o información
            MessageBox.Show("Campos limpiados correctamente.");
        }
    }
}
