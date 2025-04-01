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
    public partial class Menu : Form


    {
        private Kluba loggedInKluba;
        private Bazkidea loggedInBazkidea;


        public Menu(Kluba kluba = null, Bazkidea bazkidea = null)
        {
            InitializeComponent();
            this.loggedInKluba = kluba ?? new Kluba (999);
            this.loggedInBazkidea = bazkidea ?? new Bazkidea { idBazkidea = 999 };
        }

        private void erreserbakIkusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void armarria_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            armarria.Location = new Point(725, 20);
        }

        private void erreserbaEginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void zelaiakIkusiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordutegiakIkusiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eginToolStripMenuItem_Click(object sender, EventArgs e)
        {
   

            Bazkidea bazkidea = new Bazkidea(); 

            ErreserbaEgin erreserbaEgin = new ErreserbaEgin(loggedInKluba, loggedInBazkidea);
            erreserbaEgin.Show();
            this.Hide();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ikusiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            zelaiakIkusi zelaiakikusi = new zelaiakIkusi();
            zelaiakikusi.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ikusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Bazkidea: {(loggedInBazkidea != null ? loggedInBazkidea.idBazkidea.ToString() : "NULL")}, " +
                $"Kluba: {(loggedInKluba != null ? loggedInKluba.idKluba.ToString() : "NULL")}");
            
            ErreserbaIkusi erIk = new ErreserbaIkusi(loggedInKluba, loggedInBazkidea);
            erIk.Show();
            this.Hide();
        }

        private void ezabatuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            erreserbaEzabatu erEz = new erreserbaEzabatu(loggedInKluba, loggedInBazkidea);
            erEz.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
