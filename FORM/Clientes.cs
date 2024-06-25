using MySql.Data.MySqlClient;
using segundaDBFranco.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
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

        

        private void Clientes_Load(object sender, EventArgs e)
        {
            if (dgvClientes.Columns["EditarCli  ente"] == null)
            {
                DataGridViewButtonColumn btnEditarCliente = new DataGridViewButtonColumn();
                btnEditarCliente.Name = "btnEditarCliente";
                btnEditarCliente.HeaderText = "Editar";
                btnEditarCliente.Text = "Editar";
                btnEditarCliente.UseColumnTextForButtonValue = true;
                dgvClientes.Columns.Add(btnEditarCliente);
            }

            if (dgvClientes.Columns["EliminarCliente"] == null)
            {
                DataGridViewButtonColumn btnEliminarCliente = new DataGridViewButtonColumn();
                btnEliminarCliente.Name = "btnEliminarCliente";
                btnEliminarCliente.Text = "Eliminar";
                btnEliminarCliente.HeaderText = "Eliminar";
                btnEliminarCliente.UseColumnTextForButtonValue = true;
                dgvClientes.Columns.Add(btnEliminarCliente);

            }
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
                //JOY
                DataTable tb = new DataTable();
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
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0)
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro que quiere editar los datos ", "Info", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    groupBox1.Visible = true;
                    DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                    txtIDactualizar.Enabled = false;
                    txtIDactualizar.Text = fila.Cells[2].Value.ToString();
                    txtNombre2.Text = fila.Cells[3].Value.ToString();
                    txtApellido2.Text = fila.Cells[4].Value.ToString();
                    txtDireccion2.Text = fila.Cells[5].Value.ToString();
                    txtTel2.Text = fila.Cells[6].Value.ToString();
                }
            }
            if (e.ColumnIndex == 1)
            {
               DialogResult respuesta = MessageBox.Show("Esta seguro de que quiere eliminar cliente ", "Info", MessageBoxButtons.YesNo);

                if(respuesta == DialogResult.Yes)
                {
                    //Query para eliminar dato
                    string query = "DELETE FROM tblclientes WHERE idClientes = @id";
                    MySqlConnection con = Conexion.MiConexion();
                    con.Open();
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, con);

                        DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                        int Id = (int)fila.Cells[2].Value;
                        cmd.Parameters.Add(new MySqlParameter("@id", Id));

                        cmd.ExecuteNonQuery();

                        con.Close();

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Clientes_Shown(object sender, EventArgs e)
        {
            Show();
        }

        //Actualizar datos de una base de datos
        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            //Query
            string consultaActualizar = "UPDATE tblclientes SET nombre = @nombre, apellido = @apellido, direccion = @direccion, Tel = @Tel WHERE idClientes = @id";

            //Abrimos conexion
            MySqlConnection connection = Conexion.MiConexion();
            connection.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(consultaActualizar, connection);

                cmd.Parameters.Add(new MySqlParameter("@nombre", txtNombre2.Text));
                cmd.Parameters.Add(new MySqlParameter("@apellido", txtApellido2.Text));
                cmd.Parameters.Add(new MySqlParameter("@direccion", txtDireccion2.Text));
                cmd.Parameters.Add(new MySqlParameter("@Tel", txtTel2.Text));
                cmd.Parameters.Add(new MySqlParameter("@id", txtIDactualizar.Text));
                MessageBox.Show("Numero de ID: " + txtIDactualizar.Text);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
