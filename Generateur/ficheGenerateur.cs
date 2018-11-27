using System;
using System.IO;
using System.Windows.Forms;

namespace Generateur
{
    public partial class ficheGenerateur : Form
    {
        private Generateur m_generateur;
        private ficheCarte m_carte;
        private int posX;
        private int posY;

        public ficheGenerateur(Generateur generateur)
        {
            InitializeComponent();
            m_generateur = generateur;
            posX = -1;
            posY = -1;
        }

        private void afficherListeAeronef()
        {
            int nbAeronef;
            int codeAeroport;
            string modeleAeronef;

            codeAeroport = lstAeroport.SelectedIndex;

            lstAeronef.Items.Clear();

            nbAeronef = m_generateur.recevoirAeroport(codeAeroport).nbAeronefs;

            for (int i = 0; i < nbAeronef; i++)
            {
                modeleAeronef = m_generateur.recevoirAeroport(codeAeroport)[i].nom;
                lstAeronef.Items.Add(modeleAeronef);
            }
        }

        private void afficherListeAeroport()
        {
            int nbAeroport;
            string nomAeroport;

            nbAeroport = m_generateur.nbAeroport();

            lstAeroport.Items.Clear();
            

            for (int i = 0; i < nbAeroport; i++)
            {
                nomAeroport = m_generateur.recevoirAeroport(i).nom;
                lstAeroport.Items.Add(nomAeroport);
            }
        }

        private void afficherTypeAeronef()
        //Ajouter les types d'aéronefs dans la liste déroulante
        {
            cmbTypeAeronef.DataSource = Enum.GetValues(typeof(typeAvion));
        }

        private void chargerScenario()
        {
            OpenFileDialog ouvrirFichier;
            ouvrirFichier = new OpenFileDialog();

            using (ouvrirFichier)
            {
                ouvrirFichier.InitialDirectory = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
                ouvrirFichier.Filter = "Fichiers de scénario (*.scenario)|*.scenario";

                if (ouvrirFichier.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void sauvegarderScenario()
        {
            SaveFileDialog sauvegarderFichier;
            sauvegarderFichier = new SaveFileDialog();

            using (sauvegarderFichier)
            {
                sauvegarderFichier.InitialDirectory = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
                sauvegarderFichier.Filter = "Fichiers de scénario (*.scenario)|*.scenario";

                if (sauvegarderFichier.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void ajouterAeroport()
        //Ajouter un aéroport dans le scenario
        {
            string nomAeroport;
            string villeAeroport;
            int minPassager;
            int maxPassager;
            int minCargo;
            int maxCargo;

            if (txtNomAeroport.Text != "")
            {
                nomAeroport = txtNomAeroport.Text;
            }
            else
            {
                MessageBox.Show("Entrer un nom pour l'aéroport");
                nomAeroport = "";
            }

            if (txtVilleAeroport.Text != "")
            {
                villeAeroport = txtVilleAeroport.Text;
            }
            else
            {
                MessageBox.Show("Entrer une ville pour l'aéroport");
                villeAeroport = "";
            }

            minPassager = selMinPassager.Value;
            minCargo = selMinCargo.Value;

            if (selMaxPassager.Value > minPassager)
            {
                maxPassager = selMaxPassager.Value;
            }
            else
            {
                MessageBox.Show("Passager: Le maximum doit être plus grand que le minimum ");
                maxPassager = -1;
            }

            if (selMaxCargo.Value > minCargo)
            {
                maxCargo = selMaxCargo.Value;
            }
            else
            {
                MessageBox.Show("Cargo: Le maximum doit être plus grand que le minimum ");
                maxCargo = -1;
            }

            if (posX < 0 || posY < 0)
            {
                MessageBox.Show("Veuillez choisir une position pour l'aéroport depuis le dialogue de" +
                                                " sélection accesible depuis le bouton [ Position ... ]");
            }

            if (nomAeroport != "" && villeAeroport != "" && maxPassager != -1 && maxCargo != -1 && posX > -1 && posY > -1)
            {
                m_generateur.ajouterAeroport(nomAeroport, villeAeroport, posX, posY, minPassager, maxPassager, minCargo, maxCargo);
                afficherListeAeroport();
            }

        }

        private void ajouterAeronef()
        //Ajout un aéronef dans un aéroport du scenario
        {
            string modeleAeronef;
            int capaciteAeronef;
            typeAvion typeAeronef;
            int vitesseAeronef;
            int embarquementAeronef;
            int debarquementAeronef;
            int maintenanceAeronef;
            int codeAeroport;

            if (txtModeleAeronef.Text != "")
            {
                modeleAeronef = txtModeleAeronef.Text;
            }
            else
            {
                MessageBox.Show("Entrer un modèle pour l'aéronef");
                modeleAeronef = "";
            }

            if (txtCapaciteAeronef.Text != "")
            {
                capaciteAeronef = Convert.ToInt32(txtCapaciteAeronef.Text);
            }
            else
            {
                MessageBox.Show("Entrer la capacité de l'aéronef");
                capaciteAeronef = -1;
            }

            typeAeronef = (typeAvion)cmbTypeAeronef.SelectedIndex;

            vitesseAeronef = selVitesseAeronef.Value;
            embarquementAeronef = selEmbarquementAeronef.Value;
            debarquementAeronef = selDebarquementAeronef.Value;
            maintenanceAeronef = selEntretienAeronef.Value;

            codeAeroport = lstAeroport.SelectedIndex;

            if (modeleAeronef != "" && capaciteAeronef != -1)
            {
                if (cmbTypeAeronef.SelectedIndex == 0 || cmbTypeAeronef.SelectedIndex == 1)
                {
                    m_generateur.ajouterAeronef(codeAeroport, modeleAeronef, capaciteAeronef, typeAeronef, vitesseAeronef, embarquementAeronef, debarquementAeronef, maintenanceAeronef);
                }
                else
                {
                    m_generateur.ajouterAeronef(codeAeroport, modeleAeronef, capaciteAeronef, typeAeronef, vitesseAeronef, maintenanceAeronef);
                }

                afficherListeAeronef();
            }
        }

        private void filtrerEntree(KeyPressEventArgs e)
        {
            //Vérifier que l'entrée dans la boîte de texte est un chiffre
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = false;
            }
        }

        private void cmdPositionAeroport_Click(object sender, EventArgs e)
        //Afficher le dialogue de selection de la position d'un aéroport
        {
            m_carte = new ficheCarte();

            if (m_carte.ShowDialog() == DialogResult.OK)
            {
                posX = m_carte.PositionX;
                posY = m_carte.PositionY;

                //Debug
                //txtNomAeroport.Text = Convert.ToString(posX);
                //txtVilleAeroport.Text = Convert.ToString(posY);
            }
            else
            {
                posX = -1;
                posY = -1;
            }

        }

        private void cmdAjouterAeroport_Click(object sender, EventArgs e)
        {
            ajouterAeroport();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCapaciteAeronef_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrerEntree(e);
        }

        private void cmdAjouterAeronef_Click(object sender, EventArgs e)
        {
            ajouterAeronef();
        }

        private void ficheGenerateur_Load(object sender, EventArgs e)
        {
            afficherTypeAeronef();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabCreation.SelectedIndex = 1;
        }

        private void cmdSupprimerAeroport_Click(object sender, EventArgs e)
        {
            m_generateur.supprimerAeroport(lstAeroport.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_generateur.supprimerAeronef(lstAeronef.SelectedIndex);
        }

        private void réinitialiserLeScénarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void chargerUnScénarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chargerScenario();
        }

        private void sauvegarderUnScénarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sauvegarderScenario();
        }

        private void lstAeroport_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aeroportChoisi;

            aeroportChoisi = lstAeronef.SelectedIndex;
        }

        private void cmbTypeAeronef_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeAeronef.SelectedIndex == 0 || cmbTypeAeronef.SelectedIndex == 1)
            {
                selEmbarquementAeronef.Enabled = true;
                selDebarquementAeronef.Enabled = true;
            }
            else
            {
                selEmbarquementAeronef.Enabled = false;
                selDebarquementAeronef.Enabled = false;
            }
        }

        private void lstAeroport_Click(object sender, EventArgs e)
        {
            afficherListeAeronef();
        }
    }
}

    
    

