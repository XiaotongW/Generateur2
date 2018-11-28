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

        //creer des clients pour chaque aeroport
        public void CreerClient()
        {
            foreach (CAeroport Aero in ListeAeroports)
            {
                Aero.AjouterClient(CreerVoyageur(Aero.Passager_Min,Aero.Passager_Max,Aero));
                Aero.AjouterClient(CreerCargaison(Aero.Passager_Min, Aero.Passager_Max, Aero));
            }
        }

        //Creer un lot de voyageur pour un aeroport
        private CClients CreerVoyageur(int min,int max,CAeroport SelfAero)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int quantite = rand.Next((min * 10), (max * 10));
           
            UsineClient usineClient = new UsineClient();
            return usineClient.creeClient(PrendreAeroportRand(SelfAero), quantite);
        }

        //Creer un lot de cargaison pour un aeroport
        private CClients CreerCargaison(int min, int max, CAeroport SelfAero)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            double quantite = rand.Next((min * 10), (max * 10));

            UsineClient usineClient = new UsineClient();
            return usineClient.creeClient(PrendreAeroportRand(SelfAero), quantite);
        }

        //Prend un aeroport random comme destination
        private CAeroport PrendreAeroportRand(CAeroport SelfAero)
        {
            CAeroport Destination;
            Random rand = new Random(DateTime.Now.Millisecond);
            int ind = rand.Next(0, this.ListeAeroports.Count());

            if (this.ListeAeroports[ind] != SelfAero)
            {
                Destination = this.ListeAeroports[ind];
                return Destination;
            }
            else {
                PrendreAeroportRand(SelfAero);
            }
            return null;
        }
	}
}
