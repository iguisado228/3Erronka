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
                er.erreserbaOrdua = TXTH_ordua.Text;
                er.erreserbaAmaieraOrdua = TXTA_ordua.Text;
    
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
            LBLerreserba.Location = new Point(610, 30);
            BTNErreserba.Location = new Point(1310, 735);
            LBLerreserbaEguna.Location = new Point(20, 200);
            LBLH_ordua.Location = new Point(20,275);
            LBLA_ordua.Location = new Point(20, 350);
            LBLEremua.Location = new Point(820, 200);

            DTPEguna.Location = new Point(350, 210);
            TXTH_ordua.Location = new Point(350, 285);
            TXTA_ordua.Location = new Point(520, 360);

            Erreserba er = new Erreserba();

            CBeremua.DataSource = er.bilaketak("SELECT izena FROM eremua");
            CBeremua.DisplayMember = "izena";
            CBeremua.ValueMember = "izena"; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
