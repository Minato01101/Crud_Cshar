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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        //Tabla para extraer los datos
        DataTable tb = new DataTable();

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {
            //Consulta para extraer los datos de la base de datos
            string query = "SELECT * FROM tblproductos";


            try
            {
                MySqlConnection con = Conexion.MiConexion();
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tb);

                dgvProductos.DataSource = tb;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarProductos();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            Hide();
            clientes.FormClosing  += Home_Shown;
        }



        private void Home_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            Hide();
            productos.FormClosing += Home_Shown;

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
            Hide();
            usuarios.FormClosing += Home_Shown;
        }

        private void Home_Shown(object? sender, EventArgs e)
        {
            Show();
        }
    }
}
