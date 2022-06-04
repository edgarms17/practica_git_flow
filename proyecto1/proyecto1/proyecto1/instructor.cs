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
    public partial class instructor : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
        
        public instructor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            SqlCommand comando = new SqlCommand("Select * from instructor", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

        }

        private void instructor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            string query = "INSERT INTO instructor (IDinstructor,Escuela,CV) VALUES (@idins,@esc,@cv)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@idins", textBox1.Text);
            comando.Parameters.AddWithValue("@esc", textBox2.Text);
            comando.Parameters.AddWithValue("@cv", textBox3.Text);           
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos añadidos correctamente");
            conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            string query = "DELETE FROM instructor WHERE IDinstructor=@ID";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@ID", textBox1.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Elemento eliminado");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
        {

            SqlCommand comando = new SqlCommand("SELECT* FROM instructor WHERE idinstructor=@ID", conexion);
            comando.Parameters.AddWithValue("@ID", textBox1.Text);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textBox2.Text = registro["Escuela"].ToString();
                textBox3.Text = registro["CV"].ToString();

            }
            else
            {
                MessageBox.Show("No se encontro elemento.Intente de nuevo.");
            }
            conexion.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string query = "UPDATE instructor SET Escuela=@esc, CV=@cv WHERE IDinstructor=@id ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", textBox1.Text);
            comando.Parameters.AddWithValue("@esc", textBox2.Text);
            comando.Parameters.AddWithValue("@cv", textBox3.Text);  
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Datos modificados");


        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            SqlCommand comando = new SqlCommand("Select * from instructor", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
    }
}
