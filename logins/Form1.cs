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

namespace logins
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection coneccion = new SqlConnection("server=DESKTOP-SDSD7PR\\DORITO; database = login; integrated security = true");

        private void btnlogin_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            SqlCommand comando = new SqlCommand("select usuario, contraseña from pal  where usuario = @vusuario and contraseña = @vcontraseña",coneccion);
            comando.Parameters.AddWithValue("@vusuario", txtusuario.Text);
            comando.Parameters.AddWithValue("@vcontraseña", txtcontraseña.Text);
             


            SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                formulario pantalla = new formulario();
                pantalla.Show();
            } 
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
           registro lupa = new registro();
           lupa.Show();
        }
    }
}
