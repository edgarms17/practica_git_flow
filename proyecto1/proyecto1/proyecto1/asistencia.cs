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
    public partial class asistencia : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
        public asistencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void asistencia_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT IDdocente from docente", conexion);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cb4.Items.Add(registro["IDdocente"].ToString());

            }
            conexion.Close();

            SqlCommand comando2 = new SqlCommand("SELECT IDcurso from curso", conexion);
            conexion.Open();
            SqlDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                cb5.Items.Add(registro2["IDcurso"].ToString());

            }
            conexion.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            SqlCommand comando = new SqlCommand("Select * from asistencia", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            string query = "INSERT INTO asistencia (Fecha,IDdocente,IDcurso,Porcentaje) VALUES (@Fecha,@IDdocente,@IDcurso,@Porcentaje)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Fecha", textBox1.Text);
            comando.Parameters.AddWithValue("@IDdocente", cb4.Text);
            comando.Parameters.AddWithValue("@IDcurso", cb5.Text);
            comando.Parameters.AddWithValue("@Porcentaje", textBox4.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos añadidos correctamente");
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            string query = "DELETE FROM asistencia WHERE Fecha=@ID";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@ID", textBox1.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Elemento eliminado");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "UPDATE asistencia SET Porcentaje=@por WHERE Fecha=@id ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", textBox1.Text);
            comando.Parameters.AddWithValue("por", textBox4.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Datos modificados");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            SqlCommand comando = new SqlCommand("Select * from asistencia", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
    }
}
