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
    public partial class plazacs : Form
    {
        public plazacs()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            string query = "INSERT INTO plaza (IDplaza,tipo) VALUES (@idplaz,@tipo)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@idplaz", textBox1.Text);
            comando.Parameters.AddWithValue("@tipo", textBox2.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos añadidos correctamente");
            conexion.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            SqlCommand comando = new SqlCommand("Select * from plaza", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
    }
}
