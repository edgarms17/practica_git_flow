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
using System.IO;
using System.Reflection;




namespace proyecto1
{
    public partial class vender : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-5K1KRIC\\SQLEXPRESS; database=inventario ; integrated security = true");
        public vender()
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

            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                dataGridView2.Columns.Add(c.Clone() as DataGridViewColumn);
            }

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                int index = dataGridView2.Rows.Add(r.Clone() as DataGridViewRow);
                foreach (DataGridViewCell o in r.Cells)
                {
                    dataGridView2.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                }
            }

            string query = "UPDATE productos SET cantidad=cantidad-1 WHERE idproducto=@id ";
            //conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            if (string.IsNullOrEmpty(textBox5.Text))
            {

                MessageBox.Show("Producto añadido a la canasta.");

                return;

            }
            comando.Parameters.AddWithValue("@id", textBox5.Text);
           
           
            comando.ExecuteNonQuery();

            MessageBox.Show("Inventario modificado.", "Vender.");
            conexion.Close();






        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        public double total = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {

                MessageBox.Show("Debe colocar el dinero recibido antes de continuar ", "Campos vacíos.");

                return;

            }
            
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                total += Convert.ToDouble(row.Cells["precio"].Value);
                textBox4.Text = Convert.ToString(total);
            }
            int cambio = Convert.ToInt32(textBox3.Text);
            int operacion = Convert.ToInt32(cambio - total);
            textBox2.Text = Convert.ToString(operacion);

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {



            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

            string query = "UPDATE productos SET cantidad=cantidad+1 WHERE idproducto=@id ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            if (string.IsNullOrEmpty(textBox5.Text))
            {

                MessageBox.Show("Producto eliminado de la canasta", "Atención.");

                return;

            }
            comando.Parameters.AddWithValue("@id", textBox5.Text);


            comando.ExecuteNonQuery();

            MessageBox.Show("Inventario modificado.", "Vender.");
            conexion.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter sW = new StreamWriter(@"D:\Log\archivo.txt");

            for (int row = 0; row < dataGridView2.Rows.Count-1; row++)
            {
                string lines = "";
                for (int col = 0; col < 3; col++)
                {
                    lines += (string.IsNullOrEmpty(lines) ? " " : ", ") + dataGridView2.Rows[row].Cells[col].Value.ToString();
                }

                sW.WriteLine(lines);

            }
            MessageBox.Show("Archivo listo para su impresión.","Impresión.");
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            sW.Close(); 


        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formulario = new clientes();
            formulario.ShowDialog();
            
        }

        private void vender_Load(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
