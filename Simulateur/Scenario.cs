using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Simulateur
{
	public class Scenario
	{
		[XmlIgnore]
		public UpdateDelegueEtat UpdateEtat;
		[XmlIgnore]
		public UpdateDelegueClient UpdateClient;
		List<CAeroport> ListeAeroports;
		List<CAeronef> ListeAeronefVol;
		int TimeLastUpdate;
		
		public Scenario()
		{
			ListeAeroports = new List<CAeroport>();
			ListeAeronefVol = new List<CAeronef>();
			UpdateEtat = new UpdateDelegueEtat(UpdateAeronef);
			UpdateClient = new UpdateDelegueClient(UpdateClients);
			TimeLastUpdate = 0;
		}

        private void UpdateClients(int TimeSecs)
        {

            if(TimeSecs-TimeLastUpdate >= 3600)
            {
                CreerClient();
				TimeLastUpdate = TimeSecs;
            } 
        }

		public int nbAeroport
		{
			get { return ListeAeroports.Count; }
		}

		public CAeronef getAeronefVol(int i)
		{
			return (i >=0 && i<ListeAeronefVol.Count)?ListeAeronefVol.ElementAt(i):null;
		}

		public int nbAeronefVol
		{
			get { return ListeAeronefVol.Count(); }
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
                Aero.AjouterClient(CreerVoyageur(Aero.Passager_Min, Aero.Passager_Max, Aero));
                Aero.AjouterClient(CreerCargaison(Aero.Passager_Min, Aero.Passager_Max, Aero));
            }

            Random rand = new Random(DateTime.Now.Millisecond);
            int ind = rand.Next(1, 3);//Indice pour creer le nombre de point de detresse
            for (int i = ind; i <= 3; i++)
            {
                CreerPointDetresse();
            }

            ind = rand.Next(1, 2);//Indice pour creer le nombre de point d'incendie
            for (int i = ind; i <= 3; i++)
            {
                CreerSurCarte(typeClient.Incendie);
            }
            CreerSurCarte(typeClient.Point);
        }

        //Creer un point de detresse
        private void CreerPointDetresse()
        {
            Random rand = new Random(DateTime.Now.Millisecond);

            //creer un position aléatoire sur la carte
            int x = rand.Next(0, Resource.carte_du_monde.Width);
            int y = rand.Next(0, Resource.carte_du_monde.Height);
            Position mapPosition = new Position(x, y);

            UsineClient usineClient = new UsineClient();
            TrouverAeroportProche(mapPosition).AjouterClient(usineClient.creeClient(mapPosition));
        }

        //Creer un incendit ou un point d'intérêt
        private void CreerSurCarte(typeClient type)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int value = rand.Next(1, 3); //Creer un valeur aleatoire

            //creer un position aléatoire sur la carte
            int x = rand.Next(0, Resource.carte_du_monde.Width);
            int y = rand.Next(0, Resource.carte_du_monde.Height);
            Position mapPosition = new Position(x,y);

            UsineClient usineClient = new UsineClient();
            TrouverAeroportProche(mapPosition).AjouterClient(usineClient.creeClient(type,mapPosition,value));
        }

        //trouve l'aeroport la plus proche d'une position
        private CAeroport TrouverAeroportProche(Position mapPosition)
        {
            CAeroport aeroport = null;//Aeroport actuellement le plus près
            foreach (CAeroport Aero in this.ListeAeroports)
            {
                if (aeroport == null)
                {
                    aeroport = Aero;
                }
                else if (CalculerDistance(aeroport.position,mapPosition) > CalculerDistance(Aero.position,mapPosition))
                {
                    aeroport = Aero;
                }
            }
            return aeroport;
        }

        //calcule la distance entre 2 position sur la carte
        private double CalculerDistance(Position PosiAero,Position mapPosition)
        {
            double Distance;
            Distance = Math.Sqrt((Math.Abs(PosiAero.x - mapPosition.x) ^ 2) + (Math.Abs(PosiAero.y - mapPosition.y) ^ 2));

            return Distance;
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

		private void UpdateAeronef(int TimeSecs)
		{
			EnvoyerAeronefVol();
			RetirerAeronefVol(TimeSecs);
		}

		private void EnvoyerAeronefVol()
		{
			foreach (CAeroport aeroport in ListeAeroports)
			{
				for (int i = 0; i < aeroport.nbAeronef; i++)
				{
					if (aeroport[i].etat.Status == EtatAeronef.Vol)
					{
						ListeAeronefVol.Add(aeroport[i]);
						aeroport.RetierAeronef(aeroport[i]);
					}
				}
			}
		}

		private void RetirerAeronefVol(int TimerSecs)
		{
			List<CAeronef> AeronefARetier =
				ListeAeronefVol.FindAll(aeronef => (aeronef.etat as CVol).Fini);
			int aeroportIndex;
			foreach (CAeronef aeronefVol in AeronefARetier)
			{
				aeroportIndex = ListeAeroports.FindIndex(Aaeroport => Aaeroport.position.Equals((aeronefVol.etat as CVol).Actuelle));
				if (aeroportIndex != -1)
				{
					if (aeronefVol.changerEtat(TimerSecs) != EtatAeronef.Vol)
					{
						AjouterAeronef(ListeAeroports[aeroportIndex], aeronefVol);
						ListeAeronefVol.Remove(aeronefVol);
					}
				}
			}
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
