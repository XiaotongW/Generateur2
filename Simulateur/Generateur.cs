﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulateur
{
	public class Generateur
	{
        private fchSimulateur m_fiche;
        //private Scenario m_scenario;

        public Generateur()
        {
            m_fiche = new fchSimulateur();

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
		
        public void ajouterAeronef(string modele, int capacite, string type, int vitesse, int embarquement, int debarquement, int maintenance)
        {
            //m_scenario.ajouterAeronef(modele, capacite, type, vitesse, embarquement, debarquement, maintenance);
        }
    }
}