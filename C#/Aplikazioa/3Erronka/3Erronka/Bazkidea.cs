using Konexioa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace _3Erronka
{
    public class Bazkidea
    {
        public virtual int idBazkidea { get; set; }  
        public virtual String Identifikadorea { get; set; }
        public virtual String Pasahitza { get; set; }
        public virtual String NAN { get; }
        public virtual String Izena { get; }
        public virtual String Abizena { get; }
        public virtual String Helbidea { get; }

        public bool bazkideLogina()
        {
            Boolean loginaEginda = false;
            Konexioa.Konexioa k = new Konexioa.Konexioa();
            k.konektatu();

            if (k.conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = k.conn;
                    command.CommandText = "Select identifikadorea, pasahitza, idBazkidea from bazkidea where identifikadorea = @valor1 and pasahitza = @valor2";
                    command.Parameters.AddWithValue("@valor1", Identifikadorea);
                    command.Parameters.AddWithValue("@valor2", Pasahitza);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        idBazkidea = reader.GetInt32("idBazkidea");
                        MessageBox.Show(idBazkidea.ToString());
                        loginaEginda = true;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errorea loginean: " + ex.Message);
                }  
                k.conn.Close();
            }
            return loginaEginda;
        }

    }
}
