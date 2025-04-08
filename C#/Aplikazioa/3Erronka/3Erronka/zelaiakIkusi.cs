using Konexioa;
using MySql.Data.MySqlClient;
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
        private int idEremua;

        internal zelaiakIkusi(Kluba kluba, Bazkidea bazkidea)
        {
            InitializeComponent();
            this.loggedInKluba = kluba;
            this.loggedInBazkidea = bazkidea;


        }

        private void zelaiakIkusi_Load(object sender, EventArgs e)
        {
            DGV_gimnasioa.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            DGV_atletismo.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            DGV_eskubaloia.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            DGV_futbol.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            DGV_igerilekua.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            DGV_kanpoEskubaloia.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            DGV_kanpoSaskibaloia.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            DGV_saskibaloia.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            DGV_tenis.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            foreach (Control control in this.Controls)
            {
                if (control is DataGridView dgv)
                {
                    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.ReadOnly = true;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }

            zelaiakSelect(1, DGV_gimnasioa);     
            zelaiakSelect(2, DGV_futbol);    
            zelaiakSelect(3, DGV_igerilekua);    
            zelaiakSelect(4, DGV_tenis);        
            zelaiakSelect(5, DGV_eskubaloia);    
            zelaiakSelect(6, DGV_saskibaloia); 
            zelaiakSelect(7, DGV_atletismo); 
            zelaiakSelect(8, DGV_kanpoSaskibaloia);    
            zelaiakSelect(9, DGV_kanpoEskubaloia);



        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu men = new Menu(loggedInKluba, loggedInBazkidea);
            men.Show();
            this.Hide();
        }

        private void zelaiakSelect(int idEremua, DataGridView dataGridView)
        {
            try
            {
                string query = @"SELECT 
                    e.idErreserba AS 'Erreserba IDa',
                    er.izena AS 'Eremua',
                    e.erreserbaEguna AS 'Eguna',
                    CONCAT(7 + e.ordua, ':00 - ', 7 + e.ordua + 1, ':00') AS 'Ordua'
                    FROM erreserba e
                    JOIN eremua er ON e.idEremua = er.idEremua
                    LEFT JOIN kluba k ON e.idKluba = k.idKluba
                    LEFT JOIN bazkidea b ON e.idBazkidea = b.idBazkidea
                    WHERE e.idEremua = @idEremua
                    ORDER BY e.erreserbaEguna, e.ordua";

                Konexioa.Konexioa K = new Konexioa.Konexioa();
                K.konektatu();
                MySqlCommand command = new MySqlCommand(query, K.conn);
                command.Parameters.AddWithValue("@idEremua", idEremua);

                DataTable det = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(det);

                dataGridView.DataSource = det; 

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Arazoa erreserbak kargatzean: " + ex.Message);
            }

        }

        private void DGV_gimnasioa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
