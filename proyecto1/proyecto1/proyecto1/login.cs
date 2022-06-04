using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyecto1
{
    public partial class login : Form
    {
        SqlConnection coneccion;
        SqlCommand comando;
        SqlDataReader dr;
        public login()
        {
            InitializeComponent();
            coneccion = new SqlConnection("server=DESKTOP-5K1KRIC\\SQLEXPRESS; Initial Catalog=usuarios;Integrated Security=SSPI");
            //\MSSQLSERVER01
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (textBox2.PasswordChar == '*')
                {
                    textBox2.PasswordChar = '\0';
                }
            }
            else
            {
                textBox2.PasswordChar = '*';
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            comando = new SqlCommand();
            coneccion.Open();
            comando.Connection = coneccion;
            comando.CommandText = "SELECT * FROM administrador where usuario='" + textBox1.Text + "' AND contraseña='" + textBox2.Text + "'";
            dr = comando.ExecuteReader();
            if (dr.Read())
            {

                MessageBox.Show("Se inició sesión con éxito.","Inicio de sesión.");
                Form formulario = new Form1();
                this.Hide();
                formulario.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Los datos son incorrectos, revise usuario y contraseña nuevamente.","Inicio de sesión.");
            }
            coneccion.Close();      

        }

        private void login_Load(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new logincajero();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
