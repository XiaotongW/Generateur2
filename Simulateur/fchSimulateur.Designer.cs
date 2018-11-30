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
            this.lstAeroport = new System.Windows.Forms.ListBox();
            this.groupClient = new System.Windows.Forms.GroupBox();
            this.groupAvions = new System.Windows.Forms.GroupBox();
            this.cmdPause = new System.Windows.Forms.Button();
            this.lblHorloge = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerUnScénarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstClient = new System.Windows.Forms.ListBox();
            this.lstAeronef = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupAeroport.SuspendLayout();
            this.groupClient.SuspendLayout();
            this.groupAvions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // groupAeroport
            // 
            this.groupAeroport.Controls.Add(this.lstAeroport);
            this.groupAeroport.Location = new System.Drawing.Point(22, 64);
            this.groupAeroport.Name = "groupAeroport";
            this.groupAeroport.Size = new System.Drawing.Size(268, 158);
            this.groupAeroport.TabIndex = 1;
            this.groupAeroport.TabStop = false;
            this.groupAeroport.Text = "Aéroport";
            // 
            // lstAeroport
            // 
            this.lstAeroport.FormattingEnabled = true;
            this.lstAeroport.Location = new System.Drawing.Point(6, 19);
            this.lstAeroport.Name = "lstAeroport";
            this.lstAeroport.Size = new System.Drawing.Size(256, 134);
            this.lstAeroport.TabIndex = 0;
            this.lstAeroport.Click += new System.EventHandler(this.lstAeroport_Click);
            this.lstAeroport.SelectedIndexChanged += new System.EventHandler(this.lstAeroport_SelectedIndexChanged);
            // 
            // groupClient
            // 
            this.groupClient.Controls.Add(this.lstClient);
            this.groupClient.Location = new System.Drawing.Point(296, 64);
            this.groupClient.Name = "groupClient";
            this.groupClient.Size = new System.Drawing.Size(353, 158);
            this.groupClient.TabIndex = 2;
            this.groupClient.TabStop = false;
            this.groupClient.Text = "Clients";
            // 
            // groupAvions
            // 
            this.groupAvions.Controls.Add(this.lstAeronef);
            this.groupAvions.Location = new System.Drawing.Point(655, 64);
            this.groupAvions.Name = "groupAvions";
            this.groupAvions.Size = new System.Drawing.Size(365, 158);
            this.groupAvions.TabIndex = 3;
            this.groupAvions.TabStop = false;
            this.groupAvions.Text = "Avions";
            // 
            // cmdPause
            // 
            this.cmdPause.Location = new System.Drawing.Point(945, 35);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(75, 23);
            this.cmdPause.TabIndex = 4;
            this.cmdPause.Text = "Pause";
            this.cmdPause.UseVisualStyleBackColor = true;
            // 
            // lblHorloge
            // 
            this.lblHorloge.AutoSize = true;
            this.lblHorloge.BackColor = System.Drawing.Color.White;
            this.lblHorloge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorloge.Location = new System.Drawing.Point(823, 712);
            this.lblHorloge.Name = "lblHorloge";
            this.lblHorloge.Size = new System.Drawing.Size(120, 31);
            this.lblHorloge.TabIndex = 5;
            this.lblHorloge.Text = "00:00:00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerUnScénarioToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // chargerUnScénarioToolStripMenuItem
            // 
            this.chargerUnScénarioToolStripMenuItem.Name = "chargerUnScénarioToolStripMenuItem";
            this.chargerUnScénarioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.chargerUnScénarioToolStripMenuItem.Text = "Charger un scénario ...";
            this.chargerUnScénarioToolStripMenuItem.Click += new System.EventHandler(this.chargerUnScénarioToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // lstClient
            // 
            this.lstClient.FormattingEnabled = true;
            this.lstClient.Location = new System.Drawing.Point(6, 19);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(341, 134);
            this.lstClient.TabIndex = 0;
            // 
            // lstAeronef
            // 
            this.lstAeronef.FormattingEnabled = true;
            this.lstAeronef.Location = new System.Drawing.Point(6, 19);
            this.lstAeronef.Name = "lstAeronef";
            this.lstAeronef.Size = new System.Drawing.Size(353, 134);
            this.lstAeronef.TabIndex = 0;
            // 
            // fchSimulateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 773);
            this.Controls.Add(this.lblHorloge);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.groupAvions);
            this.Controls.Add(this.groupClient);
            this.Controls.Add(this.groupAeroport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fchSimulateur";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupAeroport.ResumeLayout(false);
            this.groupClient.ResumeLayout(false);
            this.groupAvions.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupAeroport;
        private System.Windows.Forms.GroupBox groupClient;
        private System.Windows.Forms.GroupBox groupAvions;
        private System.Windows.Forms.Button cmdPause;
        private System.Windows.Forms.Label lblHorloge;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerUnScénarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ListBox lstAeroport;
        private System.Windows.Forms.ListBox lstClient;
        private System.Windows.Forms.ListBox lstAeronef;
    }
}

