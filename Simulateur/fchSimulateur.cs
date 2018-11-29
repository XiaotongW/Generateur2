using System;
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
        bool m_scenarioCharger;

		public fchSimulateur(CSimulateur simulateur)
		{
			this.simulateur = simulateur;
			timeDelegue = new TimeDelegue(setHorloge);
            m_scenarioCharger = false;
			InitializeComponent();
		}

		private void setHorloge(string Time)
		{
			// Methode delegue pour mettre a jour l'affichage du temps
			lblHorloge.Text = Time;
		}

        private void chargerScenario()
        //Afficher le dialogue d'ouverture de ficher pour permettre de charger un scénario dans le simulateur
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
            nbAeroport = simulateur.scenario.nbAeroport;

            for (int i = 0; i < nbAeroport; i++)
            {
                lstAeroport.Items.Add(simulateur.scenario.Aeroports[i].nom);
            }
        }

        private void afficherAeroportCarte()
        {

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
    }
}
