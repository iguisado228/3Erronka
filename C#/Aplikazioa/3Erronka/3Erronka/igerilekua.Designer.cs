namespace _3Erronka
{
    partial class igerilekua
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
            this.SuspendLayout();
            // 
            // BTNAtzera
            // 
            this.BTNAtzera.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAtzera.Location = new System.Drawing.Point(1757, 904);
            this.BTNAtzera.Name = "BTNAtzera";
            this.BTNAtzera.Size = new System.Drawing.Size(155, 43);
            this.BTNAtzera.TabIndex = 13;
            this.BTNAtzera.Text = "Atzera joan";
            this.BTNAtzera.UseVisualStyleBackColor = true;
            this.BTNAtzera.Click += new System.EventHandler(this.BTNAtzera_Click);
            // 
            // igerilekua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 959);
            this.Controls.Add(this.BTNAtzera);
            this.Name = "igerilekua";
            this.Text = "igerilekua";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.igerilekua_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNAtzera;
    }
}