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
    public partial class ErreserbaEgin : Form
    {
        private Kluba loggedInKluba;
        private Bazkidea loggedInBazkidea;

        // Default constructor for the designer
        public ErreserbaEgin()
        {
            InitializeComponent();
        }

        // Constructor for actual use
        internal ErreserbaEgin(Kluba kluba, Bazkidea bazkidea) : this()
        {
            this.loggedInKluba = kluba;
            this.loggedInBazkidea = bazkidea;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Erreserba er = new Erreserba();
                
                er.idBazkidea = loggedInBazkidea.idBazkidea;
                er.idKluba = loggedInKluba.idKluba;
                er.idEremua = Convert.ToInt32(CBeremua.SelectedItem.ToString());
                er.erreserbaEguna = DTPEguna.Value.Date;
                er.erreserbaOrdua = CHasiera.SelectedValue.ToString();
                er.erreserbaAmaieraOrdua = CAmaiera.SelectedValue.ToString();

                er.gehitu();
    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating reservation: " + ex.Message);
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
            DataTable dtHasiera = er.bilaketak("SELECT hasieraOrdua FROM ordutegia");
            DataTable dtAmaiera = er.bilaketak("SELECT amaieraOrdua FROM ordutegia");

            CBeremua.DataSource = dtEremua.Copy();
            CBeremua.DisplayMember = "izena";
            CBeremua.ValueMember = "idEremua";

            CHasiera.DataSource = dtHasiera.Copy();
            CHasiera.DisplayMember = "hasieraOrdua";

            CAmaiera.DataSource = dtAmaiera.Copy();
            CAmaiera.DisplayMember = "amaieraOrdua";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LBLerreserbaEguna_Click(object sender, EventArgs e)
        {

        }

        private void BTNAtzera_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
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
    }
}
