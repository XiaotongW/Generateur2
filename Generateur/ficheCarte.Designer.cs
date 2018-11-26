namespace Generateur
{
    partial class ficheCarte
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
            this.picCarteMonde = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCarteMonde)).BeginInit();
            this.SuspendLayout();
            // 
            // picCarteMonde
            // 
            this.picCarteMonde.ImageLocation = "carte_du_monde.jpg";
            this.picCarteMonde.Location = new System.Drawing.Point(12, 12);
            this.picCarteMonde.Name = "picCarteMonde";
            this.picCarteMonde.Size = new System.Drawing.Size(14, 16);
            this.picCarteMonde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCarteMonde.TabIndex = 0;
            this.picCarteMonde.TabStop = false;
            // 
            // ficheCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 553);
            this.Controls.Add(this.picCarteMonde);
            this.Name = "ficheCarte";
            this.Text = "ficheCarte";
            ((System.ComponentModel.ISupportInitialize)(this.picCarteMonde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCarteMonde;
    }
}