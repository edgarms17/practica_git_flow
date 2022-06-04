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
    public partial class docentes : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
        public docentes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            SqlCommand comando = new SqlCommand("Select * from docente", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            string query = "INSERT INTO docente (IDdocente,telefono,correo,nombre,IDplaza,IDdep) VALUES (@iddoc,@tel,@correo,@nombre,@idplaz,@idep)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@iddoc", textBox1.Text);
            comando.Parameters.AddWithValue("@tel", textBox2.Text);
            comando.Parameters.AddWithValue("@correo", textBox3.Text);
            comando.Parameters.AddWithValue("@nombre", textBox4.Text);
            comando.Parameters.AddWithValue("@idplaz", cb1.Text);
           comando.Parameters.AddWithValue("@idep", cb2.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos añadidos correctamente");
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            string query = "DELETE FROM docente WHERE IDdocente=@ID";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@ID", textBox1.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Elemento eliminado");
        }

        private void docentes_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT IDplaza from plaza", conexion);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while(registro.Read())
            {
                cb1.Items.Add(registro["IDplaza"].ToString());
                
            }
            conexion.Close();

            SqlCommand comando2 = new SqlCommand("SELECT IDdep from departamento", conexion);
            conexion.Open();
            SqlDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                cb2.Items.Add(registro2["IDdep"].ToString());

            }
            conexion.Close();









        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "UPDATE docente SET telefono=@tel, correo=@corr, nombre=@nomb WHERE IDdocente=@id ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", textBox1.Text);
            comando.Parameters.AddWithValue("@tel", textBox2.Text);
            comando.Parameters.AddWithValue("@corr", textBox3.Text);
            comando.Parameters.AddWithValue("nomb", textBox4.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Datos modificados");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            SqlCommand comando = new SqlCommand("Select * from docente", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
    }
}
