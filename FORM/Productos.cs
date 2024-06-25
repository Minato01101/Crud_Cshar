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
        
        public Productos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.Columns["btnEditar"] == null)
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "btnEditar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgvProducto.Columns.Add(btnEditar);
            }
            if (dgvProducto.Columns["btnEliminar"] == null)
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "btnELiminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dgvProducto.Columns.Add(btnEliminar);
            }


            cargarProductos();
            limpiar();
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";

        }

        private void cargarProductos()
        {
            MySqlConnection conexion = Conexion.MiConexion();
            conexion.Open();
            string query = "SELECT * FROM tblproductos";

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            cmd.ExecuteNonQuery();

            MySqlDataAdapter productos = new MySqlDataAdapter(cmd); 
            DataTable tb = new DataTable();
            productos.Fill(tb);
            dgvProducto.DataSource = tb;
            conexion.Close();

        }

        private void Productos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Consulta para agregar prodcutos a la db 
            string query = "INSERT INTO tblproductos (nombre, cantidad, precio) VALUES (@nombre, @cantidad, @precio);";

            //Conexion
            MySqlConnection con = Conexion.MiConexion();
            con.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.Add(new MySqlParameter("@nombre", txtNombre.Text));
                cmd.Parameters.Add(new MySqlParameter("@cantidad", txtCantidad.Text));
                cmd.Parameters.Add(new MySqlParameter("@precio", txtPrecio.Text));

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah ocurrido un error: " + ex.Message);
            }
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0)
            {
                panel1.Visible = true;
                //Editar datos, mandamos los datos para los textbox
                DataGridViewRow Fila = dgvProducto.Rows[e.RowIndex];

                txtId2.Text = Fila.Cells[2].Value.ToString();
                txtNombre2.Text = Fila.Cells[3].Value.ToString();
                txtCantidad2.Text = Fila.Cells[4].Value.ToString();
                txtPrecio2.Text = Fila.Cells[5].Value.ToString();
            }

            if (e.ColumnIndex == 1)
            {
                var respuesta = MessageBox.Show("Esta seguro que quiere eliminar el producto", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (respuesta == DialogResult.Yes)
                {
                    //Query para eliminar
                    string query = "DELETE FROM tblproductos WHERE idProductos = @id";

                    MySqlConnection con = Conexion.MiConexion();
                    con.Open();

                    try
                    {
                        DataGridViewRow Fila = dgvProducto.Rows[e.RowIndex];

                        //Obteniedo id del producto a eliminar 
                        int id = (int)Fila.Cells[2].Value;

                        MySqlCommand cmd = new MySqlCommand(query, con);

                        cmd.Parameters.Add(new MySqlParameter("@id", id));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto eliminado ");
                        con.Close();
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }
                }
            }
        }

        private void btnAclualizar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            //query para actualizar los datos 
            string query = "UPDATE tblproductos SET nombre = @nombre, cantidad = @cantidad, precio = @precio WHERE idProductos = @id";

            //Abriendo conexio
            MySqlConnection con = Conexion.MiConexion();    
            con.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.Add(new MySqlParameter("@nombre", txtNombre2.Text));
                cmd.Parameters.Add(new MySqlParameter("@cantidad", txtCantidad2.Text));
                cmd.Parameters.Add(new MySqlParameter("@precio", txtPrecio2.Text));
                cmd.Parameters.Add(new MySqlParameter("@id", txtId2.Text));

                MessageBox.Show("Producto a modificar tiene id =" + txtId2);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
