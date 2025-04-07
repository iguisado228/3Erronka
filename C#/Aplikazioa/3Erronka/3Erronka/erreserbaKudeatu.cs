using Konexioa;
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
    public partial class erreserbaKudeatu : Form
    {

        private Kluba loggedInKluba;
        private Bazkidea loggedInBazkidea;
        private Dictionary<int, string> orduakLibre = new Dictionary<int, string>();

        public erreserbaKudeatu(Kluba kluba, Bazkidea bazkidea)
        {
            InitializeComponent();
            this.loggedInKluba = kluba;
            this.loggedInBazkidea = bazkidea;

            foreach (int i in Enumerable.Range(0, 10))
            {
                int hasieraOrdua = 7 + i;
                orduakLibre.Add(i, $"{hasieraOrdua}:00 - {hasieraOrdua + 1}:00");
            }


            CErreserba.SelectedIndexChanged += CErreserba_SelectedIndexChanged;
            CBeremua.SelectedIndexChanged += CBeremua_SelectedIndexChanged;
            DTP_Eguna.ValueChanged += DTP_Eguna_ValueChanged1;

            MessageBox.Show($"Kluba: {(kluba != null ? kluba.idKluba.ToString() : "NULL")}, " +
                            $"Bazkidea: {(bazkidea != null ? bazkidea.idBazkidea.ToString() : "NULL")}");
        }

        private List<int> lortuOkupatutakoOrduak(int idEremua, DateTime data)
        {
            List<int> okupatutakoOrduak = new List<int>();

            try
            {
                Konexioa.Konexioa K = new Konexioa.Konexioa();
                K.konektatu();

                string query = "SELECT ordua FROM erreserba WHERE idEremua = @idEremua AND erreserbaEguna = @data AND idErreserba != @idErreserba";
                MySqlCommand com = new MySqlCommand(query, K.conn);
                com.Parameters.AddWithValue("@idEremua", idEremua);
                com.Parameters.AddWithValue("@data", data.Date);
                com.Parameters.AddWithValue("@idErreserba", CErreserba.SelectedValue ?? 0);

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

        private void orduakLibreBerritu()
        {
            if (CBeremua.SelectedValue == null || DTP_Eguna.Value == null)
                return;

            try
            {
                int idEremua = Convert.ToInt32(CBeremua.SelectedValue);
                DateTime data = DTP_Eguna.Value.Date;

                List<int> okupatutakoOrduak = lortuOkupatutakoOrduak(idEremua, data);
                var orduakLibreBerrituta = orduakLibre.Where(h => !okupatutakoOrduak.Contains(h.Key)).ToDictionary(pair => pair.Key, pair => pair.Value);

                CBOrduaEgun.DataSource = new BindingSource(orduakLibreBerrituta, null);
                CBOrduaEgun.DisplayMember = "Value";
                CBOrduaEgun.ValueMember = "Key";

                if (orduakLibreBerrituta.Count == 0)
                {
                    MessageBox.Show("Ez daude orduak libre eremu honentzako egun honetan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arazoa ordu libreak kargatzean: " + ex.Message);
            }
        }

        private void DTP_Eguna_ValueChanged1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void erreserbaKudeatu_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.FromArgb(240, 240, 240);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;


            ErreserbakAgertuCB();
            ErreserbakAgertuDGV();
           


                Erreserba er = new Erreserba();

                DataTable dtEremua = er.bilaketak("Select idEremua, izena from eremua");


                CBeremua.DataSource = dtEremua.Copy();
                CBeremua.DisplayMember = "izena";
                CBeremua.ValueMember = "idEremua";

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
                string query = @"SELECT 
                    e.idErreserba AS 'Erreserba IDa',
                    er.izena AS 'Eremua',
                    e.erreserbaEguna AS 'Eguna',
                    e.ordua
                 FROM erreserba e
                 JOIN eremua er ON e.idEremua = er.idEremua
                 WHERE 1=1";

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

        private void CErreserba_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CErreserba.SelectedValue != null && CErreserba.SelectedValue.ToString() != "")
            {
                try
                {
                    string query = "SELECT * FROM erreserba WHERE idErreserba = @idErreserba";

                    Konexioa.Konexioa K = new Konexioa.Konexioa();
                    K.konektatu();
                    MySqlCommand command = new MySqlCommand(query, K.conn);
                    command.Parameters.AddWithValue("@idErreserba", CErreserba.SelectedValue);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        CBeremua.SelectedValue = reader["idEremua"];
                        DTP_Eguna.Value = Convert.ToDateTime(reader["erreserbaEguna"]);
                        orduakLibreBerritu(); 

                        
                        int ordua = Convert.ToInt32(reader["ordua"]);
                        foreach (KeyValuePair<int, string> item in CBOrduaEgun.Items)
                        {
                            if (item.Key == ordua)
                            {
                                CBOrduaEgun.SelectedItem = item;
                                break;
                            }
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arazoak erreserbaren informazioa bilatzean: " + ex.Message);
                }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Kudeatu_Click(object sender, EventArgs e)
        {
            
        }

        private void CBeremua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DTP_Eguna_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LBL_hasieraOrdua_Click(object sender, EventArgs e)
        {

        }

        private void LBL_erreserbaEguna_Click(object sender, EventArgs e)
        {

        }

        private void TXT_amaieraOrdua_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_hasieraOrdua_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBL_amaieraOrdua_Click(object sender, EventArgs e)
        {

        }

        private void BTN_erreserbaEguneratu_Click(object sender, EventArgs e)
        {
            if (CErreserba.SelectedValue == null)
            {
                MessageBox.Show("Lehenik erreserba bat aukeratu mesedez");
                return;
            }

            try
            {
                Konexioa.Konexioa K = new Konexioa.Konexioa();
                K.konektatu();

                string query = @"UPDATE erreserba 
                           SET idEremua = @idEremua, 
                               erreserbaEguna = @erreserbaEguna, 
                               ordua = @ordua 
                           WHERE idErreserba = @idErreserba";

                MySqlCommand command = new MySqlCommand(query, K.conn);
                command.Parameters.AddWithValue("@idEremua", CBeremua.SelectedValue);
                command.Parameters.AddWithValue("@erreserbaEguna", DTP_Eguna.Value.Date);
                command.Parameters.AddWithValue("@ordua", ((KeyValuePair<int, string>)CBOrduaEgun.SelectedItem).Key);
                command.Parameters.AddWithValue("@idErreserba", CErreserba.SelectedValue);

                int erantzunak = command.ExecuteNonQuery();

                if (erantzunak > 0)
                {
                    MessageBox.Show("Eragiketa egoki burutu da");
                    ErreserbakAgertuDGV(); // Actualizar el DataGridView
                }
                else
                {
                    MessageBox.Show("Ezin izan da erreserba eguneratu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arazoak erreserba eguneratzean: " + ex.Message);
            }
        
        }
    }
}
