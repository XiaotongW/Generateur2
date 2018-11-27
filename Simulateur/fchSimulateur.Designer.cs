namespace Simulateur
{
	partial class fchSimulateur
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupAeroport = new System.Windows.Forms.GroupBox();
            this.groupClient = new System.Windows.Forms.GroupBox();
            this.groupAvions = new System.Windows.Forms.GroupBox();
            this.lstAeroport = new System.Windows.Forms.DataGridView();
            this.lstClient = new System.Windows.Forms.DataGridView();
            this.lstAvion = new System.Windows.Forms.DataGridView();
            this.cmdPause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupAeroport.SuspendLayout();
            this.groupClient.SuspendLayout();
            this.groupAvions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstAeroport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAvion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Simulateur.Resource.carte_du_monde;
            this.pictureBox1.Location = new System.Drawing.Point(22, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(998, 533);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupAeroport
            // 
            this.groupAeroport.Controls.Add(this.lstAeroport);
            this.groupAeroport.Location = new System.Drawing.Point(38, 64);
            this.groupAeroport.Name = "groupAeroport";
            this.groupAeroport.Size = new System.Drawing.Size(216, 137);
            this.groupAeroport.TabIndex = 1;
            this.groupAeroport.TabStop = false;
            this.groupAeroport.Text = "Aéroport";
            // 
            // groupClient
            // 
            this.groupClient.Controls.Add(this.lstClient);
            this.groupClient.Location = new System.Drawing.Point(296, 64);
            this.groupClient.Name = "groupClient";
            this.groupClient.Size = new System.Drawing.Size(312, 137);
            this.groupClient.TabIndex = 2;
            this.groupClient.TabStop = false;
            this.groupClient.Text = "Clients";
            // 
            // groupAvions
            // 
            this.groupAvions.Controls.Add(this.lstAvion);
            this.groupAvions.Location = new System.Drawing.Point(655, 64);
            this.groupAvions.Name = "groupAvions";
            this.groupAvions.Size = new System.Drawing.Size(365, 137);
            this.groupAvions.TabIndex = 3;
            this.groupAvions.TabStop = false;
            this.groupAvions.Text = "Avions";
            // 
            // lstAeroport
            // 
            this.lstAeroport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstAeroport.Location = new System.Drawing.Point(6, 19);
            this.lstAeroport.Name = "lstAeroport";
            this.lstAeroport.Size = new System.Drawing.Size(204, 112);
            this.lstAeroport.TabIndex = 0;
            // 
            // lstClient
            // 
            this.lstClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstClient.Location = new System.Drawing.Point(6, 19);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(300, 112);
            this.lstClient.TabIndex = 1;
            // 
            // lstAvion
            // 
            this.lstAvion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstAvion.Location = new System.Drawing.Point(6, 19);
            this.lstAvion.Name = "lstAvion";
            this.lstAvion.Size = new System.Drawing.Size(353, 112);
            this.lstAvion.TabIndex = 2;
            // 
            // cmdPause
            // 
            this.cmdPause.Location = new System.Drawing.Point(939, 26);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(75, 23);
            this.cmdPause.TabIndex = 4;
            this.cmdPause.Text = "Pause";
            this.cmdPause.UseVisualStyleBackColor = true;
            // 
            // fchSimulateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 773);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.groupAvions);
            this.Controls.Add(this.groupClient);
            this.Controls.Add(this.groupAeroport);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fchSimulateur";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupAeroport.ResumeLayout(false);
            this.groupClient.ResumeLayout(false);
            this.groupAvions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstAeroport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAvion)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupAeroport;
        private System.Windows.Forms.DataGridView lstAeroport;
        private System.Windows.Forms.GroupBox groupClient;
        private System.Windows.Forms.DataGridView lstClient;
        private System.Windows.Forms.GroupBox groupAvions;
        private System.Windows.Forms.DataGridView lstAvion;
        private System.Windows.Forms.Button cmdPause;
    }
}

