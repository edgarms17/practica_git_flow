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
    public partial class inventario : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-5K1KRIC\\SQLEXPRESS; database=inventario ; integrated security = true");
        public inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-5K1KRIC\\SQLEXPRESS; database=inventario ; integrated security = true");
            SqlCommand comando = new SqlCommand("Select * from productos", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-5K1KRIC\\SQLEXPRESS; database=inventario ; integrated security = true");
            string query = "INSERT INTO productos (idproducto,nombre,cantidad,precio) VALUES (@idprod,@nomb,@cant,@prec)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);

           


            if (string.IsNullOrEmpty(textBox1.Text))
            {

                MessageBox.Show("Debe completar la informacion", "Campos vacíos.");

                return;

            }
            
            if (string.IsNullOrEmpty(textBox2.Text))
            {

                MessageBox.Show("Debe completar la informacion", "Campos vacíos.");

                return;

            }
          
            if (string.IsNullOrEmpty(textBox3.Text))
            {

                MessageBox.Show("Debe completar la informacion", "Campos vacíos.");

                return;

            }
            
            if (string.IsNullOrEmpty(textBox4.Text))
            {

                MessageBox.Show("Debe completar la informacion", "Campos vacíos.");

                return;

            }

            SqlCommand cm2 = new SqlCommand("Select idproducto from productos where idproducto=@id", conexion);
            cm2.Parameters.AddWithValue("@id", textBox1.Text);
            SqlDataReader myreader = cm2.ExecuteReader();

            if (myreader.Read())
            {
                conexion.Close();
                MessageBox.Show("El ID ya existe, por favor introduzca otro.", "Duplicado.");
            }
            else
            {
                conexion.Close();
                SqlCommand cm3 = new SqlCommand(query, conexion);
                cm3.Parameters.AddWithValue("@idprod", textBox1.Text);
                cm3.Parameters.AddWithValue("@nomb", textBox2.Text);

                cm3.Parameters.AddWithValue("@cant", textBox3.Text);
                cm3.Parameters.AddWithValue("@prec", textBox4.Text);
                conexion.Open();
                cm3.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Productos añadidos correctamente.", "Atención.");


            }



          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-5K1KRIC\\SQLEXPRESS; database=inventario ; integrated security = true");
            string query = "DELETE FROM productos WHERE idproducto=@ID";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            if (string.IsNullOrEmpty(textBox1.Text))
            {

                MessageBox.Show("Debe completar la informacion", "Campos vacíos.");

                return;

            }
            comando.Parameters.AddWithValue("@ID", textBox1.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Producto eliminado.","Atención.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT* FROM productos WHERE idproducto=@ID", conexion);
            if (string.IsNullOrEmpty(textBox1.Text))
            {

                MessageBox.Show("Debe completar la informacion", "Campos vacíos.");

                return;

            }
            comando.Parameters.AddWithValue("@ID", textBox1.Text);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textBox2.Text = registro["nombre"].ToString();
                textBox3.Text = registro["cantidad"].ToString();
                textBox4.Text = registro["precio"].ToString();


            }
            else
            {
                MessageBox.Show("No se encontro el producto.Intente de nuevo.","Atención.");
            }
            conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "UPDATE productos SET nombre=@nomb,cantidad=@cant,precio=@prec WHERE idproducto=@id ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            if (string.IsNullOrEmpty(textBox1.Text))
            {

                MessageBox.Show("Debe completar la informacion", "Campos vacíos.");

                return;

            }
            comando.Parameters.AddWithValue("@id", textBox1.Text);
            if (string.IsNullOrEmpty(textBox2.Text))
            {

                MessageBox.Show("Debe completar la informacion", "Campos vacíos.");

                return;

            }
            comando.Parameters.AddWithValue("@nomb", textBox2.Text);
            if (string.IsNullOrEmpty(textBox3.Text))
            {

                MessageBox.Show("Debe completar la informacion", "Campos vacíos.");

                return;

            }
            comando.Parameters.AddWithValue("@cant", textBox3.Text);
            if (string.IsNullOrEmpty(textBox4.Text))
            {

                MessageBox.Show("Debe completar la informacion", "Campos vacíos.");

                return;

            }
            comando.Parameters.AddWithValue("@prec", textBox4.Text);
           
            comando.ExecuteNonQuery();
            
            MessageBox.Show("Inventario modificado.","Inventario.");
            conexion.Close();
        }


        private void inventario_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Solo se aceptan valores numéricos.", "Error.");
                    e.Handled = true;
                }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Solo se aceptan valores numéricos.", "Error.");
                    e.Handled = true;
                }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Solo se aceptan valores numéricos.", "Error.");
                    e.Handled = true;
                }
        }
    }
}
