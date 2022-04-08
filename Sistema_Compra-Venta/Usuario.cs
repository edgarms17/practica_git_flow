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

            string sql = "server=localhost;user id=root;persistsecurityinfo=True;password=Admin123;database=compraventa";
            MySqlConnection con = new MySqlConnection(sql);
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
        public static void AddUser(string Nombre_Usuario,string Nombre,string Apellido_Paterno, string Apellido_Materno,string Correo_Electronico,string Telefono,string Pais)
        {
            string sql = "Insert into usuario values(Null,@Nombre_Usuario,@Nombre,@Apellido_Paterno,@Apellido_Materno,@Correo_Electronico,@Telefono,@País) ";
            MySqlConnection con = GetMySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nombre_Usuario", MySqlDbType.VarChar).Value= Nombre_Usuario;
            cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = Nombre;
            cmd.Parameters.Add("@Apellido_Paterno", MySqlDbType.VarChar).Value = Apellido_Paterno;
            cmd.Parameters.Add("@Apellido_Materno", MySqlDbType.VarChar).Value = Apellido_Materno;
            cmd.Parameters.Add("@Correo_Electronico", MySqlDbType.VarChar).Value = Correo_Electronico;
            cmd.Parameters.Add("@Telefono", MySqlDbType.VarChar).Value = Telefono;
            cmd.Parameters.Add("@País", MySqlDbType.VarChar).Value = Pais;
            try {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateUser(string Nombre_Usuario, string Nombre, string Apellido_Paterno, string Apellido_Materno, string Correo_Electronico, string Telefono, string Pais)
        {
            string sql = "Update usuario Set Nombre_Usuario=@Nombre_Usuario,Nombre=@Nombre,Apellido_Paterno=@Apellido_Paterno," +
                "Apellido_Materno=@Apellido_Materno,Correo_Electronico=@Correo_Electronico,Telefono=@Telefono,País=@País)";
            MySqlConnection con = GetMySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nombre_Usuario", MySqlDbType.VarChar).Value = Nombre_Usuario;
            cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = Nombre;
            cmd.Parameters.Add("@Apellido_Paterno", MySqlDbType.VarChar).Value = Apellido_Paterno;
            cmd.Parameters.Add("@Apellido_Materno", MySqlDbType.VarChar).Value = Apellido_Materno;
            cmd.Parameters.Add("@Correo_Electronico", MySqlDbType.VarChar).Value = Correo_Electronico;
            cmd.Parameters.Add("@Telefono", MySqlDbType.VarChar).Value = Telefono;
            cmd.Parameters.Add("@País", MySqlDbType.VarChar).Value = Pais;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Nombre_Usuario = txtNombreuser.Text;
            string Nombre = txtNombre.Text;
            string Apellido_Paterno = txtAP.Text;
            string Apellido_Materno = txtAM.Text;
            string Correo_Electronico = txtmail.Text;
            string Telefono = txtTel.Text;
            string Pais = txtPais.Text;
            AddUser(Nombre_Usuario, Nombre, Apellido_Paterno, Apellido_Materno, Correo_Electronico, Telefono, Pais);
        }
    }
}
