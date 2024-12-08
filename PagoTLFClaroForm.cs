using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace farmabit
{
    public partial class PagoTLFClaroForm : Form
    {
        public PagoTLFClaroForm()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=localhost\\MSSQLSERVER2022;database=bose;integrated security=true");

        private void PagoTLFClaroForm_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;

            lblfecha.Text = fechaActual.ToString("dd/MM/yyyy");
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

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (e.KeyChar == (char)13)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void limpiar_datos()
        {
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Focus();

        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                limpiar_datos();
                return;
            }

            string tlf = maskedTextBox1.Text;

            try
            {
                string consulta = "SELECT * FROM Administracion.FacturasServicios WHERE NumeroContrato = @TLF";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@TLF", tlf);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    textBox2.Text = reader["Titular"].ToString();
                    textBox3.Text = reader["MontoTotal"].ToString();
                }


                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el ID en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                limpiar_datos();
                return;
            }

            string tlf = maskedTextBox1.Text;

            try
            {
                string consulta = "SELECT * FROM Administracion.FacturasServicios WHERE NumeroContrato = @TLF";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@TLF", tlf);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    textBox2.Text = reader["Titular"].ToString();
                    textBox3.Text = reader["MontoTotal"].ToString();
                }


                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el ID en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DateTime fecha = DateTime.Now;
                conexion.Open();

                // Consulta para insertar datos y devolver el ID generado
                string consulta = @"
            INSERT INTO Administracion.FacturasServicios (Agencia, NumeroContrato, MontoTotal, FechaEmision, Titular) 
            OUTPUT INSERTED.IdFacturaServicio 
            VALUES (@Agencia, @NumeroContrato, @MontoTotal, @FechaEmision, @Titular)";

                SqlCommand ejecutar = new SqlCommand(consulta, conexion);

                // Reemplazar parámetros con valores
                ejecutar.Parameters.AddWithValue("@Agencia", txtag.Text ?? string.Empty);
                ejecutar.Parameters.AddWithValue("@NumeroContrato", maskedTextBox1.Text ?? string.Empty);
                ejecutar.Parameters.AddWithValue("@MontoTotal", textBox3.Text ?? string.Empty);
                // Validación de nullMontoTotal
                ejecutar.Parameters.AddWithValue("@FechaEmision", fecha);
                ejecutar.Parameters.AddWithValue("@Titular", textBox2.Text ?? string.Empty);

                // Ejecutar consulta y obtener el ID del registro insertado
                int idInsertado = (int)ejecutar.ExecuteScalar();

                //MessageBox.Show("Registro Insertado Correctamente. ID: " + idInsertado);

                // Limpiar los campos
                maskedTextBox1.Clear();
                textBox3.Clear();
                textBox2.Clear();

                // Generar la factura
                ImprimirFactura(idInsertado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el registro: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void ImprimirFactura(int idRegistro)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Consulta para recuperar los datos del registro
                string consulta = "SELECT * FROM Administracion.FacturasServicios WHERE IdFacturaServicio = @ID";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@ID", idRegistro);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Generar un texto para la factura
                    string factura = "===== FACTURA =====\n";
                    // factura += "IdrecargaServicio: " + reader["IdrecargaServicio"].ToString() + "\n";
                    factura += "Agencia: " + reader["Agencia"].ToString() + "\n";
                    factura += "NumeroContrato: " + reader["NumeroContrato"].ToString() + "\n";
                    factura += "MontoTotal: " + reader["MontoTotal"].ToString() + "\n";
                    factura += "FechaEmision: " + reader["FechaEmision"].ToString() + "\n";
                    factura += "Titular: " + reader["Titular"].ToString() + "\n";
                    factura += "====================";

                    MessageBox.Show(factura, "Factura Generada");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la factura: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        }
}
