using MySql.Data.MySqlClient;
using segundaDBFranco.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundaDBFranco.FORM
{
    public partial class Productos : Form
    {
        DataTable tb = new DataTable();
        public Productos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = Conexion.MiConexion();
            conexion.Open();
            string query = "SELECT * FROM tblproductos";

            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.ExecuteNonQuery();
            
            MySqlDataAdapter productos = new MySqlDataAdapter(cmd);
            productos.Fill(tb);
            dgvProducto.DataSource = tb;
            conexion.Close();
        }
    }
}
