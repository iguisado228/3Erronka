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
            LBLAgurra.Location = new Point(560, 40);
        }

        private void BTNSaioaHasi_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }
    }
}
