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
        private Dictionary<int, string> orduakLibre = new Dictionary<int, string>();

        
           

        internal erreserbaEgin(Kluba kluba, Bazkidea bazkidea)
        {
            InitializeComponent();
            this.loggedInKluba = kluba ?? new Kluba(999);
            this.loggedInBazkidea = bazkidea ?? new Bazkidea(999);


            foreach (int i in Enumerable.Range(1, 10))
            {
                int hasieraOrdua = 7 + i;
                orduakLibre.Add(i, $"{hasieraOrdua}:00 - {hasieraOrdua + 1}:00");
            }

        }

        private List<int> lortuOkupatutakoOrduak(int idEremua, DateTime data)
        {
            List<int> okupatutakoOrduak = new List<int>();

            try
            {
                Konexioa.Konexioa K = new Konexioa.Konexioa();
                K.konektatu();

                string query2 = "Select ordua from erreserba1 where idEremua = @idEremua and erreserbaEguna = @data";
                MySqlCommand com = new MySqlCommand(query2, K.conn);
                com.Parameters.AddWithValue("@idEremua", idEremua);
                com.Parameters.AddWithValue("@data", data.Date);

                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    okupatutakoOrduak.Add(reader.GetInt32("ordua"));
                }
                reader.Close();
                K.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea ordu okupatuak lortzean: " + ex.Message);
            }
            return okupatutakoOrduak;
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
                er.ordua = ((KeyValuePair<int, string>)CBOrdua.SelectedItem).Key;

                er.gehitu();

                string aukeratutakoOrdua = ((KeyValuePair<int, string>)CBOrdua.SelectedItem).Value;
                MessageBox.Show($"Erreserba egoki burutu da {er.erreserbaEguna.ToShortDateString()} egunean  " +
                       $" {aukeratutakoOrdua} ordutan {CBeremua.Text} eremuan");

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
                int idEremua = Convert.ToInt32(CBeremua.SelectedValue);
                DateTime data = DTPEguna.Value.Date;

                List<int> okupatutakoOrduak = lortuOkupatutakoOrduak(idEremua, data);
                var orduakLibreBerrituta = orduakLibre.Where(h => !okupatutakoOrduak.Contains(h.Key)).ToDictionary(pair => pair.Key, pair => pair.Value);

                CBOrdua.DataSource = new BindingSource(orduakLibreBerrituta, null);
                CBOrdua.DisplayMember = "Value";
                CBOrdua.ValueMember = "Key";


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

            if (CBeremua.Items.Count > 0 && DTPEguna.Value != null)
            {
                int idEremua = Convert.ToInt32(CBeremua.SelectedValue);
                DateTime data = DTPEguna.Value.Date;

                List<int> okupatutakoOrduak = lortuOkupatutakoOrduak(idEremua, data);
                var orduakLibreBerrituta = orduakLibre.Where(h => !okupatutakoOrduak.Contains(h.Key)).ToDictionary(pair => pair.Key, pair => pair.Value);
                CBOrdua.DataSource = new BindingSource(orduakLibreBerrituta, null);
                CBOrdua.DisplayMember = "Value";
                CBOrdua.ValueMember = "Key";
            }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ErreserbakAgertuDGV()
        {
            try
            {
                string query = @"SELECT 
                    er.izena AS 'Eremua',
                    e.ordua AS 'Ordua'
                 FROM erreserba e
                 JOIN eremua er ON e.idEremua = er.idEremua
                 WHERE erreserbaEguna = 'DTPEguna.Value.Date' AND eremua = 'Convert.ToInt32(CBeremua.SelectedValue);'";

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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Arazoa erreserbak kargatzean: " + ex.Message);
            }
        }

        private void TXTerreserbaHasieraOrdua_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBOrdua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
