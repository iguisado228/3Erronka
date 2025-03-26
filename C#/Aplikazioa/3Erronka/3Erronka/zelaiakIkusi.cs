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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            futbolZelaia futbolzelaia = new futbolZelaia();
            futbolzelaia.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eskubaloiPista eskubaloipista = new eskubaloiPista();
            eskubaloipista.Show();
        }

        private void zelaiakIkusi_Load(object sender, EventArgs e)
        {

        }

        private void BTNtenisZelaia_Click(object sender, EventArgs e)
        {
            tenisZelaia teniszelaia = new tenisZelaia();
            teniszelaia.Show();
        }

        private void BTNigerilekua_Click(object sender, EventArgs e)
        {
            igerilekua igerilekua = new igerilekua();
            igerilekua.Show();
        }

        private void BTNsaskibaloiPista_Click(object sender, EventArgs e)
        {
            saskibaloiPista saskibaloiPista = new saskibaloiPista();
            saskibaloiPista.Show();
        }

        private void BTNatletismoPista_Click(object sender, EventArgs e)
        {
            atletismoPista atletismopista = new atletismoPista();
            atletismopista.Show();
        }

        private void BTNkanpokoSaskibaloiPista_Click(object sender, EventArgs e)
        {
            kanpokoSaskibaloiPista ksaskibaloipista = new kanpokoSaskibaloiPista();
            ksaskibaloipista.Show();
        }

        private void BTNkanpokoEskubaloiPista_Click(object sender, EventArgs e)
        {
            kanpokoEskubaloiPista keskubaloipista = new kanpokoEskubaloiPista();
            keskubaloipista.Show();
        }
    }
}
