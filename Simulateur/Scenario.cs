using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	public class Scenario
	{

		List<CAeroport> ListeAeroports;

		public Scenario()
		{
			ListeAeroports = new List<CAeroport>();
		}

		public int nbAeroport
		{
			get { return ListeAeroports.Count; }
		}

		public CAeroport[] Aeroports
		{
			get { return ListeAeroports.ToArray(); }
			set { ListeAeroports = value.ToList(); }
		}

		public CAeroport this[int i]
		{
			get { return (i < 0) ? null : ListeAeroports.ElementAt(i); }
			set { ListeAeroports[i] = value; }
		}

		public void AjouterAeroport(string nom, string ville, int posX, int posY, int minPass, int maxPass, int minCargo, int maxCargo)
		{
			CAeroport Aeroport = new CAeroport(nom, ville, minPass, maxPass, minCargo, maxCargo, posX, posY);
			ListeAeroports.Add(Aeroport);
		}
		public void RetirerAeroport(int i)
		{
			ListeAeroports.RemoveAt(i);
		}

		public void AjouterAeronef(CAeroport Aeroport, CAeronef Aeronef)
		{
			Aeroport.AjouterAeronef(Aeronef);
		}
	}
}
