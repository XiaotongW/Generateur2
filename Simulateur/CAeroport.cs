using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Simulateur
{
	public class CAeroport
	{
		string Nom,
			Ville;
		int MinPassager,
			MaxPassager;
		int MinCargo,
			MaxCargo;
		Position m_position;
		List<CAeronef> Aeronefs;
        List<CClients> Clients;
		public CAeroport() {
			Aeronefs = new List<CAeronef>();
            Clients = new List<CClients>();
		}

		public CAeroport(string Nom, string Ville,int MinPassager, int MaxPassager, int MinCargo,int MaxCargo, int posX, int posY)
		{
			this.Nom = Nom;
			this.Ville = Ville;
			this.MinPassager = MinPassager;
			this.MaxPassager = MaxPassager;
			this.MinCargo = MinCargo;
			this.MaxCargo = MaxCargo;
			m_position = new Position(posX, posY); 
			Aeronefs = new List<CAeronef>();
			Clients = new List<CClients>();
		}
		public string nom
		{
			get { return Nom; }
			set { Nom = value; }
		}

		public string ville
		{
			get { return Ville; }
			set { Ville = value; }
		}

		public int Passager_Min
		{
			get { return MinPassager; }
			set { MinPassager = value; }
		}
		public int Passager_Max
		{
			get { return MaxPassager; }
			set { MaxPassager = value; }
		}
		public int Cargo_Min
		{
			get { return MinCargo; }
			set { MinCargo = value; }
		}
		public int Cargo_Max
		{
			get { return MaxCargo; }
			set { MaxCargo = value; }
		}

		public int nbAeronef
		{
			get { return Aeronefs.Count(); }
		}

		public CAeronef this[int i]
		{
			get { return Aeronefs.ElementAt(i); }
			set { Aeronefs[i] = value; }
		}

		public Position position {
			get { return m_position; }
			set { m_position = value; }
		}

		public override string ToString()
		{
			return string.Format("{0} ({1}), Min Passager : {2}, Max Passager : {3}, Min Marchandise : {4}, Max Marchandise : {5}", new object[] { nom, position.ConvertirPosition(), this.MinPassager, this.MaxPassager, this.MinCargo, this.MaxCargo });
		}

		public void AjouterClient(CClients Client)
        {
            Clients.Add(Client);
			
        }
        public void RetierClient(CClients Client)
        {
            Clients.RemoveAt(Clients.FindIndex(e => e == Client));
        }

        public int AjouterAeronef(CAeronef Aeronef)
		{
			Aeronefs.Add(Aeronef);
			return Aeronefs.Count();
		}
		public void RetierAeronef (CAeronef Aeronef)
		{
			Aeronefs.RemoveAt(Aeronefs.FindIndex(e => e == Aeronef));
		}

		public void assignerClients(int TimerDebut)
		{
			CAeronef aeronef;
			foreach (CClients client in Clients)
			{
				switch (client.TypeClient)
				{
					case typeClient.Voyageur:
						aeronef=ChoisirAeronef(client as CVoyageur);
						aeronef.changerEtat(new CEmbarquement(TimerDebut, (aeronef as CTransport).embarquement, (client as CVoyageur).clients),TimerDebut);
						break;
					case typeClient.Cargaison:
						aeronef=ChoisirAeronef(client as CCargaison);
						aeronef.changerEtat(new CEmbarquement(TimerDebut,(aeronef as CTransport).embarquement,(int)(client as CCargaison).poid),TimerDebut);
						break;
					case typeClient.Incendie:
					case typeClient.Detresse:
					case typeClient.Point:
						aeronef=ChoisirAeronef(client.TypeClient);
						aeronef.changerEtat(new CVol(EtatAeronef.Inactif, position, (client as CSurCarte).position),TimerDebut);
						break;
				}
			}
		}
		private CAeronef ChoisirAeronef(CVoyageur client) {
			List<CAeronef> aPassager =
				Aeronefs.FindAll(vehicule => (vehicule.etat.Status == EtatAeronef.Inactif && vehicule.GetType()== typeof(CPassager)));

			if (aPassager.Count <= 0) return null;

			aPassager.Sort((x, y) => x.capacite.CompareTo(y.capacite));
			CAeronef aeronef = aPassager.ElementAt(aPassager.Count - 1);
			for (int i = aPassager.Count() - 2; i >= 0 && aeronef.capacite > client.clients; i--)
				aeronef = (aPassager.ElementAt(i).capacite >= client.clients) ? aPassager.ElementAt(i) : aeronef;
			return aeronef;
		}

		private CAeronef ChoisirAeronef(CCargaison client)
		{
			List<CAeronef> aCargo =
			Aeronefs.FindAll(vehicule => (vehicule.etat.Status == EtatAeronef.Inactif && vehicule.GetType() == typeof(CCargo)));

			if (aCargo.Count <= 0) return null;

			aCargo.Sort((x, y) => x.capacite.CompareTo(y.capacite));
			CAeronef aeronef = aCargo.ElementAt(aCargo.Count - 1);
			for (int i = aCargo.Count() - 2; i >= 0 && aeronef.capacite > client.poid; i--)
				aeronef = (aCargo.ElementAt(i).capacite >= client.poid) ? aCargo.ElementAt(i) : aeronef;
			return aeronef;
		}

		private CAeronef ChoisirAeronef(typeClient clientType)
		{
			Type aeronefType=null;
			switch (clientType)
			{
				case typeClient.Incendie:
					aeronefType = typeof(CCiterne);
					break;
				case typeClient.Detresse:
					aeronefType = typeof(CSecours);
					break;
				case typeClient.Point:
					aeronefType = typeof(CLoisir);
					break;
				default:
					return null;
			}
			List<CAeronef> vehicules =
				Aeronefs.FindAll(vehicule => (vehicule.etat.Status == EtatAeronef.Inactif && vehicule.GetType() == aeronefType));
			if (vehicules.Count() <= 0) return null;
			return vehicules.ElementAt(vehicules.Count - 1);
		}
	}
}
