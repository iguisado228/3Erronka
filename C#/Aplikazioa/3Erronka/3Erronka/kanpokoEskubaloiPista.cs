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
    public partial class kanpokoEskubaloiPista : Form
    {
        public kanpokoEskubaloiPista()
        {
            InitializeComponent();
        }

        private void BTNAtzera_Click(object sender, EventArgs e)
        {
            zelaiakIkusi zel = new zelaiakIkusi();
            zel.Show();
            this.Hide();
        }
    }
}
