using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void erreserbaEzabatu_Load(object sender, EventArgs e)
        {
            Konexioa.Konexioa K = new Konexioa.Konexioa();
            K.konektatu();

            try
            {
                string query = "Select * from erreserba where 1 =1";

                if (loggedInKluba != null && loggedInKluba.idKluba != 999)
                {
                    query += " AND idKluba = @idKluba";
                }else if (loggedInBazkidea != null && loggedInBazkidea.idBazkidea != 999)
                {
                    query += " AND idBazkidea = @idBazkidea";
                }

                MySqlCommand command = new MySqlCommand(query, K.conn);

                if (loggedInKluba != null && loggedInKluba.idKluba != 999)
                {
                    command.Parameters.AddWithValue("@idKluba", loggedInKluba.idKluba);
                } else if (loggedInBazkidea != null && loggedInBazkidea.idBazkidea != 999)
                {
                    command.Parameters.AddWithValue("@idBazkidea", loggedInBazkidea.idBazkidea);
                }

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                Console.WriteLine(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea erreserbak bilatzean: "+ ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loggedInBazkidea != null)
            {
                MessageBox.Show("Bazkidea: " + loggedInBazkidea.idBazkidea);
            }else
            {
                MessageBox.Show("Bazkidea: " + loggedInBazkidea.idBazkidea);
            }

            if (loggedInKluba != null)
            {
                MessageBox.Show("Kluba: " + loggedInKluba.idKluba);
            }else
            {
                MessageBox.Show("Kluba: " + loggedInKluba.idKluba);
            }
        }
    }
}
