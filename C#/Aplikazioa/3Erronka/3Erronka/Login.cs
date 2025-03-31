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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0, 0);
            LBLIdentifikadorea.Location = new Point(420, 300);
            TXTIdentifikadorea.Location = new Point(755, 300);
            LBLPasahitza.Location = new Point(420, 350);
            TXTPasahitza.Location = new Point(755, 350);
            BTNSaioaHasi.Location = new Point(1310, 735);
        }

        private void BTNSaioaHasi_Click(object sender, EventArgs e)
        {
            Bazkidea b = new Bazkidea();
            b.Identifikadorea = TXTIdentifikadorea.Text;
            b.Pasahitza = TXTPasahitza.Text;

            Kluba kl = new Kluba(0);
            kl.Identifikadorea = TXTIdentifikadorea.Text;
            kl.Pasahitza = TXTPasahitza.Text;

            if (b.bazkideLogina())
            {
                MessageBox.Show($"Ongi etorri, bazkidea!");
                Menu men = new Menu();
                men.Show();
                this.Hide();
            }
            else if (kl.klubLogina())
            {
                MessageBox.Show($"Ongi etorri, kluba!");
                Menu men = new Menu(kl);
                men.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Identifikadorea edo pasahitza ez dira zuzenak.");
            }
        }


        private void TXTPasahitza_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

