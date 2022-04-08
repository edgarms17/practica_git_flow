using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Compra_Venta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Usuario p = new Usuario();
            p.Show();
            this.Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.Show();
            this.Hide();
        }
    }
}
