using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Sistema_Compra_Venta
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        public static MySqlConnection GetMySqlConnection() {

            string sql = "datasource=localhost;port=3306;username=root;password=Admin123;database=compraventa";
            MySqlConnection con = new MySqlConnection();
            try
            {
                con.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n"+ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            return con;
        }
        public static void AddUser(Usuario Usua)
        {
            string sql = "Insert into Usuario_table values(@Nombre_Usuario@Nombre@Apellido_Paterno@Apellido_Materno@Correo_Electronico@Telefono@País) ";
            MySqlConnection con = GetMySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nombre_Usuario", MySqlDbType.VarChar).Value=Usua.Name;
        }
    }
}
