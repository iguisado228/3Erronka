namespace _3Erronka
{
    partial class erreserbaKudeatu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNAtzera = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CErreserba = new System.Windows.Forms.ComboBox();
            this.LBL_Kudeatu = new System.Windows.Forms.Label();
            this.LBL_Erreserba = new System.Windows.Forms.Label();
            this.LBL_eremua = new System.Windows.Forms.Label();
            this.LBL_hasieraOrdua = new System.Windows.Forms.Label();
            this.CBeremua = new System.Windows.Forms.ComboBox();
            this.DTP_Eguna = new System.Windows.Forms.DateTimePicker();
            this.LBL_erreserbaEguna = new System.Windows.Forms.Label();
            this.BTN_erreserbaEguneratu = new System.Windows.Forms.Button();
            this.CBOrduaEgun = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNAtzera
            // 
            this.BTNAtzera.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAtzera.Location = new System.Drawing.Point(1712, 890);
            this.BTNAtzera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNAtzera.Name = "BTNAtzera";
            this.BTNAtzera.Size = new System.Drawing.Size(155, 43);
            this.BTNAtzera.TabIndex = 14;
            this.BTNAtzera.Text = "Atzera joan";
            this.BTNAtzera.UseVisualStyleBackColor = true;
            this.BTNAtzera.Click += new System.EventHandler(this.BTNAtzera_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 275);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1075, 281);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CErreserba
            // 
            this.CErreserba.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CErreserba.FormattingEnabled = true;
            this.CErreserba.Location = new System.Drawing.Point(1267, 162);
            this.CErreserba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CErreserba.Name = "CErreserba";
            this.CErreserba.Size = new System.Drawing.Size(252, 42);
            this.CErreserba.TabIndex = 16;
            this.CErreserba.SelectedIndexChanged += new System.EventHandler(this.CErreserba_SelectedIndexChanged);
            // 
            // LBL_Kudeatu
            // 
            this.LBL_Kudeatu.AutoSize = true;
            this.LBL_Kudeatu.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Kudeatu.Location = new System.Drawing.Point(1260, 105);
            this.LBL_Kudeatu.Name = "LBL_Kudeatu";
            this.LBL_Kudeatu.Size = new System.Drawing.Size(663, 36);
            this.LBL_Kudeatu.TabIndex = 19;
            this.LBL_Kudeatu.Text = "Aukeratu kudeatu nahi duzun erreserba";
            this.LBL_Kudeatu.Click += new System.EventHandler(this.label2_Click);
            // 
            // LBL_Erreserba
            // 
            this.LBL_Erreserba.AutoSize = true;
            this.LBL_Erreserba.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Erreserba.Location = new System.Drawing.Point(96, 224);
            this.LBL_Erreserba.Name = "LBL_Erreserba";
            this.LBL_Erreserba.Size = new System.Drawing.Size(283, 36);
            this.LBL_Erreserba.TabIndex = 20;
            this.LBL_Erreserba.Text = "Zure erreserbak:";
            // 
            // LBL_eremua
            // 
            this.LBL_eremua.AutoSize = true;
            this.LBL_eremua.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_eremua.Location = new System.Drawing.Point(1261, 391);
            this.LBL_eremua.Name = "LBL_eremua";
            this.LBL_eremua.Size = new System.Drawing.Size(146, 36);
            this.LBL_eremua.TabIndex = 21;
            this.LBL_eremua.Text = "Eremua:";
            // 
            // LBL_hasieraOrdua
            // 
            this.LBL_hasieraOrdua.AutoSize = true;
            this.LBL_hasieraOrdua.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_hasieraOrdua.Location = new System.Drawing.Point(1261, 275);
            this.LBL_hasieraOrdua.Name = "LBL_hasieraOrdua";
            this.LBL_hasieraOrdua.Size = new System.Drawing.Size(125, 36);
            this.LBL_hasieraOrdua.TabIndex = 22;
            this.LBL_hasieraOrdua.Text = "Ordua:";
            this.LBL_hasieraOrdua.Click += new System.EventHandler(this.LBL_hasieraOrdua_Click);
            // 
            // CBeremua
            // 
            this.CBeremua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBeremua.FormattingEnabled = true;
            this.CBeremua.Location = new System.Drawing.Point(1423, 393);
            this.CBeremua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBeremua.Name = "CBeremua";
            this.CBeremua.Size = new System.Drawing.Size(239, 37);
            this.CBeremua.TabIndex = 24;
            this.CBeremua.SelectedIndexChanged += new System.EventHandler(this.CBeremua_SelectedIndexChanged);
            // 
            // DTP_Eguna
            // 
            this.DTP_Eguna.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Eguna.Location = new System.Drawing.Point(1565, 470);
            this.DTP_Eguna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTP_Eguna.Name = "DTP_Eguna";
            this.DTP_Eguna.Size = new System.Drawing.Size(352, 37);
            this.DTP_Eguna.TabIndex = 27;
            this.DTP_Eguna.ValueChanged += new System.EventHandler(this.DTP_Eguna_ValueChanged);
            // 
            // LBL_erreserbaEguna
            // 
            this.LBL_erreserbaEguna.AutoSize = true;
            this.LBL_erreserbaEguna.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_erreserbaEguna.Location = new System.Drawing.Point(1261, 471);
            this.LBL_erreserbaEguna.Name = "LBL_erreserbaEguna";
            this.LBL_erreserbaEguna.Size = new System.Drawing.Size(288, 36);
            this.LBL_erreserbaEguna.TabIndex = 28;
            this.LBL_erreserbaEguna.Text = "Erreserba Eguna:";
            this.LBL_erreserbaEguna.Click += new System.EventHandler(this.LBL_erreserbaEguna_Click);
            // 
            // BTN_erreserbaEguneratu
            // 
            this.BTN_erreserbaEguneratu.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_erreserbaEguneratu.Location = new System.Drawing.Point(1266, 559);
            this.BTN_erreserbaEguneratu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_erreserbaEguneratu.Name = "BTN_erreserbaEguneratu";
            this.BTN_erreserbaEguneratu.Size = new System.Drawing.Size(437, 42);
            this.BTN_erreserbaEguneratu.TabIndex = 30;
            this.BTN_erreserbaEguneratu.Text = "Erreserba Eguneratu";
            this.BTN_erreserbaEguneratu.UseVisualStyleBackColor = true;
            this.BTN_erreserbaEguneratu.Click += new System.EventHandler(this.BTN_erreserbaEguneratu_Click);
            // 
            // CBOrduaEgun
            // 
            this.CBOrduaEgun.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOrduaEgun.FormattingEnabled = true;
            this.CBOrduaEgun.Location = new System.Drawing.Point(1413, 275);
            this.CBOrduaEgun.Name = "CBOrduaEgun";
            this.CBOrduaEgun.Size = new System.Drawing.Size(152, 44);
            this.CBOrduaEgun.TabIndex = 31;
            // 
            // erreserbaKudeatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 959);
            this.Controls.Add(this.CBOrduaEgun);
            this.Controls.Add(this.BTN_erreserbaEguneratu);
            this.Controls.Add(this.LBL_erreserbaEguna);
            this.Controls.Add(this.DTP_Eguna);
            this.Controls.Add(this.CBeremua);
            this.Controls.Add(this.LBL_hasieraOrdua);
            this.Controls.Add(this.LBL_eremua);
            this.Controls.Add(this.LBL_Erreserba);
            this.Controls.Add(this.LBL_Kudeatu);
            this.Controls.Add(this.CErreserba);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNAtzera);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "erreserbaKudeatu";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.erreserbaKudeatu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAtzera;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CErreserba;
        private System.Windows.Forms.Label LBL_Kudeatu;
        private System.Windows.Forms.Label LBL_Erreserba;
        private System.Windows.Forms.Label LBL_eremua;
        private System.Windows.Forms.Label LBL_hasieraOrdua;
        private System.Windows.Forms.ComboBox CBeremua;
        private System.Windows.Forms.DateTimePicker DTP_Eguna;
        private System.Windows.Forms.Label LBL_erreserbaEguna;
        private System.Windows.Forms.Button BTN_erreserbaEguneratu;
        private System.Windows.Forms.ComboBox CBOrduaEgun;
    }
}