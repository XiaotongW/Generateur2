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
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
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
            this.picCarteMonde.Paint += new System.Windows.Forms.PaintEventHandler(this.picCarteMonde_Paint);
            this.picCarteMonde.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCarteMonde_MouseClick);
            // 
            // cmdOK
            // 
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(12, 545);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 1;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnuler.Location = new System.Drawing.Point(93, 545);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(75, 23);
            this.cmdAnnuler.TabIndex = 2;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            // 
            // txtPosition
            // 
            this.txtPosition.Enabled = false;
            this.txtPosition.Location = new System.Drawing.Point(175, 547);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(143, 20);
            this.txtPosition.TabIndex = 3;
            // 
            // ficheCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 571);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.picCarteMonde);
            this.MaximumSize = new System.Drawing.Size(1040, 610);
            this.MinimumSize = new System.Drawing.Size(1040, 610);
            this.Name = "ficheCarte";
            this.Text = "ficheCarte";
            ((System.ComponentModel.ISupportInitialize)(this.picCarteMonde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCarteMonde;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.TextBox txtPosition;
    }
}