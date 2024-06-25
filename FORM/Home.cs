using Microsoft.VisualBasic.Logging;
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
                //Tabla para extraer los datos
                DataTable tb = new DataTable();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Por favor ingrese una cantidad");
                return;
            }

            int index = dgvProductos.CurrentCell.RowIndex;
            DataGridViewRow Fila = dgvProductos.Rows[index];

            //Obtenemos valores de las celda seleccionada 
            string idProducto = Fila.Cells[0].Value.ToString();
            string nombre = Fila.Cells[1].Value.ToString();
            int CantidadDisponible = int.Parse(Fila.Cells[2].Value.ToString());
            float Precio = float.Parse(Fila.Cells[3].Value.ToString());
            int Cantidad = int.Parse(txtCantidad.Text);

            //Validamos que la cantidad agregada por el usuario
            //Sea correcta
            if (Cantidad > CantidadDisponible)
            {
                MessageBox.Show("Lo sentimos, la cantidad ingresada es incorrecta");
                return;
            }
            //Calculamos total del producto
            float SubTotal = Precio * Cantidad;

            //Validamos si el producto ya esta en el carrito que solo 
            //Actualice los datos
            foreach (DataGridViewRow item in dgvCarrito.Rows)
            {
                if (item.Cells[1].Value.ToString() == nombre)
                {
                    item.Cells[2].Value = Cantidad + int.Parse(item.Cells[2].Value.ToString());
                    Fila.Cells[2].Value = CantidadDisponible - Cantidad;//actualizamos datos de dgvproductos
                    item.Cells[4].Value = float.Parse(item.Cells[2].Value.ToString()) * Precio;
                    return;
                }
            }

            //Si no esta adentro se ejecutara esto
            dgvCarrito.Rows.Add(idProducto, nombre, Cantidad, Precio, SubTotal);
            //Actualizamos los datos de la tabla producto
            Fila.Cells[2].Value = CantidadDisponible - Cantidad;
            Calculo();
        }

        private void Calculo()
        {
            float total = 0;
            foreach (DataGridViewRow item in dgvCarrito.Rows)
            {
                total += (float)item.Cells[4].Value;
            }
            lblTotal.Text = $"Total: ${total}";
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Index = dgvCarrito.CurrentCell.RowIndex;
            DataGridViewRow Fila = dgvCarrito.Rows[Index];
            if (Index < 0) return;

            foreach (DataGridViewRow item in dgvCarrito.Rows)
            {
                
            }
        }
    }
}
