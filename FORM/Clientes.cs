using MySql.Data.MySqlClient;
using segundaDBFranco.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundaDBFranco.FORM
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        DataTable tb = new DataTable();
        private void Clientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void cargarClientes()
        {
            //Consulta
            //SELECT * FROM tblclientes
            string query = "SELECT * FROM tblclientes";

            MySqlConnection con = Conexion.MiConexion();
            con.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(tb);

                dgvClientes.DataSource = tb;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al conectarce a la base" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Fila = dgvClientes.Rows[e.RowIndex];

            txtNombre.Text = Fila.Cells[1].Value.ToString();
            txtApellido.Text = Fila.Cells[2].Value.ToString();
            txtDireccion.Text = Fila.Cells[3].Value.ToString();
            txtTel.Text = Fila.Cells[4].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Agregando nuevo cliente al datagrid
            string query = "INSERT INTO tblclientes (nombre, apellido, direccion, Tel) VALUES (@nombre,@apellido, @direccion, @Tel)";
            MySqlConnection conexion = Conexion.MiConexion();
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.Add(new MySqlParameter("@nombre", txtNombre.Text));
                cmd.Parameters.Add(new MySqlParameter("@apellido", txtApellido.Text));
                cmd.Parameters.Add(new MySqlParameter("@direccion", txtDireccion.Text));
                cmd.Parameters.Add(new MySqlParameter("@Tel", txtTel.Text));
                cmd.ExecuteNonQuery();
                conexion.Close();
                cargarClientes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Clientes_Shown(object sender, EventArgs e)
        {
            Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
