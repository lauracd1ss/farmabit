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
        SqlConnection conexion = new SqlConnection("server=localhost\\MSSQLSERVER2022;database=bose;integrated security=true");
        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

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
            if (e.KeyChar == (char)13)
            {
                conexion.Open();
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
                conexion.Close();
            }
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            
                conexion.Open();
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
                conexion.Close();
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
