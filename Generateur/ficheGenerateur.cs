using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generateur
{
    public partial class ficheGenerateur : Form
    {
        private Generateur m_generateur;
        private ficheCarte m_carte;

        public ficheGenerateur(Generateur generateur)
        {
            InitializeComponent();
            m_generateur = generateur;
        }

        private void afficherListeAeronef()
        {

        }

        private void afficherListeAeroport()
        {

        }

        private void afficherTypeAeronef()
        //Ajouter les types d'aéronefs dans la liste déroulante
        {
            cmbTypeAeronef.DataSource = Enum.GetValues(typeof(typeAvion));
        }

        private void ajouterAeroport()
        //Ajouter un aéroport dans le scenario
        {
            string nomAeroport;
            string villeAeroport;
            int posX;
            int posY;
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

            if (nomAeroport != "" && villeAeroport != "" && maxPassager != -1 && maxCargo != -1)
            {
                //m_generateur.ajouterAeroport(nomAeroport, villeAeroport, posX, posY, minPassager, maxPassager, minCargo, maxCargo);
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

            if (txtModeleAeronef.Text != "")
            {
                modeleAeronef = txtNomAeroport.Text;
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

            if (modeleAeronef != "" && capaciteAeronef != -1)
            {
                //m_generateur.ajouterAeronef(modeleAeronef, capaciteAeronef, typeAeronef, vitesseAeronef, embarquementAeronef, debarquementAeronef, maintenanceAeronef);
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

        private void etqEmbarquementAeronef_Click(object sender, EventArgs e)
        {

        }

        private void cmdPositionAeroport_Click(object sender, EventArgs e)
        //Afficher le dialogue de selection de la position d'un aéroport
        {
            m_carte = new ficheCarte();

            m_carte.ShowDialog();
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
    }
}

    
    

