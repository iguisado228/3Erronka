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

        public erreserbaKudeatu(Kluba kluba, Bazkidea bazkidea)
        {
            InitializeComponent();
            this.loggedInKluba = kluba;
            this.loggedInBazkidea = bazkidea;

            CErreserba.SelectedIndexChanged += CErreserba_SelectedIndexChanged;

            MessageBox.Show($"Kluba: {(kluba != null ? kluba.idKluba.ToString() : "NULL")}, " +
                            $"Bazkidea: {(bazkidea != null ? bazkidea.idBazkidea.ToString() : "NULL")}");
        }

        private void erreserbaKudeatu_Load(object sender, EventArgs e)
        {
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
                        
                        DTP_Eguna.Text = reader["erreserbaEguna"].ToString();
                        TXT_hasieraOrdua.Text = reader["hasieraOrdua"].ToString();
                        TXT_amaieraOrdua.Text = reader["amaieraOrdua"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos de la reserva: " + ex.Message);
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
    }
}
