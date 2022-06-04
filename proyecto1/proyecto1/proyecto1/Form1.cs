using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerró sesión con éxito.", " Cerrar sesión.");
            Form formulario = new login();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new inventario();
            //this.Hide();
            formulario.ShowDialog();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new cajeros();
            //this.Hide();
            formulario.ShowDialog();
            //this.Close();
        }
    }
}
