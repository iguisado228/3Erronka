using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Erronka
{

    public partial class erreserbaEzabatu : Form
    {
        private Kluba loggedInKluba; 
        private Bazkidea loggedInBazkidea;

        public erreserbaEzabatu(Kluba kluba, Bazkidea bazkidea)
        {
            InitializeComponent();
            this.loggedInKluba = kluba;
            this.loggedInBazkidea = bazkidea;

            MessageBox.Show($"Kluba: {(kluba != null ? kluba.idKluba.ToString() : "NULL")}, " +
                            $"Bazkidea: {(bazkidea != null ? bazkidea.idBazkidea.ToString() : "NULL")}");
        }


        private void erreserbaEzabatu_Load(object sender, EventArgs e)
        {
            ErreserbakAgertuCB();
            ErreserbakAgertuDGV();
        }
            
        private void ErreserbakAgertuCB()
        {
            try
            {
                string query = "select idErreserba from erreserba where 1=1";

                if (loggedInKluba.idKluba != 999)
                {
                    query += " AND idKluba = @idKluba";
                }
                else if (loggedInBazkidea.idBazkidea != 999)
                {
                    query += " AND idBazkidea = @idBazkidea";
                }

                Konexioa.Konexioa K = new Konexioa.Konexioa();
                K.konektatu();
                MySqlCommand command = new MySqlCommand(query, K.conn);

                if (loggedInKluba.idKluba != 999)
                {
                    command.Parameters.AddWithValue("@idKluba", loggedInKluba.idKluba);
                }
                else if (loggedInBazkidea.idBazkidea != 999)
                {
                    command.Parameters.AddWithValue("@idBazkidea", loggedInBazkidea.idBazkidea);
                }

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);

                CErreserba.DataSource = dt;
                CErreserba.DisplayMember = "idErreserba";
                CErreserba.ValueMember = "idErreserba";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Arazoa erreserbak kargatzean: " + ex.Message);
            }
        }

        private void ErreserbakAgertuDGV()
        {
            try
            {
                string query = "select * from erreserba where 1=1";

                if (loggedInKluba.idKluba != 999)
                {
                    query += " AND idKluba = @idKluba";
                }
                else if (loggedInBazkidea.idBazkidea != 999)
                {
                    query += " AND idBazkidea = @idBazkidea";
                }

                Konexioa.Konexioa K = new Konexioa.Konexioa();
                K.konektatu();
                MySqlCommand command = new MySqlCommand(query, K.conn);

                if (loggedInKluba.idKluba != 999)
                {
                    command.Parameters.AddWithValue("@idKluba", loggedInKluba.idKluba);
                }
                else if (loggedInBazkidea.idBazkidea != 999)
                {
                    command.Parameters.AddWithValue("@idBazkidea", loggedInBazkidea.idBazkidea);
                }

                DataTable dat = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dat);

                dataGridView1.DataSource = dat;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arazoa erreserbak kargatzean: " + ex.Message);
            }
        }


        private void BTN_Atzera_Click(object sender, EventArgs e)
        {
            Menu men = new Menu(loggedInKluba, loggedInBazkidea);
            men.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Ezabatu_Click(object sender, EventArgs e)
        {
            if (CErreserba.SelectedValue == null)
            {
                MessageBox.Show("Lehenik erreserba bat aukeratu mesedez.");
                return;
            }

            int idErreserba = Convert.ToInt32(CErreserba.SelectedValue);

            try
            {
                Konexioa.Konexioa K = new Konexioa.Konexioa();
                K.konektatu();
                string query = "Delete from erreserba where idErreserba = @id";

                MySqlCommand command = new MySqlCommand(query, K.conn);
                command.Parameters.AddWithValue("@id", idErreserba);

                int ilarak = command.ExecuteNonQuery();

                if (ilarak > 0)
                {
                    MessageBox.Show("Erreserba ezabatu da.");   
                    ErreserbakAgertuCB();
                    ErreserbakAgertuDGV();
                }else
                {
                    MessageBox.Show("Ez da erreserbarik agertu.");
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Estebe Arazoa erreserba ezabatzean: " + ex.Message);
            }

        }
    }
}
