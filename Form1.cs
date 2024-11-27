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
    public partial class Form1 : Form
    {
        public static string UsuarioActual { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=MAOKI\\MSSQLSERVER2022;database=bose;integrated security=true");
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
                    Form2 vp = new Form2();
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
                    Form2 vp = new Form2();
                    vp.Show();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos.");
                }
                conexion.Close();
            
        }
    }
}
