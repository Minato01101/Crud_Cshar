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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Query 
            string Consulta = "INSERT INTO tblusuarios (nombre, clave) VALUES (@nombre,@clave)";

            MySqlConnection con = Conexion.MiConexion();
            con.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(Consulta, con);
                cmd.Parameters.Add(new MySqlParameter("@nombre", txtUsuario.Text));
                cmd.Parameters.Add(new MySqlParameter("@clave", txtClave.Text));

                cmd.ExecuteNonQuery();
                con.Close();
                txtUsuario.Text ="";
                txtClave.Text = "";
                MostrarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Query
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            //Agregando botones eliminar y editar 

            if (dgvUsuarios.Columns["btnEditar"] == null)
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "btnEditar";
                btnEditar.Text = "Editar";
                btnEditar.HeaderText = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgvUsuarios.Columns.Add(btnEditar);
            }

            if (dgvUsuarios.Columns["btnEliminar"] == null)
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "btnEliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dgvUsuarios.Columns.Add(btnEliminar);
            }

            //Query
            string Consulta = "SELECT * FROM tblusuarios";

            MySqlConnection conexion = Conexion.MiConexion();
            conexion.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(Consulta, conexion);

                DataTable tb = new DataTable();

                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(tb);

                dgvUsuarios.DataSource = tb;
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtClave2.Text = "";
            txtUsuario2.Text = "";


        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            //Query
            string query = "UPDATE tblusuarios  SET nombre = @nombre, clave = @clave WHERE idUsuario = @id";

            MySqlConnection conn = Conexion.MiConexion();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("@nombre", txtUsuario2.Text));
                cmd.Parameters.Add(new MySqlParameter("@clave", txtClave2.Text));
                cmd.Parameters.Add(new MySqlParameter("@id", txtID2.Text));
                cmd.ExecuteNonQuery();

                conn.Close();
                MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" + ex.Message);
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                string mensaje = $"Id: {fila.Cells[2].Value.ToString()} \n" +
                    $"Nombre: {fila.Cells[3].Value.ToString()}";

                var respues = MessageBox.Show($"Desea editar el sigiente dato-> \n\n {mensaje}", "Info", MessageBoxButtons.YesNo);

                if(respues == DialogResult.Yes)
                {
                    panel1.Visible = true;
                    txtID2.Text = fila.Cells[2].Value.ToString();
                    txtUsuario2.Text = fila.Cells[3].Value.ToString();
                    txtClave2.Text = fila.Cells[4].Value.ToString();
                }
            }

            if(e.ColumnIndex == 1)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                string nombre = fila.Cells[3].Value.ToString();

                //Id a eliminar
                int id = int.Parse(fila.Cells[2].Value.ToString());

                var respuesta = MessageBox.Show($"Desea eliminar a {nombre}??", "Info", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(respuesta == DialogResult.Yes)
                {
                    //query 
                    string query = "DELETE FROM tblUsuarios WHERE idusuario = @id";

                    MySqlConnection conn = Conexion.MiConexion();
                    conn.Open();
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.Add(new MySqlParameter("@id", id));
                    }
                    catch (Exception Ex)
                    {

                        MessageBox.Show("Error:" + Ex.Message) ;
                    }
                }
            }
        }
    }
}
