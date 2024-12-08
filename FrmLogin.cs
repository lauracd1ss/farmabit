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

namespace farmabit
{
    public partial class FrmLogin : Form
    {
        public static string UsuarioActual { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
        }
   
        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        public static class ConexionBD
        {
            private static readonly string cadenaConexion = "server=localhost\\MSSQLSERVER2022;database=bose;integrated security=true";
            private static SqlConnection conexion;

            public static SqlConnection ObtenerConexion()
            {
                if (conexion == null)
                {
                    conexion = new SqlConnection(cadenaConexion);
                }

                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }

                return conexion;
            }

            public static void CerrarConexion()
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtpass.Focus();
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Verificar si se presionó la tecla Enter
            {
                try
                {
                    SqlConnection conexion = ConexionBD.ObtenerConexion(); // Obtiene la conexión abierta
                    string consulta = "select * from Administracion.Usuario WHERE usuario='" + txtusuario.Text + "' AND password='" + txtpass.Text + "'";
                    SqlCommand ejecutar = new SqlCommand(consulta, conexion);
                    SqlDataReader dr = ejecutar.ExecuteReader();

                    if (dr.Read())
                    {
                        UsuarioActual = txtusuario.Text;
                        this.Hide();
                        FrmMenuPrincipal vp = new FrmMenuPrincipal();
                        vp.Show();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos.");
                    }

                    dr.Close(); // Cierra el SqlDataReader
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    ConexionBD.CerrarConexion(); // Cierra la conexión si ya no se usa
                }
            }
        }


        private void btnentrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = ConexionBD.ObtenerConexion();
                string consulta = "select * from Administracion.Usuario WHERE usuario='" + txtusuario.Text + "' AND password='" + txtpass.Text + "'";
                SqlCommand ejecutar = new SqlCommand(consulta, conexion);
                SqlDataReader dr = ejecutar.ExecuteReader();

                if (dr.Read())
                {
                    UsuarioActual = txtusuario.Text;
                    this.Hide();
                    FrmMenuPrincipal vp = new FrmMenuPrincipal();
                    vp.Show();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos.");
                }

                dr.Close(); // Asegúrate de cerrar el DataReader después de usarlo
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
