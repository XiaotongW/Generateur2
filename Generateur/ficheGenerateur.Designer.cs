namespace Generateur
{
    partial class ficheGenerateur
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
            this.tabCreation = new System.Windows.Forms.TabControl();
            this.ongAeroport = new System.Windows.Forms.TabPage();
            this.cmdSupprimerAeroport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdAjouterAeroport = new System.Windows.Forms.Button();
            this.etqMaxCargo = new System.Windows.Forms.Label();
            this.selMaxCargo = new System.Windows.Forms.TrackBar();
            this.etqMinCargo = new System.Windows.Forms.Label();
            this.selMinCargo = new System.Windows.Forms.TrackBar();
            this.etqMaxPassager = new System.Windows.Forms.Label();
            this.selMaxPassager = new System.Windows.Forms.TrackBar();
            this.etqMinPassager = new System.Windows.Forms.Label();
            this.selMinPassager = new System.Windows.Forms.TrackBar();
            this.cmdPositionAeroport = new System.Windows.Forms.Button();
            this.etqVilleAeroport = new System.Windows.Forms.Label();
            this.txtVilleAeroport = new System.Windows.Forms.TextBox();
            this.etqNomAeroport = new System.Windows.Forms.Label();
            this.txtNomAeroport = new System.Windows.Forms.TextBox();
            this.lstAeroport = new System.Windows.Forms.ListBox();
            this.ongAeronef = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.etqEntretienAeronef = new System.Windows.Forms.Label();
            this.selEntretienAeronef = new System.Windows.Forms.TrackBar();
            this.etqDebarquementAeronef = new System.Windows.Forms.Label();
            this.selDebarquementAeronef = new System.Windows.Forms.TrackBar();
            this.etqEmbarquementAeronef = new System.Windows.Forms.Label();
            this.selEmbarquementAeronef = new System.Windows.Forms.TrackBar();
            this.etqVitesseAeronef = new System.Windows.Forms.Label();
            this.selVitesseAeronef = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTypeAeronef = new System.Windows.Forms.ComboBox();
            this.etqCapaciteAeronef = new System.Windows.Forms.Label();
            this.txtCapaciteAeronef = new System.Windows.Forms.TextBox();
            this.etqModeleAeronef = new System.Windows.Forms.Label();
            this.txtModeleAeronef = new System.Windows.Forms.TextBox();
            this.cmdAjouterAeronef = new System.Windows.Forms.Button();
            this.lstAeronef = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerUnScénarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderUnScénarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scénarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialiserLeScénarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statInfo = new System.Windows.Forms.StatusStrip();
            this.etqInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabCreation.SuspendLayout();
            this.ongAeroport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selMaxCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selMinCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selMaxPassager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selMinPassager)).BeginInit();
            this.ongAeronef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selEntretienAeronef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selDebarquementAeronef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selEmbarquementAeronef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selVitesseAeronef)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCreation
            // 
            this.tabCreation.Controls.Add(this.ongAeroport);
            this.tabCreation.Controls.Add(this.ongAeronef);
            this.tabCreation.Location = new System.Drawing.Point(12, 30);
            this.tabCreation.Name = "tabCreation";
            this.tabCreation.SelectedIndex = 0;
            this.tabCreation.Size = new System.Drawing.Size(296, 359);
            this.tabCreation.TabIndex = 0;
            this.tabCreation.SelectedIndexChanged += new System.EventHandler(this.tabCreation_SelectedIndexChanged);
            // 
            // ongAeroport
            // 
            this.ongAeroport.Controls.Add(this.cmdSupprimerAeroport);
            this.ongAeroport.Controls.Add(this.button2);
            this.ongAeroport.Controls.Add(this.cmdAjouterAeroport);
            this.ongAeroport.Controls.Add(this.etqMaxCargo);
            this.ongAeroport.Controls.Add(this.selMaxCargo);
            this.ongAeroport.Controls.Add(this.etqMinCargo);
            this.ongAeroport.Controls.Add(this.selMinCargo);
            this.ongAeroport.Controls.Add(this.etqMaxPassager);
            this.ongAeroport.Controls.Add(this.selMaxPassager);
            this.ongAeroport.Controls.Add(this.etqMinPassager);
            this.ongAeroport.Controls.Add(this.selMinPassager);
            this.ongAeroport.Controls.Add(this.cmdPositionAeroport);
            this.ongAeroport.Controls.Add(this.etqVilleAeroport);
            this.ongAeroport.Controls.Add(this.txtVilleAeroport);
            this.ongAeroport.Controls.Add(this.etqNomAeroport);
            this.ongAeroport.Controls.Add(this.txtNomAeroport);
            this.ongAeroport.Controls.Add(this.lstAeroport);
            this.ongAeroport.Location = new System.Drawing.Point(4, 22);
            this.ongAeroport.Name = "ongAeroport";
            this.ongAeroport.Padding = new System.Windows.Forms.Padding(3);
            this.ongAeroport.Size = new System.Drawing.Size(288, 333);
            this.ongAeroport.TabIndex = 0;
            this.ongAeroport.Text = "Aéroports";
            this.ongAeroport.UseVisualStyleBackColor = true;
            // 
            // cmdSupprimerAeroport
            // 
            this.cmdSupprimerAeroport.Location = new System.Drawing.Point(60, 302);
            this.cmdSupprimerAeroport.Name = "cmdSupprimerAeroport";
            this.cmdSupprimerAeroport.Size = new System.Drawing.Size(66, 23);
            this.cmdSupprimerAeroport.TabIndex = 19;
            this.cmdSupprimerAeroport.Text = "Supprimer";
            this.cmdSupprimerAeroport.UseVisualStyleBackColor = true;
            this.cmdSupprimerAeroport.Click += new System.EventHandler(this.cmdSupprimerAeroport_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Aéronefs de l\'aéroport";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdAjouterAeroport
            // 
            this.cmdAjouterAeroport.Location = new System.Drawing.Point(6, 302);
            this.cmdAjouterAeroport.Name = "cmdAjouterAeroport";
            this.cmdAjouterAeroport.Size = new System.Drawing.Size(48, 23);
            this.cmdAjouterAeroport.TabIndex = 17;
            this.cmdAjouterAeroport.Text = "Ajouter";
            this.cmdAjouterAeroport.UseVisualStyleBackColor = true;
            this.cmdAjouterAeroport.Click += new System.EventHandler(this.cmdAjouterAeroport_Click);
            // 
            // etqMaxCargo
            // 
            this.etqMaxCargo.AutoSize = true;
            this.etqMaxCargo.Location = new System.Drawing.Point(132, 240);
            this.etqMaxCargo.Name = "etqMaxCargo";
            this.etqMaxCargo.Size = new System.Drawing.Size(96, 13);
            this.etqMaxCargo.TabIndex = 16;
            this.etqMaxCargo.Text = "Maximum de cargo";
            // 
            // selMaxCargo
            // 
            this.selMaxCargo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selMaxCargo.Location = new System.Drawing.Point(135, 256);
            this.selMaxCargo.Name = "selMaxCargo";
            this.selMaxCargo.Size = new System.Drawing.Size(146, 45);
            this.selMaxCargo.TabIndex = 15;
            // 
            // etqMinCargo
            // 
            this.etqMinCargo.AutoSize = true;
            this.etqMinCargo.Location = new System.Drawing.Point(132, 189);
            this.etqMinCargo.Name = "etqMinCargo";
            this.etqMinCargo.Size = new System.Drawing.Size(93, 13);
            this.etqMinCargo.TabIndex = 14;
            this.etqMinCargo.Text = "Minimum de cargo";
            // 
            // selMinCargo
            // 
            this.selMinCargo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selMinCargo.Location = new System.Drawing.Point(135, 205);
            this.selMinCargo.Name = "selMinCargo";
            this.selMinCargo.Size = new System.Drawing.Size(146, 45);
            this.selMinCargo.TabIndex = 13;
            // 
            // etqMaxPassager
            // 
            this.etqMaxPassager.AutoSize = true;
            this.etqMaxPassager.Location = new System.Drawing.Point(132, 138);
            this.etqMaxPassager.Name = "etqMaxPassager";
            this.etqMaxPassager.Size = new System.Drawing.Size(112, 13);
            this.etqMaxPassager.TabIndex = 12;
            this.etqMaxPassager.Text = "Maximum de passager";
            // 
            // selMaxPassager
            // 
            this.selMaxPassager.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selMaxPassager.Location = new System.Drawing.Point(135, 154);
            this.selMaxPassager.Name = "selMaxPassager";
            this.selMaxPassager.Size = new System.Drawing.Size(146, 45);
            this.selMaxPassager.TabIndex = 11;
            // 
            // etqMinPassager
            // 
            this.etqMinPassager.AutoSize = true;
            this.etqMinPassager.Location = new System.Drawing.Point(132, 87);
            this.etqMinPassager.Name = "etqMinPassager";
            this.etqMinPassager.Size = new System.Drawing.Size(109, 13);
            this.etqMinPassager.TabIndex = 10;
            this.etqMinPassager.Text = "Minimum de passager";
            // 
            // selMinPassager
            // 
            this.selMinPassager.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selMinPassager.Location = new System.Drawing.Point(135, 103);
            this.selMinPassager.Name = "selMinPassager";
            this.selMinPassager.Size = new System.Drawing.Size(146, 45);
            this.selMinPassager.TabIndex = 6;
            // 
            // cmdPositionAeroport
            // 
            this.cmdPositionAeroport.Location = new System.Drawing.Point(206, 58);
            this.cmdPositionAeroport.Name = "cmdPositionAeroport";
            this.cmdPositionAeroport.Size = new System.Drawing.Size(75, 23);
            this.cmdPositionAeroport.TabIndex = 5;
            this.cmdPositionAeroport.Text = "Position ...";
            this.cmdPositionAeroport.UseVisualStyleBackColor = true;
            this.cmdPositionAeroport.Click += new System.EventHandler(this.cmdPositionAeroport_Click);
            // 
            // etqVilleAeroport
            // 
            this.etqVilleAeroport.AutoSize = true;
            this.etqVilleAeroport.Location = new System.Drawing.Point(132, 35);
            this.etqVilleAeroport.Name = "etqVilleAeroport";
            this.etqVilleAeroport.Size = new System.Drawing.Size(26, 13);
            this.etqVilleAeroport.TabIndex = 4;
            this.etqVilleAeroport.Text = "Ville";
            // 
            // txtVilleAeroport
            // 
            this.txtVilleAeroport.Location = new System.Drawing.Point(181, 32);
            this.txtVilleAeroport.Name = "txtVilleAeroport";
            this.txtVilleAeroport.Size = new System.Drawing.Size(100, 20);
            this.txtVilleAeroport.TabIndex = 3;
            // 
            // etqNomAeroport
            // 
            this.etqNomAeroport.AutoSize = true;
            this.etqNomAeroport.Location = new System.Drawing.Point(132, 9);
            this.etqNomAeroport.Name = "etqNomAeroport";
            this.etqNomAeroport.Size = new System.Drawing.Size(29, 13);
            this.etqNomAeroport.TabIndex = 2;
            this.etqNomAeroport.Text = "Nom";
            // 
            // txtNomAeroport
            // 
            this.txtNomAeroport.Location = new System.Drawing.Point(181, 6);
            this.txtNomAeroport.Name = "txtNomAeroport";
            this.txtNomAeroport.Size = new System.Drawing.Size(100, 20);
            this.txtNomAeroport.TabIndex = 1;
            // 
            // lstAeroport
            // 
            this.lstAeroport.FormattingEnabled = true;
            this.lstAeroport.Location = new System.Drawing.Point(6, 6);
            this.lstAeroport.Name = "lstAeroport";
            this.lstAeroport.Size = new System.Drawing.Size(120, 290);
            this.lstAeroport.TabIndex = 0;
            this.lstAeroport.Click += new System.EventHandler(this.lstAeroport_Click);
            this.lstAeroport.SelectedIndexChanged += new System.EventHandler(this.lstAeroport_SelectedIndexChanged);
            // 
            // ongAeronef
            // 
            this.ongAeronef.Controls.Add(this.button1);
            this.ongAeronef.Controls.Add(this.etqEntretienAeronef);
            this.ongAeronef.Controls.Add(this.selEntretienAeronef);
            this.ongAeronef.Controls.Add(this.etqDebarquementAeronef);
            this.ongAeronef.Controls.Add(this.selDebarquementAeronef);
            this.ongAeronef.Controls.Add(this.etqEmbarquementAeronef);
            this.ongAeronef.Controls.Add(this.selEmbarquementAeronef);
            this.ongAeronef.Controls.Add(this.etqVitesseAeronef);
            this.ongAeronef.Controls.Add(this.selVitesseAeronef);
            this.ongAeronef.Controls.Add(this.label1);
            this.ongAeronef.Controls.Add(this.cmbTypeAeronef);
            this.ongAeronef.Controls.Add(this.etqCapaciteAeronef);
            this.ongAeronef.Controls.Add(this.txtCapaciteAeronef);
            this.ongAeronef.Controls.Add(this.etqModeleAeronef);
            this.ongAeronef.Controls.Add(this.txtModeleAeronef);
            this.ongAeronef.Controls.Add(this.cmdAjouterAeronef);
            this.ongAeronef.Controls.Add(this.lstAeronef);
            this.ongAeronef.Location = new System.Drawing.Point(4, 22);
            this.ongAeronef.Name = "ongAeronef";
            this.ongAeronef.Padding = new System.Windows.Forms.Padding(3);
            this.ongAeronef.Size = new System.Drawing.Size(288, 333);
            this.ongAeronef.TabIndex = 1;
            this.ongAeronef.Text = "Aéronefs";
            this.ongAeronef.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // etqEntretienAeronef
            // 
            this.etqEntretienAeronef.AutoSize = true;
            this.etqEntretienAeronef.Location = new System.Drawing.Point(133, 236);
            this.etqEntretienAeronef.Name = "etqEntretienAeronef";
            this.etqEntretienAeronef.Size = new System.Drawing.Size(91, 13);
            this.etqEntretienAeronef.TabIndex = 24;
            this.etqEntretienAeronef.Text = "Temps d\'entretien";
            // 
            // selEntretienAeronef
            // 
            this.selEntretienAeronef.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selEntretienAeronef.Location = new System.Drawing.Point(136, 252);
            this.selEntretienAeronef.Name = "selEntretienAeronef";
            this.selEntretienAeronef.Size = new System.Drawing.Size(146, 45);
            this.selEntretienAeronef.TabIndex = 23;
            // 
            // etqDebarquementAeronef
            // 
            this.etqDebarquementAeronef.AutoSize = true;
            this.etqDebarquementAeronef.Location = new System.Drawing.Point(133, 185);
            this.etqDebarquementAeronef.Name = "etqDebarquementAeronef";
            this.etqDebarquementAeronef.Size = new System.Drawing.Size(125, 13);
            this.etqDebarquementAeronef.TabIndex = 22;
            this.etqDebarquementAeronef.Text = "Temps de debarquement";
            // 
            // selDebarquementAeronef
            // 
            this.selDebarquementAeronef.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selDebarquementAeronef.Location = new System.Drawing.Point(136, 201);
            this.selDebarquementAeronef.Name = "selDebarquementAeronef";
            this.selDebarquementAeronef.Size = new System.Drawing.Size(146, 45);
            this.selDebarquementAeronef.TabIndex = 21;
            // 
            // etqEmbarquementAeronef
            // 
            this.etqEmbarquementAeronef.AutoSize = true;
            this.etqEmbarquementAeronef.Location = new System.Drawing.Point(133, 134);
            this.etqEmbarquementAeronef.Name = "etqEmbarquementAeronef";
            this.etqEmbarquementAeronef.Size = new System.Drawing.Size(120, 13);
            this.etqEmbarquementAeronef.TabIndex = 20;
            this.etqEmbarquementAeronef.Text = "Temps d\'embarquement";
            // 
            // selEmbarquementAeronef
            // 
            this.selEmbarquementAeronef.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selEmbarquementAeronef.Location = new System.Drawing.Point(136, 150);
            this.selEmbarquementAeronef.Name = "selEmbarquementAeronef";
            this.selEmbarquementAeronef.Size = new System.Drawing.Size(146, 45);
            this.selEmbarquementAeronef.TabIndex = 19;
            // 
            // etqVitesseAeronef
            // 
            this.etqVitesseAeronef.AutoSize = true;
            this.etqVitesseAeronef.Location = new System.Drawing.Point(133, 83);
            this.etqVitesseAeronef.Name = "etqVitesseAeronef";
            this.etqVitesseAeronef.Size = new System.Drawing.Size(41, 13);
            this.etqVitesseAeronef.TabIndex = 18;
            this.etqVitesseAeronef.Text = "Vitesse";
            // 
            // selVitesseAeronef
            // 
            this.selVitesseAeronef.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selVitesseAeronef.Location = new System.Drawing.Point(136, 99);
            this.selVitesseAeronef.Name = "selVitesseAeronef";
            this.selVitesseAeronef.Size = new System.Drawing.Size(146, 45);
            this.selVitesseAeronef.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Type";
            // 
            // cmbTypeAeronef
            // 
            this.cmbTypeAeronef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeAeronef.FormattingEnabled = true;
            this.cmbTypeAeronef.Location = new System.Drawing.Point(182, 58);
            this.cmbTypeAeronef.Name = "cmbTypeAeronef";
            this.cmbTypeAeronef.Size = new System.Drawing.Size(100, 21);
            this.cmbTypeAeronef.TabIndex = 7;
            this.cmbTypeAeronef.SelectedIndexChanged += new System.EventHandler(this.cmbTypeAeronef_SelectedIndexChanged);
            // 
            // etqCapaciteAeronef
            // 
            this.etqCapaciteAeronef.AutoSize = true;
            this.etqCapaciteAeronef.Location = new System.Drawing.Point(133, 35);
            this.etqCapaciteAeronef.Name = "etqCapaciteAeronef";
            this.etqCapaciteAeronef.Size = new System.Drawing.Size(49, 13);
            this.etqCapaciteAeronef.TabIndex = 6;
            this.etqCapaciteAeronef.Text = "Capacité";
            // 
            // txtCapaciteAeronef
            // 
            this.txtCapaciteAeronef.Location = new System.Drawing.Point(182, 32);
            this.txtCapaciteAeronef.Name = "txtCapaciteAeronef";
            this.txtCapaciteAeronef.Size = new System.Drawing.Size(100, 20);
            this.txtCapaciteAeronef.TabIndex = 5;
            this.txtCapaciteAeronef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapaciteAeronef_KeyPress);
            // 
            // etqModeleAeronef
            // 
            this.etqModeleAeronef.AutoSize = true;
            this.etqModeleAeronef.Location = new System.Drawing.Point(133, 9);
            this.etqModeleAeronef.Name = "etqModeleAeronef";
            this.etqModeleAeronef.Size = new System.Drawing.Size(42, 13);
            this.etqModeleAeronef.TabIndex = 4;
            this.etqModeleAeronef.Text = "Modèle";
            // 
            // txtModeleAeronef
            // 
            this.txtModeleAeronef.Location = new System.Drawing.Point(182, 6);
            this.txtModeleAeronef.Name = "txtModeleAeronef";
            this.txtModeleAeronef.Size = new System.Drawing.Size(100, 20);
            this.txtModeleAeronef.TabIndex = 3;
            // 
            // cmdAjouterAeronef
            // 
            this.cmdAjouterAeronef.Location = new System.Drawing.Point(6, 302);
            this.cmdAjouterAeronef.Name = "cmdAjouterAeronef";
            this.cmdAjouterAeronef.Size = new System.Drawing.Size(48, 23);
            this.cmdAjouterAeronef.TabIndex = 1;
            this.cmdAjouterAeronef.Text = "Ajouter";
            this.cmdAjouterAeronef.UseVisualStyleBackColor = true;
            this.cmdAjouterAeronef.Click += new System.EventHandler(this.cmdAjouterAeronef_Click);
            // 
            // lstAeronef
            // 
            this.lstAeronef.FormattingEnabled = true;
            this.lstAeronef.Location = new System.Drawing.Point(6, 6);
            this.lstAeronef.Name = "lstAeronef";
            this.lstAeronef.Size = new System.Drawing.Size(120, 290);
            this.lstAeronef.TabIndex = 0;
            this.lstAeronef.Click += new System.EventHandler(this.lstAeronef_Click);
            this.lstAeronef.SelectedIndexChanged += new System.EventHandler(this.lstAeronef_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.scénarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(321, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerUnScénarioToolStripMenuItem,
            this.sauvegarderUnScénarioToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // chargerUnScénarioToolStripMenuItem
            // 
            this.chargerUnScénarioToolStripMenuItem.Name = "chargerUnScénarioToolStripMenuItem";
            this.chargerUnScénarioToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.chargerUnScénarioToolStripMenuItem.Text = "Charger un scénario ...";
            this.chargerUnScénarioToolStripMenuItem.Click += new System.EventHandler(this.chargerUnScénarioToolStripMenuItem_Click);
            // 
            // sauvegarderUnScénarioToolStripMenuItem
            // 
            this.sauvegarderUnScénarioToolStripMenuItem.Name = "sauvegarderUnScénarioToolStripMenuItem";
            this.sauvegarderUnScénarioToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sauvegarderUnScénarioToolStripMenuItem.Text = "Sauvegarder un scénario ...";
            this.sauvegarderUnScénarioToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderUnScénarioToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // scénarioToolStripMenuItem
            // 
            this.scénarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réinitialiserLeScénarioToolStripMenuItem});
            this.scénarioToolStripMenuItem.Name = "scénarioToolStripMenuItem";
            this.scénarioToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.scénarioToolStripMenuItem.Text = "Scénario";
            // 
            // réinitialiserLeScénarioToolStripMenuItem
            // 
            this.réinitialiserLeScénarioToolStripMenuItem.Name = "réinitialiserLeScénarioToolStripMenuItem";
            this.réinitialiserLeScénarioToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.réinitialiserLeScénarioToolStripMenuItem.Text = "Réinitialiser le scénario";
            this.réinitialiserLeScénarioToolStripMenuItem.Click += new System.EventHandler(this.réinitialiserLeScénarioToolStripMenuItem_Click);
            // 
            // statInfo
            // 
            this.statInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etqInfo});
            this.statInfo.Location = new System.Drawing.Point(0, 393);
            this.statInfo.Name = "statInfo";
            this.statInfo.Size = new System.Drawing.Size(321, 22);
            this.statInfo.TabIndex = 2;
            this.statInfo.Text = "statusStrip1";
            // 
            // etqInfo
            // 
            this.etqInfo.Name = "etqInfo";
            this.etqInfo.Size = new System.Drawing.Size(0, 17);
            this.etqInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ficheGenerateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 415);
            this.Controls.Add(this.statInfo);
            this.Controls.Add(this.tabCreation);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ficheGenerateur";
            this.Text = "ficheGenerateur";
            this.Load += new System.EventHandler(this.ficheGenerateur_Load);
            this.tabCreation.ResumeLayout(false);
            this.ongAeroport.ResumeLayout(false);
            this.ongAeroport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selMaxCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selMinCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selMaxPassager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selMinPassager)).EndInit();
            this.ongAeronef.ResumeLayout(false);
            this.ongAeronef.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selEntretienAeronef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selDebarquementAeronef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selEmbarquementAeronef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selVitesseAeronef)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statInfo.ResumeLayout(false);
            this.statInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCreation;
        private System.Windows.Forms.TabPage ongAeroport;
        private System.Windows.Forms.Label etqMaxCargo;
        private System.Windows.Forms.TrackBar selMaxCargo;
        private System.Windows.Forms.Label etqMinCargo;
        private System.Windows.Forms.TrackBar selMinCargo;
        private System.Windows.Forms.Label etqMaxPassager;
        private System.Windows.Forms.TrackBar selMaxPassager;
        private System.Windows.Forms.Label etqMinPassager;
        private System.Windows.Forms.TrackBar selMinPassager;
        private System.Windows.Forms.Button cmdPositionAeroport;
        private System.Windows.Forms.Label etqVilleAeroport;
        private System.Windows.Forms.TextBox txtVilleAeroport;
        private System.Windows.Forms.Label etqNomAeroport;
        private System.Windows.Forms.TextBox txtNomAeroport;
        private System.Windows.Forms.ListBox lstAeroport;
        private System.Windows.Forms.TabPage ongAeronef;
        private System.Windows.Forms.ListBox lstAeronef;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdAjouterAeroport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTypeAeronef;
        private System.Windows.Forms.Label etqCapaciteAeronef;
        private System.Windows.Forms.TextBox txtCapaciteAeronef;
        private System.Windows.Forms.Label etqModeleAeronef;
        private System.Windows.Forms.TextBox txtModeleAeronef;
        private System.Windows.Forms.Button cmdAjouterAeronef;
        private System.Windows.Forms.Label etqEntretienAeronef;
        private System.Windows.Forms.TrackBar selEntretienAeronef;
        private System.Windows.Forms.Label etqDebarquementAeronef;
        private System.Windows.Forms.TrackBar selDebarquementAeronef;
        private System.Windows.Forms.Label etqEmbarquementAeronef;
        private System.Windows.Forms.TrackBar selEmbarquementAeronef;
        private System.Windows.Forms.Label etqVitesseAeronef;
        private System.Windows.Forms.TrackBar selVitesseAeronef;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerUnScénarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderUnScénarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scénarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinitialiserLeScénarioToolStripMenuItem;
        private System.Windows.Forms.Button cmdSupprimerAeroport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statInfo;
        private System.Windows.Forms.ToolStripStatusLabel etqInfo;
    }
}