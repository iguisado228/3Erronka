using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Erronka
{
    public class Kluba
    {
        public virtual int idKluba { get; set;}
        public virtual String Identifikadorea { get; set;}
        public virtual String Pasahitza { get; set;}
        public virtual String izena { get; set;}
        public virtual String kirola {  get; set;}
        public virtual int jokalariKopurua { get; set;}
        public virtual int taldeKopurua { get; set;}








        public Kluba(int idKluba)
        {
            this.idKluba = idKluba;
        }
        public bool klubLogina()
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
                    command.CommandText = "SELECT identifikadorea, pasahitza, idKluba FROM kluba WHERE identifikadorea = @valor1 AND pasahitza = @valor2";
                    command.Parameters.AddWithValue("@valor1", Identifikadorea);
                    command.Parameters.AddWithValue("@valor2", Pasahitza);

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        idKluba = reader.GetInt32("idKluba"); 
                        loginaEginda = true;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el login: " + ex.Message);
                }
                k.conn.Close();
            }
            return loginaEginda;
        }


    }
}
