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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuario p = new Usuario();
            p.Show();
            this.Hide();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.Show();
            this.Hide();

        }
    }
}
