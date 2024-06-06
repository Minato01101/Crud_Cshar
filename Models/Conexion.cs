using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundaDBFranco.Models
{
    class Conexion
    {
      

        public static MySqlConnection MiConexion()
        {
            string servidor = "127.0.0.1";
            string puerto = "3307";
            string user = "root";
            string clave = "";
            string db = "dbprueba2"; 

            string cadena = $"Server = {servidor}" +
                $"; Port = {puerto}" +
                $"; User Id = {user}" +
                $"; Password = {clave}" +
                $"; Database = {db}";

            MySqlConnection conn = new MySqlConnection(cadena);
            return conn;
        }
    }
}
