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
    public partial class zelaiakIkusi : Form
    {
        private Kluba loggedInKluba;
        private Bazkidea loggedInBazkidea;

        internal zelaiakIkusi(Kluba kluba, Bazkidea bazkidea)
        {
            InitializeComponent();
            this.loggedInKluba = kluba;
            this.loggedInBazkidea = bazkidea;

            MessageBox.Show($"Kluba: {(kluba != null ? kluba.idKluba.ToString() : "NULL")}, " +
                            $"Bazkidea: {(bazkidea != null ? bazkidea.idBazkidea.ToString() : "NULL")}");
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void zelaiakIkusi_Load(object sender, EventArgs e)
        {

        }

        private void BTNtenisZelaia_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNigerilekua_Click(object sender, EventArgs e)
        {
        }

        private void BTNsaskibaloiPista_Click(object sender, EventArgs e)
        {
           
        }

        private void BTNatletismoPista_Click(object sender, EventArgs e)
        {
           
        }

        private void BTNkanpokoSaskibaloiPista_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNkanpokoEskubaloiPista_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu men = new Menu(loggedInKluba, loggedInBazkidea);
            men.Show();
            this.Hide();
        }
    }
}
