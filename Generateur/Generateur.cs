using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Generateur
{
	public class Generateur
	{
        private ficheGenerateur m_fiche;
        private Scenario m_scenario;

        public Generateur()
        {
            m_fiche = new ficheGenerateur(this);
            m_scenario = new Scenario();

            Application.Run(m_fiche);
        }

        [STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
           
            Generateur generateur = new Generateur();
		}

        public void sauvegarderScenario()
        {
			XmlSerializer xs = new XmlSerializer(typeof(Scenario));
			using (StreamWriter wr = new StreamWriter("scenario.xml"))
			{
				xs.Serialize(wr, scenario);
			}
        }

        public void chargerScenario()
        {
			XmlSerializer xs = new XmlSerializer(typeof(Scenario));
			using (StreamReader sr = new StreamReader("scenario.xml"))
			{
				scenario = xs.Deserialize(sr) as Scenario;
			}
		}

		public Scenario scenario
		{
			get { return m_scenario; }
			set { m_scenario = value; }
		}

        public CAeroport recevoirAeroport(int i)
        {
            return m_scenario[i];
        }

        public int nbAeroport()
        {
            return m_scenario.nbAeroport;
        }

        public void ajouterAeroport(string nom, string ville, int posX, int posY, int minPass, int maxPass, int minCargo, int maxCargo)
        {
            m_scenario.AjouterAeroport(nom, ville, posX, posY, minPass, maxPass, minCargo, maxCargo);
        }
		
        public void ajouterAeronef(int codeAeroport, string modele, int capacite, typeAvion type, int vitesse, int embarquement, int debarquement, int maintenance)
        {
             m_scenario[codeAeroport].CreeAeronef(type, modele, vitesse, maintenance, capacite, embarquement, debarquement, 0);
        }

        public void ajouterAeronef(int codeAeroport, string modele, int capacite, typeAvion type, int vitesse, int maintenance)
        {
            m_scenario[codeAeroport].CreeAeronef(type, modele, vitesse, maintenance, capacite);
        }

        public void supprimerAeroport(int index)
        {
            m_scenario.RetirerAeroport(index);
        }

        public void supprimerAeronef(int codeAeroport, int index)
        {
            m_scenario[codeAeroport].RetierAeronef(index);
        }
    }
}