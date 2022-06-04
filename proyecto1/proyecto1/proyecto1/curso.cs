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
    public partial class curso : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
        public curso()
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            SqlCommand comando = new SqlCommand("Select * from curso", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            string query = "INSERT INTO curso (IDcurso,Tipo,Nombre,Fecha,Horario,IDinstructor) VALUES (@idcurso,@tipo,@nombre,@fecha,@horario,@idinst)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@idcurso", textBox1.Text);
            comando.Parameters.AddWithValue("@tipo", textBox2.Text);
            comando.Parameters.AddWithValue("@nombre", textBox3.Text);
            comando.Parameters.AddWithValue("@fecha", textBox4.Text);
            comando.Parameters.AddWithValue("@horario", textBox5.Text);
            comando.Parameters.AddWithValue("@idinst", cb3.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos añadidos correctamente");
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            string query = "DELETE FROM curso WHERE IDcurso=@ID";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@ID", textBox1.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Elemento eliminado");
        }

        private void curso_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT IDinstructor from instructor", conexion);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cb3.Items.Add(registro["IDinstructor"].ToString());

            }
            conexion.Close();




        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "UPDATE curso SET Tipo=@tipo, Nombre=@nombre, Fecha=@fecha, Horario=horario WHERE IDcurso=@id ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", textBox1.Text);
            comando.Parameters.AddWithValue("@tipo", textBox2.Text);
            comando.Parameters.AddWithValue("@nombre", textBox3.Text);
            comando.Parameters.AddWithValue("fecha", textBox4.Text);
            comando.Parameters.AddWithValue("horario", textBox4.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Datos modificados");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            SqlCommand comando = new SqlCommand("Select * from curso", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
    }
}
