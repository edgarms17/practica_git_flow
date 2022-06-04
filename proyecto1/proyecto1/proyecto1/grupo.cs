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
    public partial class grupo : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
        public grupo()
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
            SqlCommand comando = new SqlCommand("Select * from grupo", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            string query = "INSERT INTO grupo (IDgrupo,IDcurso,IDdocente,IDinstructor) VALUES (@idgrup,@idcurs,@iddoc,@idins)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@idgrup", textBox1.Text);
            comando.Parameters.AddWithValue("@idcurs", cb2.Text);
            comando.Parameters.AddWithValue("@iddoc", cb3.Text);
            comando.Parameters.AddWithValue("@idins", cb4.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos añadidos correctamente");
            conexion.Close();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            string query = "DELETE FROM grupo WHERE IDgrupo=@ID";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@ID", textBox1.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Elemento eliminado");
        }

        private void grupo_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT IDcurso from curso", conexion);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cb2.Items.Add(registro["IDcurso"].ToString());

            }
            conexion.Close();

            SqlCommand comando2 = new SqlCommand("SELECT IDdocente from docente", conexion);
            conexion.Open();
            SqlDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                cb3.Items.Add(registro2["IDdocente"].ToString());

            }
            conexion.Close();


            SqlCommand comando3 = new SqlCommand("SELECT IDinstructor from instructor", conexion);
            conexion.Open();
            SqlDataReader registro3 = comando3.ExecuteReader();
            while (registro3.Read())
            {
                cb4.Items.Add(registro3["IDinstructor"].ToString());

            }
            conexion.Close();








        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-7JOR8VU\\MSSQLSERVER01; database=info ; integrated security = true");
            SqlCommand comando = new SqlCommand("Select * from grupo", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
    }
}
