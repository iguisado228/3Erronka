using Konexioa;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Erronka
{
    internal class Erreserba

    {
        public virtual int idKluba { get; set; }
        public virtual int idEremua {get; set;}
        public virtual int idBazkidea {get; set;}
        public virtual DateTime erreserbaEguna {get; set;}
        public virtual string hasieraOrdua { get; set; }
        public virtual string amaieraOrdua { get; set; }
        public virtual int idErreserba { get; set;}

    public void gehitu()
    {
        Konexioa.Konexioa k = new Konexioa.Konexioa();
        k.konektatu();

        if (k.conn.State == System.Data.ConnectionState.Open)
        {

            MySqlTransaction transaction = k.conn.BeginTransaction();
            try
            {

                MySqlCommand command = new MySqlCommand();
                command.Connection = k.conn;
                command.CommandText = "INSERT INTO erreserba (idEremua, idBazkidea, idKluba, erreserbaEguna, hasieraOrdua, amaieraOrdua) VALUES (@valor1, @valor2, @valor3, @valor4, @valor5, @valor6)";
                command.Parameters.AddWithValue("@valor1", idEremua);
                command.Parameters.AddWithValue("@valor2", idBazkidea);
                command.Parameters.AddWithValue("@valor3", idKluba);
                command.Parameters.AddWithValue("@valor4", erreserbaEguna);
                command.Parameters.AddWithValue("@valor5", hasieraOrdua);
                command.Parameters.AddWithValue("@valor6", amaieraOrdua);


                MessageBox.Show(command.CommandText);

                int rowsAffected = command.ExecuteNonQuery();
                transaction.Commit();

                MessageBox.Show($"Afektatutako lerroak: {rowsAffected}");


            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Errore bat egon da;" + ex.Message);


            }
            finally
            {
                k.conn.Close();
            }

        }
    }
    public void ezabatu()
    {
            Konexioa.Konexioa k = new Konexioa.Konexioa();
            k.konektatu(); ;

        if (k.conn.State == System.Data.ConnectionState.Open)
        {
            //transakzio bat hasiko dugu
            MySqlTransaction transaction = k.conn.BeginTransaction();
            try
            {
                //komandoa sortuko dugu
                MySqlCommand command = new MySqlCommand();
                command.Connection = k.conn;
                command.CommandText = "DELETE FROM erreserbak WHERE id = @id";
                command.Parameters.AddWithValue("@id", idErreserba);


                MessageBox.Show(command.CommandText);
                //komandoa exekutatuko dugu

                int rowsAffected = command.ExecuteNonQuery();
                //si todo va bien, confirmar la transaccion
                transaction.Commit();

                MessageBox.Show($"Afektatutako lerroak: {rowsAffected}");


            }
            catch (Exception ex)
            {
                //si hay un error, hacer rollback
                transaction.Rollback();
                MessageBox.Show("Errore bat egon da;" + ex.Message);


            }
            finally
            {
                //cerrar la conexion
                k.conn.Close();
            }

        }
    }
    public DataTable dt = new DataTable();
    public DataTable bilaketak(string s)
    {
            Konexioa.Konexioa k = new Konexioa.Konexioa();
            k.konektatu();

            if (k.conn.State == System.Data.ConnectionState.Open)
        {
            try
            {
                //komandoa sortuko dugu
                MySqlCommand command = new MySqlCommand();
                command.Connection = k.conn;
                command.CommandText = s;
                //Crear un adaptador para llenar el DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //si hay un error, hacer rollback
                MessageBox.Show("Bilaketan akatsa: " + ex.Message);


            }
            finally
            {
                //cerrar la conexion
                k.conn.Close();
            }

        }
        else
        {
            MessageBox.Show("Konexio arazoak.");
        }
        return dt;
    }
}
}
 
