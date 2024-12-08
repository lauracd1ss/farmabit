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
    public partial class direccionForm : Form
    {
        public direccionForm()
        {
            InitializeComponent();
   
        


        }

        private SqlConnection connection;
        private void direccionForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Inicializa la conexión
                connection = ConexionBD.ObtenerConexion();

                // Cargar datos iniciales para el DataGridView
                CargarDirecciones();

                // Cargar datos iniciales para Provincias
                CargarProvincias();

                // Configurar eventos de selección
                comboprov.SelectedIndexChanged += comboprov_SelectedIndexChanged;
                combomun.SelectedIndexChanged += combomun_SelectedIndexChanged;
                combosec.SelectedIndexChanged += combosec_SelectedIndexChanged;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarDirecciones()
        {
            string query = @"
        SELECT 
            d.iddir,
            d.calle,
            d.casa,
            s.nombre AS Sector,
            m.nombre AS Municipio,
            p.nombre AS Provincia
        FROM 
            dbo.Direccion d
        JOIN 
            dbo.Sector s ON d.idsector_Sector = s.idsector
        JOIN 
            dbo.Municipio m ON s.idmuni_Municipio = m.idmuni
        JOIN 
            dbo.Provincia p ON m.idprov_Provincia = p.idprov;";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
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



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void combomun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combomun.SelectedValue != null && int.TryParse(combomun.SelectedValue.ToString(), out int selectedMuniId))
            {
                CargarSectores(selectedMuniId);
            }
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

        private void comboprov_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void comboprov_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboprov_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboprov.SelectedValue != null && int.TryParse(comboprov.SelectedValue.ToString(), out int selectedProvId))
            {
                CargarMunicipios(selectedProvId);
            }
        }

        private void combosec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combomun.SelectedValue != null && int.TryParse(combomun.SelectedValue.ToString(), out int selectedMuniId))
            {
                CargarSectores(selectedMuniId);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se hayan llenado los campos necesarios
                if (string.IsNullOrWhiteSpace(txtCalle.Text) || string.IsNullOrWhiteSpace(txtCasa.Text) ||
                    combosec.SelectedValue == null || combomun.SelectedValue == null || comboprov.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, completa todos los campos necesarios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la conexión abierta
                SqlConnection conexion = ConexionBD.ObtenerConexion();

                // Consulta SQL para insertar en Direccion
                string consultaInsert = @"
            INSERT INTO dbo.Direccion (calle, casa, idsector_Sector)
            VALUES (@calle, @casa, @idsector)";

                // Crear el comando SQL
                SqlCommand comandoInsert = new SqlCommand(consultaInsert, conexion);

                // Agregar los parámetros
                comandoInsert.Parameters.AddWithValue("@calle", txtCalle.Text.Trim());
                comandoInsert.Parameters.AddWithValue("@casa", txtCasa.Text.Trim());
                comandoInsert.Parameters.AddWithValue("@idsector", combosec.SelectedValue); // ID del sector seleccionado

                // Ejecutar el comando
                int filasAfectadas = comandoInsert.ExecuteNonQuery();

                // Mostrar un mensaje de éxito
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Dirección guardada exitosamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la dirección.");
                }
            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtCalle.Clear();
            txtCasa.Clear();

            // Restablecer los ComboBox a sus valores predeterminados
            combosec.SelectedIndex = -1;
            combomun.SelectedIndex = -1;
            comboprov.SelectedIndex = -1;

            // Mostrar un mensaje opcional para el usuario
            MessageBox.Show("Los datos han sido limpiados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no sea el encabezado
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                // Cargar datos en los TextBox
                txtCalle.Text = filaSeleccionada.Cells["calle"].Value.ToString();
                txtCasa.Text = filaSeleccionada.Cells["casa"].Value.ToString();

                // Buscar y seleccionar el valor en los ComboBox por nombre
                combosec.Text = filaSeleccionada.Cells["Sector"].Value.ToString();
                combomun.Text = filaSeleccionada.Cells["Municipio"].Value.ToString();
                comboprov.Text = filaSeleccionada.Cells["Provincia"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una referencia al formulario principal
            ClienteForm clienteForm = (ClienteForm)Application.OpenForms["ClienteForm"];

            if (clienteForm != null)
            {
                // Transferir datos al formulario principal
                clienteForm.txtCalleCliente.Text = txtCalle.Text;
                clienteForm.txtCasaCliente.Text = txtCasa.Text;
                clienteForm.comboSectorCliente.Text = combosec.Text;
                clienteForm.comboMunicipioCliente.Text = combomun.Text;
                clienteForm.comboProvinciaCliente.Text = comboprov.Text;
            }

            // Cerrar el formulario emergente
            this.Close();
        }
    }
}
