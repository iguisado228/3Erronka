﻿namespace _3Erronka
{
    partial class erreserbaEzabatu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Atzera = new System.Windows.Forms.Button();
            this.CErreserba = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Ezabatu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(838, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zure erreserbak:";
            // 
            // BTN_Atzera
            // 
            this.BTN_Atzera.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Atzera.Location = new System.Drawing.Point(1690, 896);
            this.BTN_Atzera.Name = "BTN_Atzera";
            this.BTN_Atzera.Size = new System.Drawing.Size(222, 51);
            this.BTN_Atzera.TabIndex = 2;
            this.BTN_Atzera.Text = "Atzera joan";
            this.BTN_Atzera.UseVisualStyleBackColor = true;
            this.BTN_Atzera.Click += new System.EventHandler(this.BTN_Atzera_Click);
            // 
            // CErreserba
            // 
            this.CErreserba.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CErreserba.FormattingEnabled = true;
            this.CErreserba.Location = new System.Drawing.Point(1024, 165);
            this.CErreserba.Name = "CErreserba";
            this.CErreserba.Size = new System.Drawing.Size(251, 42);
            this.CErreserba.TabIndex = 3;
            this.CErreserba.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1018, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(657, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aukeratu ezabatu nahi duzun erreserba";
            // 
            // BTN_Ezabatu
            // 
            this.BTN_Ezabatu.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ezabatu.Location = new System.Drawing.Point(1342, 164);
            this.BTN_Ezabatu.Name = "BTN_Ezabatu";
            this.BTN_Ezabatu.Size = new System.Drawing.Size(347, 42);
            this.BTN_Ezabatu.TabIndex = 5;
            this.BTN_Ezabatu.Text = "Ezabatu erreserba";
            this.BTN_Ezabatu.UseVisualStyleBackColor = true;
            this.BTN_Ezabatu.Click += new System.EventHandler(this.BTN_Ezabatu_Click);
            // 
            // erreserbaEzabatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 959);
            this.Controls.Add(this.BTN_Ezabatu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CErreserba);
            this.Controls.Add(this.BTN_Atzera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "erreserbaEzabatu";
            this.Text = "erreserbaEzabatu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.erreserbaEzabatu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Atzera;
        private System.Windows.Forms.ComboBox CErreserba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Ezabatu;
    }
}