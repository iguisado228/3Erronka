namespace _3Erronka
{
    partial class kanpokoEskubaloiPista
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
            this.BTNAtzera.TabIndex = 14;
            this.BTNAtzera.Text = "Atzera joan";
            this.BTNAtzera.UseVisualStyleBackColor = true;
            this.BTNAtzera.Click += new System.EventHandler(this.BTNAtzera_Click);
            // 
            // kanpokoEskubaloiPista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 959);
            this.Controls.Add(this.BTNAtzera);
            this.Name = "kanpokoEskubaloiPista";
            this.Text = "kanpokoEskubaloiPista";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNAtzera;
    }
}