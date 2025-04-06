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

        private static string orduErrealaLortu(int orduaZenbakia)
        {
            if (orduaZenbakia < 1 || orduaZenbakia > 10)
            {
                return "Ordu hori ezinezkoa da";
            }

            int orduErreala = 7 + orduaZenbakia;
            return $"{orduErreala}:00 - {orduErreala + 1}: 00";

        }

        private void ErreserbaIkusi_Load(object sender, EventArgs e)
        {
            Konexioa.Konexioa K = new Konexioa.Konexioa();
            K.konektatu();

            try
            {
                DataTable table = new DataTable();

                MySqlCommand command = new MySqlCommand("SELECT e.idErreserba AS 'Erreserbaren IDa', k.izena AS 'Kluba', b.izena AS 'Bazkidea', er.izena AS 'Eremua', e.erreserbaEguna AS 'Eguna', e.ordua AS 'Ordua', CONCAT (7 + e.ordua, ':00 - ', 7 + e.ordua + 1, ' :00') AS 'Ordua' FROM erreserba1 e JOIN eremua er ON e.idEremua = er.idEremua LEFT JOIN kluba k ON e.idKluba = k.idKluba LEFT JOIN bazkidea b ON e.idBazkidea = b.idBazkidea WHERE 1=1", K.conn);


                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(table);

                table.Columns.Add("Ordua", typeof(string));
                foreach (DataRow row in table.Rows)
                {
                    int orduaZenbakia = Convert.ToInt32(row["Ordua zenbakia"]);
                    row["Ordua"] = orduErrealaLortu(orduaZenbakia);
                }

                dataGridView1.DataSource = table;
                dataGridView1.Columns["Ordua zenbakia"].Visible = false;

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
