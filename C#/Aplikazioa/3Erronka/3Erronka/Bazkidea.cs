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
    internal class Bazkidea
    {
        public virtual int idBazkidea { get; }
        public virtual String Identifikadorea { get; set; }
        public virtual String Pasahitza { get; set; }
        public virtual String NAN { get; }
        public virtual String Izena { get; }
        public virtual String Abizena { get; }
        public virtual String Helbidea { get; }

        public void bazkideLogina()
        {
            Konexioa.Konexioa k = new Konexioa.Konexioa();
            k.Contraseña = "1mg2024";
            k.konektatu();

            if (k.conn.State == System.Data.ConnectionState.Open)
            {
                MySqlTransaction transaction = k.conn.BeginTransaction();
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = k.conn;
                    command.CommandText = "Select identifikadorea, pasahitza from bazkidea where identifikadorea = '@valor1' and pasahitza = '@valor2'";
                    command.Parameters.AddWithValue("@valor1", Identifikadorea);
                    command.Parameters.AddWithValue("@valor2", Pasahitza);

                    MessageBox.Show(command.CommandText);
                    transaction.Commit();

                    MessageBox.Show($"Ongi etorri!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Errorea transakzioan: " + ex.Message);
                }
                finally
                {
                    k.conn.Close();
                }
            }
        }

    }
}
