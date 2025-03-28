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
    public partial class ErreserbaIkusi : Form
    {
        public ErreserbaIkusi()
        {
            InitializeComponent();
        }

        private void ErreserbaIkusi_Load(object sender, EventArgs e)
        {
            
        }

        private void BTNAtzera_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }
    }
}
