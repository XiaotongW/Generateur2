using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	public class UsineClient
	{
		public UsineClient()
		{

		}

		// DansAeroport
		public CClients creeClient(CAeroport aeroport, int nombreClient)
		{// Aeronef Voyageur
			return new CVoyageur(typeClient.Voyageur, aeroport, nombreClient);
		}
		public CClients creeClient(CAeroport aeroport, double poid)
		{// Aeronef cargaison
			return new CCargaison(typeClient.Cargaison,aeroport, poid);
		}

		// SurCarte
		public CClients creeClient(typeClient client, Position mapPosition, int clValue)
		{// Aeronef Incendie
			if (client == typeClient.Incendie)
				return new CIncendie(client,mapPosition, clValue); // ClValue = Intensite
			else if (client == typeClient.Point)
				return new CPoint(client,mapPosition, clValue); // clValue = rayon
			return null;
		}
		public CClients creeClient(Position mapPosition)
		{// Aeronef Detresse
			return new CDetresse(typeClient.Detresse,mapPosition);
		}
	}
}
