using MySql.Data.MySqlClient;
using segundaDBFranco.FORM;
using segundaDBFranco.Models;

namespace segundaDBFranco
{
    public partial class Form1 : Form
    {
        public bool ShowPwd = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            ShowPwd = !ShowPwd;

            if (ShowPwd)
            {
                txtClave.PasswordChar = '\0';
            }
            else
            {
                txtClave.PasswordChar = '*';
            }
        }

        private void btnSiguinete_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            string query = $"SELECT * FROM tblusuarios WHERE nombre = '{usuario}' AND clave = '{clave}'";

            MySqlConnection conexion = Conexion.MiConexion();
            conexion.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);

                cmd.ExecuteNonQuery();

                int Datos = (int)cmd.ExecuteScalar();
                if (Datos > 0)
                {
                    MessageBox.Show("Inicio de seccion exitosa");
                    Home home = new Home();
                    home.ShowDialog();
                    Hide();
                    home.FormClosing += Form1_Shown;
                }
                else
                {
                    MessageBox.Show("Error, intente de nuevo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }



        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            Show();
        }
    }
}
