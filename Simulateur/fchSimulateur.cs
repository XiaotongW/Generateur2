using System;
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

		public fchSimulateur(CSimulateur simulateur)
		{
			this.simulateur = simulateur;
			timeDelegue = new TimeDelegue(setHorloge);
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
            OpenFileDialog ouvrirFichier;
            ouvrirFichier = new OpenFileDialog();

            using (ouvrirFichier)
            {
                ouvrirFichier.InitialDirectory = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
                ouvrirFichier.Filter = "Fichiers de scénario (*.scenario)|*.scenario";

                if (ouvrirFichier.ShowDialog() == DialogResult.OK)
                {
                    simulateur.chargerScenario(ouvrirFichier.FileName);
                }
            }
        }

        private void chargerUnScénarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chargerScenario();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
