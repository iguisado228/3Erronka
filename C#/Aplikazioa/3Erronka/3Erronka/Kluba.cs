using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Erronka
{
    internal class Kluba
    {
        public virtual int idKluba { get;}
        public virtual String Identifikadorea { get; set;}
        public virtual String Pasahitza { get; set;}
        public virtual String izena { get; set;}
        public virtual String kirola {  get; set;}
        public virtual int jokalariKopurua { get; set;}
        public virtual int taldeKopurua { get; set;}

        public Kluba()
        {

        }
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
                    command.CommandText = "Select identifikadorea, pasahitza, idKluba from kluba where identifikadorea = @valor1 and pasahitza = @valor2";
                    command.Parameters.AddWithValue("@valor1", Identifikadorea);
                    command.Parameters.AddWithValue("@valor2", Pasahitza);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        loginaEginda = true;
                    }
                    
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
