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
        public ErreserbaIkusi()
        {
            InitializeComponent();
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
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }
    }
}
