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
        public Menu()
        {
            InitializeComponent();
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
            ErreserbaEgin egin = new ErreserbaEgin();
            egin.Show();

        }
    }
}
