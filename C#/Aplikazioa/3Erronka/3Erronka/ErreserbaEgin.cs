using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3Erronka
{
    public partial class erreserbaEgin : Form
    {
        private Kluba loggedInKluba;
        private Bazkidea loggedInBazkidea;
        private List<int> orduakLibre = new List<int>();

        internal erreserbaEgin(Kluba kluba, Bazkidea bazkidea)
        {
            InitializeComponent();
            this.loggedInKluba = kluba ?? new Kluba(999);
            this.loggedInBazkidea = bazkidea ?? new Bazkidea(999);

            for (int i=0; i<=10; i++)
            {
                orduakLibre.Add(i);
            }

            CBOrdua.DataSource = orduakLibre;

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


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Erreserba er = new Erreserba();

                er.idBazkidea = (loggedInBazkidea != null) ? loggedInBazkidea.idBazkidea : 999;
                er.idKluba = (loggedInKluba != null) ? loggedInKluba.idKluba : 999;
                er.idEremua = Convert.ToInt32(CBeremua.SelectedValue);
                er.erreserbaEguna = DTPEguna.Value.Date;
                er.ordua = Convert.ToInt32(CBOrdua.SelectedValue);

                er.gehitu();

                string orduaBerrituta = orduErrealaLortu(er.ordua);
                MessageBox.Show($"Erreserba egoki burutu da {er.erreserbaEguna.ToShortDateString()} egunean  " +
                       $" {orduaBerrituta} ordutan {CBeremua.Text} eremuan");

                orduakLibreBerritu();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating reservation: " + ex.Message);
            }
        }


        private void orduakLibreBerritu()
        {
            if (CBeremua.SelectedValue == null || DTPEguna.Value == null)
                return;

            try
            {
                Konexioa.Konexioa K = new Konexioa.Konexioa();
                K.konektatu();

                string query = "Select ordua from erreserba1 where idEremua = @idEremua and erreserbaEguna = @fecha";
                MySqlCommand cmd = new MySqlCommand(query, K.conn);
                cmd.Parameters.AddWithValue("@idEremua", CBeremua.SelectedValue);
                cmd.Parameters.AddWithValue("@fecha", DTPEguna.Value.Date);

                MySqlDataReader reader = cmd.ExecuteReader();

                List<int> orduakOkupatuta = new List<int>();
                while (reader.Read())
                {
                    orduakOkupatuta.Add(reader.GetInt32("ordua"));
                }
                reader.Close();
                K.conn.Close();

                List<int> orduakLibreBerrituta = Enumerable.Range(1, 10)
                    .Where(h => !orduakOkupatuta.Contains(h))
                    .ToList();

                CBOrdua.DataSource = orduakLibreBerrituta;

                if (orduakLibreBerrituta.Count == 0)
                {
                    MessageBox.Show("Ez daude orduak libre eremu honentzako egun honetan");
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Arazoa ordu libreak kargatzean " + ex.Message);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Erreserba_Load(object sender, EventArgs e)
        {
            

            Erreserba er = new Erreserba();

            DataTable dtEremua = er.bilaketak("Select idEremua, izena from eremua");
            

            CBeremua.DataSource = dtEremua.Copy();
            CBeremua.DisplayMember = "izena";
            CBeremua.ValueMember = "idEremua";

            CBeremua.SelectedIndexChanged += (s, ev) => orduakLibreBerritu();
            DTPEguna.ValueChanged += (s, ev) => orduakLibreBerritu();

          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LBLerreserbaEguna_Click(object sender, EventArgs e)
        {

        }

        private void BTNAtzera_Click(object sender, EventArgs e)
        {
            Menu men = new Menu(loggedInKluba, loggedInBazkidea);
            men.Show();
            this.Hide();
        }

        private void COrdua_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CAmaiera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DTPEguna_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void CBOrdua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
