using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konexioa
{
    internal class Konexioa
    {
        public virtual string Servidor { get; set; } = "localhost";
        public virtual string Puerto { get; set; } = "3306";
        public virtual string Usuario { get; set; } = "root";
        public virtual string Contraseña { get; set; } = "1mg2024";
        public virtual string BaseDeDatos { get; set; } = "3erronka";
        public virtual string SslMode { get; set; } = "None";

        public string konexioKatea()
        {
            return $"Server={Servidor}; Port={Puerto}; Database={BaseDeDatos}; User ID={Usuario}; Password={Contraseña}; SslMode=Preferred;";
        }

        public MySqlConnection conn;
        public void konektatu()
        {
            conn = new MySqlConnection(konexioKatea());
            try
            {
                conn.Open();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Konexio errorea: " + ex.Message + ex.Number);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
        }


    }
}
