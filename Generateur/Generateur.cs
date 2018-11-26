using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generateur
{
	public class Generateur
	{
        private ficheGenerateur m_fiche;
        private Scenario m_scenario;

        public Generateur()
        {
            m_fiche = new ficheGenerateur(this);

            Application.Run(m_fiche);
        }

        [STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            Generateur generateur = new Generateur();
		}

        private void sauvegarderScenario()
        {

        }

        private void chargerScenario()
        {

        }

        public void ajouterAeroport(string nom, string ville, int posX, int posY, int minPass, int maxPass, int minCargo, int maxCargo)
        {
            //m_scenario.ajouterAeroport(nom, ville, posX, posY, minPass, maxPass, minCargo, maxCargo);
        }
		
        public void ajouterAeronef(string modele, int capacite, typeAvion type, int vitesse, int embarquement, int debarquement, int maintenance)
        {
            //m_scenario.ajouterAeronef(modele, capacite, type, vitesse, embarquement, debarquement, maintenance);
        }

        public void supprimerAeroport(int index)
        {

        }

        public void supprimerAeronef(int index)
        {

        }
    }
}