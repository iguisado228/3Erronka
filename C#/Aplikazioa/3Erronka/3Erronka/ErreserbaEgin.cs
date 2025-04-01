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

                er.idBazkidea = (loggedInBazkidea != null) ? loggedInBazkidea.idBazkidea : 999;
                er.idKluba = (loggedInKluba != null) ? loggedInKluba.idKluba : 999;
                er.idEremua = Convert.ToInt32(CBeremua.SelectedValue);
                er.erreserbaEguna = DTPEguna.Value.Date;
                er.hasieraOrdua = TXTerreserbaHasieraOrdua.Text.ToString();
                er.amaieraOrdua = TXTerreserbaAmaieraOrdua.Text.ToString();

                er.gehitu();

                MessageBox.Show("ID seleccionado: " + CBeremua.SelectedValue.ToString());

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
            

            CBeremua.DataSource = dtEremua.Copy();
            CBeremua.DisplayMember = "izena";
            CBeremua.ValueMember = "idEremua";

          
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
