﻿using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulateur
{
	public partial class fchSimulateur : Form
	{
		CSimulateur simulateur;
		public TimeDelegue timeDelegue;
        public rafraichirCarte dessinerCarte;
        bool m_scenarioCharger;

		public fchSimulateur(CSimulateur simulateur)
		{
			this.simulateur = simulateur;
			timeDelegue = new TimeDelegue(setHorloge);
            dessinerCarte = new rafraichirCarte(rafraichirCarte);
            m_scenarioCharger = false;
			InitializeComponent();
		}

        public void rafraichirCarte()
        //Rafraichir le cadre d’image de la carte pour afficher les changements
        {
            pictureBox1.Refresh();
        }

		private void setHorloge(string Time)
        //Mettre à jour l’affichage de l’horloge
		{
			// Methode delegue pour mettre a jour l'affichage du temps
			lblHorloge.Text = Time;
		}

        private void chargerScenario()
        //Ouvrir le fichier de scénario depuis le disque
        {
            /*OpenFileDialog ouvrirFichier;
            ouvrirFichier = new OpenFileDialog();

            using (ouvrirFichier)
            {
                ouvrirFichier.InitialDirectory = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
                ouvrirFichier.Filter = "Fichiers de scénario (*.scenario)|*.scenario";

                if (ouvrirFichier.ShowDialog() == DialogResult.OK)
                {
                    simulateur.chargerScenario(ouvrirFichier.FileName);
                }
            }*/

            simulateur.chargerScenario("scenarioPrincipal.scenario");
            m_scenarioCharger = true;
            afficherListeAeroport();
            pictureBox1.Refresh();
        }

        private void afficherListeAeroport()
        //Charger le nom des aeroports dans la liste
        {
            int nbAeroport;
            string nomAeroport;
            string villeAeroport;
            nbAeroport = simulateur.scenario.nbAeroport;

            for (int i = 0; i < nbAeroport; i++)
            {
                nomAeroport = simulateur.scenario.Aeroports[i].nom;
                villeAeroport = simulateur.scenario.Aeroports[i].ville;

                if (nomAeroport == villeAeroport)
                {
                    lstAeroport.Items.Add("Aéroport de " + villeAeroport);
                }
                else
                {
                    lstAeroport.Items.Add("Aéroport " + nomAeroport + " de " + villeAeroport);
                }
            }
        }

        private void afficherListeAeronef()
        //Charger dans la liste les aeronefs de l'aéroport choisi
        {
            int codeAeroport;
            int nbAeronef;

            codeAeroport = lstAeroport.SelectedIndex;
            lstAeronef.Items.Clear();

            if (codeAeroport != -1)
            {
                nbAeronef = simulateur.scenario.Aeroports[codeAeroport].nbAeronef;

                for (int i = 0; i < nbAeronef; i++)
                {
                    lstAeronef.Items.Add(simulateur.scenario.Aeroports[codeAeroport][i].nom);
                }
            }
        }

        private void afficherListeClient()
        //Charger dans la liste les client de l'aéroport choisi
        {
            int codeAeroport;
            int nbClient;

            codeAeroport = lstAeroport.SelectedIndex;
            lstClient.Items.Clear();

            if (codeAeroport != -1)
            {
                nbClient = simulateur.scenario[codeAeroport].nbClient;

                for (int i = 0; i < nbClient; i++)
                {
                    lstClient.Items.Add(simulateur.scenario.Aeroports[codeAeroport].recevoirClient(i).ToString());
                }
            }
        }

        private void afficherAeroportCarte(PaintEventArgs e)
        //Afficher les aéroports sur la carte du monde
        {
            int nbAeroport;
            int posX;
            int posY;

            if (m_scenarioCharger)
            {
                nbAeroport = simulateur.scenario.nbAeroport;

                for (int i = 0; i < nbAeroport; i++)
                {
                    posX = simulateur.scenario.Aeroports[i].position.x;
                    posY = simulateur.scenario.Aeroports[i].position.y;

                    Icon iconeAeroport = new Icon("Aeroport.ico");

                    Rectangle rect = new Rectangle(posX + 7, posY + 7, 15, 15);

                    e.Graphics.DrawIcon(iconeAeroport, rect);
                }
            }
        }

        private void afficherAeronef(PaintEventArgs e)
        //Afficher les aéronefs en vol sur la carte du monde
        {
            int posX;
            int posY;
            int nbAeronef;

            if (m_scenarioCharger)
            {
                nbAeronef = simulateur.scenario.nbAeronefVol;

                for (int i = 0; i < nbAeronef; i++)
                {
                    posX = (simulateur.scenario.getAeronefVol(i).etat as CVol).Actuelle.x;
                    posY = (simulateur.scenario.getAeronefVol(i).etat as CVol).Actuelle.y;

                    Icon iconeAeronef = new Icon("Aeroport.ico");

                    Rectangle rect = new Rectangle(posX + 7, posY + 7, 15, 15);

                    e.Graphics.DrawIcon(iconeAeronef, rect);
                }
            }
        }

        private void afficherLiaison(PaintEventArgs e)
        //Afficher les liaisons entre deux aéroport effectué par les avions
        {
            Pen ligne;
            Color noir;
            int srcX, srcY, destX, destY;
            int nbAeronefs;

            noir = Color.FromName("Black");
            ligne = new Pen(noir, 2);

            nbAeronefs = simulateur.scenario.nbAeronefVol;

            if (m_scenarioCharger)
            {
                for (int i = 0; i < nbAeronefs; i++)
                {
                    srcX = (simulateur.scenario.getAeronefVol(i).etat as CVol).Depart.x + 14;
                    srcY = (simulateur.scenario.getAeronefVol(i).etat as CVol).Depart.y + 14;
                    destX = (simulateur.scenario.getAeronefVol(i).etat as CVol).Arriver.x + 14;
                    destY = (simulateur.scenario.getAeronefVol(i).etat as CVol).Arriver.y + 14;

                    e.Graphics.DrawLine(ligne, srcX, srcY, destX, destY);
                }
            }

            /* Test pour lier tous les aeroports
            if (m_scenarioCharger)
            {
                for (int i = 0; i < simulateur.scenario.nbAeroport; i++)
                {
                    for (int j = 0; j < simulateur.scenario.nbAeroport; j++)
                    {
                        srcX = simulateur.scenario.Aeroports[i].position.x + 14;
                        srcY = simulateur.scenario.Aeroports[i].position.y + 14;
                        destX = simulateur.scenario.Aeroports[j].position.x + 14;
                        destY = simulateur.scenario.Aeroports[j].position.y + 14;

                        e.Graphics.DrawLine(ligne, srcX, srcY, destX, destY);
                    }
                }
            }*/
        }

        private void chargerUnScénarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chargerScenario();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            afficherAeronef(e);
            afficherLiaison(e);
            afficherAeroportCarte(e);   
        }

        private void lstAeroport_SelectedIndexChanged(object sender, EventArgs e)
        {
            afficherListeAeronef();
            afficherListeClient();
        }

        private void lstAeroport_Click(object sender, EventArgs e)
        {
            afficherListeAeronef();
            afficherListeClient();
        }
    }
}
