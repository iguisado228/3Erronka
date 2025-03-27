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
    public partial class futbolZelaia : Form
    {
        public futbolZelaia()
        {
            InitializeComponent();
        }

        private void futbolZelaia_Load(object sender, EventArgs e)
        {

        }

        private void BTNAtzera_Click(object sender, EventArgs e)
        {
            zelaiakIkusi zel = new zelaiakIkusi();
            zel.Show();
            this.Hide();
        }
    }
}
