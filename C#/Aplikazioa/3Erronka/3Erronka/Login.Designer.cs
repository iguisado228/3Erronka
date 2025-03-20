namespace _3Erronka
{
    partial class Login
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
            this.LBLIdentifikadorea = new System.Windows.Forms.Label();
            this.LBLPasahitza = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXTIdentifikadorea = new System.Windows.Forms.TextBox();
            this.TXTPasahitza = new System.Windows.Forms.TextBox();
            this.BTNSaioaHasi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLIdentifikadorea
            // 
            this.LBLIdentifikadorea.AutoSize = true;
            this.LBLIdentifikadorea.Font = new System.Drawing.Font("Lucida Fax", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLIdentifikadorea.Location = new System.Drawing.Point(172, 355);
            this.LBLIdentifikadorea.Name = "LBLIdentifikadorea";
            this.LBLIdentifikadorea.Size = new System.Drawing.Size(409, 54);
            this.LBLIdentifikadorea.TabIndex = 0;
            this.LBLIdentifikadorea.Text = "Identifikadorea";
            // 
            // LBLPasahitza
            // 
            this.LBLPasahitza.AutoSize = true;
            this.LBLPasahitza.Font = new System.Drawing.Font("Lucida Fax", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPasahitza.Location = new System.Drawing.Point(300, 464);
            this.LBLPasahitza.Name = "LBLPasahitza";
            this.LBLPasahitza.Size = new System.Drawing.Size(261, 54);
            this.LBLPasahitza.TabIndex = 1;
            this.LBLPasahitza.Text = "Pasahitza";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3Erronka.Properties.Resources.BuruntzaldeaLogoa;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 221);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TXTIdentifikadorea
            // 
            this.TXTIdentifikadorea.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTIdentifikadorea.Location = new System.Drawing.Point(587, 366);
            this.TXTIdentifikadorea.Name = "TXTIdentifikadorea";
            this.TXTIdentifikadorea.Size = new System.Drawing.Size(276, 43);
            this.TXTIdentifikadorea.TabIndex = 3;
            // 
            // TXTPasahitza
            // 
            this.TXTPasahitza.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPasahitza.Location = new System.Drawing.Point(587, 475);
            this.TXTPasahitza.Name = "TXTPasahitza";
            this.TXTPasahitza.Size = new System.Drawing.Size(276, 43);
            this.TXTPasahitza.TabIndex = 4;
            // 
            // BTNSaioaHasi
            // 
            this.BTNSaioaHasi.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSaioaHasi.Location = new System.Drawing.Point(1628, 700);
            this.BTNSaioaHasi.Name = "BTNSaioaHasi";
            this.BTNSaioaHasi.Size = new System.Drawing.Size(284, 50);
            this.BTNSaioaHasi.TabIndex = 5;
            this.BTNSaioaHasi.Text = "Saioa hasi";
            this.BTNSaioaHasi.UseVisualStyleBackColor = true;
            this.BTNSaioaHasi.Click += new System.EventHandler(this.BTNSaioaHasi_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 762);
            this.Controls.Add(this.BTNSaioaHasi);
            this.Controls.Add(this.TXTPasahitza);
            this.Controls.Add(this.TXTIdentifikadorea);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBLPasahitza);
            this.Controls.Add(this.LBLIdentifikadorea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ongi etorri gure programara!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLIdentifikadorea;
        private System.Windows.Forms.Label LBLPasahitza;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXTIdentifikadorea;
        private System.Windows.Forms.TextBox TXTPasahitza;
        private System.Windows.Forms.Button BTNSaioaHasi;
    }
}