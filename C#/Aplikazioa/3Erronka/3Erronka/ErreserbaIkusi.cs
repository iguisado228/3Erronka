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
    public partial class ErreserbaIkusi : Form
    {
        private Kluba loggedInKluba;
        private Bazkidea loggedInBazkidea;

        public ErreserbaIkusi(Kluba kluba = null, Bazkidea bazkidea = null)
        {
            InitializeComponent();
            this.loggedInKluba = kluba ?? new Kluba(999);
            this.loggedInBazkidea = bazkidea ?? new Bazkidea(999);
        }

        private void ErreserbaIkusi_Load(object sender, EventArgs e)
        {
            Konexioa.Konexioa K = new Konexioa.Konexioa();
            K.konektatu();

            try
            {
                DataTable table = new DataTable();

                MySqlCommand command = new MySqlCommand("Select * from erreserba", K.conn);
                
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }catch (Exception ex)
            {
                MessageBox.Show("Errorea erreserbak bilatzean: " + ex.Message);
            }
        }

        private void BTNAtzera_Click(object sender, EventArgs e)
        {
            Menu men = new Menu(loggedInKluba, loggedInBazkidea);
            men.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
