﻿namespace _3Erronka
{
    partial class ErreserbaEgin
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
            this.LBLerreserba = new System.Windows.Forms.Label();
            this.LBLerreserbaEguna = new System.Windows.Forms.Label();
            this.DTPEguna = new System.Windows.Forms.DateTimePicker();
            this.LBLH_ordua = new System.Windows.Forms.Label();
            this.BTNErreserba = new System.Windows.Forms.Button();
            this.LBLEremua = new System.Windows.Forms.Label();
            this.CBeremua = new System.Windows.Forms.ComboBox();
            this.BTNAtzera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LBL_erreserbatutakoZelaiak = new System.Windows.Forms.Label();
            this.TXTerreserbaHasieraOrdua = new System.Windows.Forms.TextBox();
            this.TXTerreserbaAmaieraOrdua = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLerreserba
            // 
            this.LBLerreserba.AutoSize = true;
            this.LBLerreserba.Font = new System.Drawing.Font("Lucida Fax", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLerreserba.Location = new System.Drawing.Point(787, 18);
            this.LBLerreserba.Name = "LBLerreserba";
            this.LBLerreserba.Size = new System.Drawing.Size(385, 54);
            this.LBLerreserba.TabIndex = 0;
            this.LBLerreserba.Text = "Erreserba egin";
            // 
            // LBLerreserbaEguna
            // 
            this.LBLerreserbaEguna.AutoSize = true;
            this.LBLerreserbaEguna.Font = new System.Drawing.Font("Lucida Fax", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLerreserbaEguna.Location = new System.Drawing.Point(129, 252);
            this.LBLerreserbaEguna.Name = "LBLerreserbaEguna";
            this.LBLerreserbaEguna.Size = new System.Drawing.Size(418, 54);
            this.LBLerreserbaEguna.TabIndex = 1;
            this.LBLerreserbaEguna.Text = "Erreserba eguna:";
            this.LBLerreserbaEguna.Click += new System.EventHandler(this.LBLerreserbaEguna_Click);
            // 
            // DTPEguna
            // 
            this.DTPEguna.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPEguna.Location = new System.Drawing.Point(612, 267);
            this.DTPEguna.Name = "DTPEguna";
            this.DTPEguna.Size = new System.Drawing.Size(352, 37);
            this.DTPEguna.TabIndex = 2;
            this.DTPEguna.ValueChanged += new System.EventHandler(this.DTPEguna_ValueChanged);
            // 
            // LBLH_ordua
            // 
            this.LBLH_ordua.AutoSize = true;
            this.LBLH_ordua.Font = new System.Drawing.Font("Lucida Fax", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLH_ordua.Location = new System.Drawing.Point(129, 469);
            this.LBLH_ordua.Name = "LBLH_ordua";
            this.LBLH_ordua.Size = new System.Drawing.Size(368, 54);
            this.LBLH_ordua.TabIndex = 3;
            this.LBLH_ordua.Text = "Hasiera ordua:";
            // 
            // BTNErreserba
            // 
            this.BTNErreserba.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNErreserba.Location = new System.Drawing.Point(1799, 18);
            this.BTNErreserba.Name = "BTNErreserba";
            this.BTNErreserba.Size = new System.Drawing.Size(224, 47);
            this.BTNErreserba.TabIndex = 7;
            this.BTNErreserba.Text = "Erreserbatu";
            this.BTNErreserba.UseVisualStyleBackColor = true;
            this.BTNErreserba.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBLEremua
            // 
            this.LBLEremua.AutoSize = true;
            this.LBLEremua.Font = new System.Drawing.Font("Lucida Fax", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEremua.Location = new System.Drawing.Point(1014, 250);
            this.LBLEremua.Name = "LBLEremua";
            this.LBLEremua.Size = new System.Drawing.Size(898, 54);
            this.LBLEremua.TabIndex = 9;
            this.LBLEremua.Text = "Aukeratu erabiliko duzun eremua: ";
            // 
            // CBeremua
            // 
            this.CBeremua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBeremua.FormattingEnabled = true;
            this.CBeremua.Location = new System.Drawing.Point(1023, 319);
            this.CBeremua.Name = "CBeremua";
            this.CBeremua.Size = new System.Drawing.Size(238, 37);
            this.CBeremua.TabIndex = 11;
            this.CBeremua.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BTNAtzera
            // 
            this.BTNAtzera.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAtzera.Location = new System.Drawing.Point(1854, 904);
            this.BTNAtzera.Name = "BTNAtzera";
            this.BTNAtzera.Size = new System.Drawing.Size(155, 43);
            this.BTNAtzera.TabIndex = 12;
            this.BTNAtzera.Text = "Atzera joan";
            this.BTNAtzera.UseVisualStyleBackColor = true;
            this.BTNAtzera.Click += new System.EventHandler(this.BTNAtzera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 736);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 54);
            this.label1.TabIndex = 14;
            this.label1.Text = "Amaiera ordua:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1023, 508);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(822, 192);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LBL_erreserbatutakoZelaiak
            // 
            this.LBL_erreserbatutakoZelaiak.AutoSize = true;
            this.LBL_erreserbatutakoZelaiak.Font = new System.Drawing.Font("Lucida Fax", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_erreserbatutakoZelaiak.Location = new System.Drawing.Point(1014, 439);
            this.LBL_erreserbatutakoZelaiak.Name = "LBL_erreserbatutakoZelaiak";
            this.LBL_erreserbatutakoZelaiak.Size = new System.Drawing.Size(633, 54);
            this.LBL_erreserbatutakoZelaiak.TabIndex = 18;
            this.LBL_erreserbatutakoZelaiak.Text = "Erreserbatutako zelaiak:";
            // 
            // TXTerreserbaHasieraOrdua
            // 
            this.TXTerreserbaHasieraOrdua.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTerreserbaHasieraOrdua.Location = new System.Drawing.Point(536, 480);
            this.TXTerreserbaHasieraOrdua.Name = "TXTerreserbaHasieraOrdua";
            this.TXTerreserbaHasieraOrdua.Size = new System.Drawing.Size(245, 43);
            this.TXTerreserbaHasieraOrdua.TabIndex = 19;
            this.TXTerreserbaHasieraOrdua.TextChanged += new System.EventHandler(this.TXTerreserbaHasieraOrdua_TextChanged);
            // 
            // TXTerreserbaAmaieraOrdua
            // 
            this.TXTerreserbaAmaieraOrdua.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTerreserbaAmaieraOrdua.Location = new System.Drawing.Point(536, 747);
            this.TXTerreserbaAmaieraOrdua.Name = "TXTerreserbaAmaieraOrdua";
            this.TXTerreserbaAmaieraOrdua.Size = new System.Drawing.Size(245, 43);
            this.TXTerreserbaAmaieraOrdua.TabIndex = 20;
            // 
            // ErreserbaEgin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 959);
            this.Controls.Add(this.TXTerreserbaAmaieraOrdua);
            this.Controls.Add(this.TXTerreserbaHasieraOrdua);
            this.Controls.Add(this.LBL_erreserbatutakoZelaiak);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNAtzera);
            this.Controls.Add(this.CBeremua);
            this.Controls.Add(this.LBLEremua);
            this.Controls.Add(this.BTNErreserba);
            this.Controls.Add(this.LBLH_ordua);
            this.Controls.Add(this.DTPEguna);
            this.Controls.Add(this.LBLerreserbaEguna);
            this.Controls.Add(this.LBLerreserba);
            this.Name = "ErreserbaEgin";
            this.Text = "Erreserba";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Erreserba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLerreserba;
        private System.Windows.Forms.Label LBLerreserbaEguna;
        private System.Windows.Forms.DateTimePicker DTPEguna;
        private System.Windows.Forms.Label LBLH_ordua;
        private System.Windows.Forms.Button BTNErreserba;
        private System.Windows.Forms.Label LBLEremua;
        private System.Windows.Forms.ComboBox CBeremua;
        private System.Windows.Forms.Button BTNAtzera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LBL_erreserbatutakoZelaiak;
        private System.Windows.Forms.TextBox TXTerreserbaHasieraOrdua;
        private System.Windows.Forms.TextBox TXTerreserbaAmaieraOrdua;
    }
}