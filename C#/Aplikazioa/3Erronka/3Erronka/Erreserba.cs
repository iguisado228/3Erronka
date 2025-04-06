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
        public virtual int ordua { get; set; }
        public virtual int idErreserba { get; set;}
        public DataTable dt { get; } = new DataTable();

    public bool gehitu()
    {
        Konexioa.Konexioa k = new Konexioa.Konexioa();
        k.konektatu();

        if (k.conn.State == System.Data.ConnectionState.Open)
        {

            MySqlTransaction transaction = k.conn.BeginTransaction();
            try
            {
                    string bilatuQuery = @"select count(*) from erreserba1 where idEremua = @valor1 and erreserbaEguna = @valor4 and ordua = @valor5";
                    MySqlCommand bilatuCommand = new MySqlCommand(bilatuQuery, k.conn, transaction);
                    bilatuCommand.Parameters.AddWithValue("@valor1", idEremua);
                    bilatuCommand.Parameters.AddWithValue("@valor4", erreserbaEguna);
                    bilatuCommand.Parameters.AddWithValue("@valor5", ordua);

                    int kontadorea = Convert.ToInt32(bilatuCommand.ExecuteScalar());
                    if (kontadorea > 0)
                    {
                        MessageBox.Show("Erreserba hau jada existitzen da, egun, eremu eta ordu hauekin");
                        transaction.Rollback();
                        return false;
                    }


                    string query = @"Insert into erreserba1 (idEremua, idBazkidea, idKluba, erreserbaEguna, ordua) VALUES (@valor1, @valor2, @valor3, @valor4, @valor5)";
                MySqlCommand command = new MySqlCommand(query, k.conn, transaction);

                command.Parameters.AddWithValue("@valor1", idEremua);
                command.Parameters.AddWithValue("@valor2", idBazkidea == 0 ? 999 : idBazkidea);
                command.Parameters.AddWithValue("@valor3", idKluba == 0 ? 999 : idKluba);
                command.Parameters.AddWithValue("@valor4", erreserbaEguna);
                command.Parameters.AddWithValue("@valor5", ordua);

                command.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show($"Eragiketa egoki burutu da.");
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Errore bat egon da;" + ex.Message);
                return false;
            }
            finally
            {
                k.conn.Close();
            }


        }
        return false;
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
                command.CommandText = "DELETE FROM erreserba1 WHERE id = @id";
                command.Parameters.AddWithValue("@id", idErreserba);


                MessageBox.Show(command.CommandText);
                //komandoa exekutatuko dugu

                int rowsAffected = command.ExecuteNonQuery();
                //si todo va bien, confirmar la transaccion
                transaction.Commit();

                MessageBox.Show($"Eragiketa egoki burutu da.");


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

    public DataTable bilaketak(string s)
    {
            dt.Clear();
            Konexioa.Konexioa k = new Konexioa.Konexioa();
            k.konektatu();

            if (k.conn.State == System.Data.ConnectionState.Open)
        {
            try
            {

                MySqlCommand command = new MySqlCommand(s, k.conn);
                
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Bilaketan akatsa: " + ex.Message);


            }
            finally
            {
                
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
 
