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
            this.BTN_Kudeatu = new System.Windows.Forms.Button();
            this.LBL_Kudeatu = new System.Windows.Forms.Label();
            this.LBL_Erreserba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNAtzera
            // 
            this.BTNAtzera.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAtzera.Location = new System.Drawing.Point(1712, 890);
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
            this.dataGridView1.Location = new System.Drawing.Point(97, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(838, 281);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CErreserba
            // 
            this.CErreserba.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CErreserba.FormattingEnabled = true;
            this.CErreserba.Location = new System.Drawing.Point(976, 152);
            this.CErreserba.Name = "CErreserba";
            this.CErreserba.Size = new System.Drawing.Size(252, 42);
            this.CErreserba.TabIndex = 16;
            // 
            // BTN_Kudeatu
            // 
            this.BTN_Kudeatu.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Kudeatu.Location = new System.Drawing.Point(1262, 152);
            this.BTN_Kudeatu.Name = "BTN_Kudeatu";
            this.BTN_Kudeatu.Size = new System.Drawing.Size(347, 42);
            this.BTN_Kudeatu.TabIndex = 18;
            this.BTN_Kudeatu.Text = "Erreserba Kudeatu";
            this.BTN_Kudeatu.UseVisualStyleBackColor = true;
            // 
            // LBL_Kudeatu
            // 
            this.LBL_Kudeatu.AutoSize = true;
            this.LBL_Kudeatu.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Kudeatu.Location = new System.Drawing.Point(970, 95);
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
            this.LBL_Erreserba.Location = new System.Drawing.Point(91, 95);
            this.LBL_Erreserba.Name = "LBL_Erreserba";
            this.LBL_Erreserba.Size = new System.Drawing.Size(283, 36);
            this.LBL_Erreserba.TabIndex = 20;
            this.LBL_Erreserba.Text = "Zure erreserbak:";
            // 
            // erreserbaKudeatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 959);
            this.Controls.Add(this.LBL_Erreserba);
            this.Controls.Add(this.LBL_Kudeatu);
            this.Controls.Add(this.BTN_Kudeatu);
            this.Controls.Add(this.CErreserba);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNAtzera);
            this.Name = "erreserbaKudeatu";
            this.Text = "erreserbaKudeatu";
            this.Load += new System.EventHandler(this.erreserbaKudeatu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAtzera;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CErreserba;
        private System.Windows.Forms.Button BTN_Kudeatu;
        private System.Windows.Forms.Label LBL_Kudeatu;
        private System.Windows.Forms.Label LBL_Erreserba;
    }
}