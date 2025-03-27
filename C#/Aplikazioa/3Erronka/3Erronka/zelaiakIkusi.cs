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
        public zelaiakIkusi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gimnasioa gimnasioa = new Gimnasioa();
            gimnasioa.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            futbolZelaia futbolzelaia = new futbolZelaia();
            futbolzelaia.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eskubaloiPista eskubaloipista = new eskubaloiPista();
            eskubaloipista.Show();
            this.Hide();
        }

        private void zelaiakIkusi_Load(object sender, EventArgs e)
        {

        }

        private void BTNtenisZelaia_Click(object sender, EventArgs e)
        {
            tenisZelaia teniszelaia = new tenisZelaia();
            teniszelaia.Show();
            this.Hide();
        }

        private void BTNigerilekua_Click(object sender, EventArgs e)
        {
            igerilekua igerilekua = new igerilekua();
            igerilekua.Show();
            this.Hide();
        }

        private void BTNsaskibaloiPista_Click(object sender, EventArgs e)
        {
            saskibaloiPista saskibaloiPista = new saskibaloiPista();
            saskibaloiPista.Show();
            this.Hide();
        }

        private void BTNatletismoPista_Click(object sender, EventArgs e)
        {
            atletismoPista atletismopista = new atletismoPista();
            atletismopista.Show();
            this.Hide();
        }

        private void BTNkanpokoSaskibaloiPista_Click(object sender, EventArgs e)
        {
            kanpokoSaskibaloiPista ksaskibaloipista = new kanpokoSaskibaloiPista();
            ksaskibaloipista.Show();
            this.Hide();
        }

        private void BTNkanpokoEskubaloiPista_Click(object sender, EventArgs e)
        {
            kanpokoEskubaloiPista keskubaloipista = new kanpokoEskubaloiPista();
            keskubaloipista.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }
    }
}
