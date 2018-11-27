using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	class UsineClient
	{
		public UsineClient()
		{

		}

		// DansAeroport
		public CClients creeClient(CAeroport aeroport, int nombreClient)
		{// Aeronef Voyageur
			return new CVoyageur(aeroport, nombreClient);
		}
		public CClients creeClient(CAeroport aeroport, double poid)
		{// Aeronef cargaison
			return new CCargaison(aeroport, poid);
		}

		// SurCarte
		public CClients creeClient(typeClient client, Position mapPosition, int clValue)
		{// Aeronef Incendie
			if (client == typeClient.Incendie)
				return new CIncendie(mapPosition, clValue); // ClValue = Intensite
			else if (client == typeClient.Point)
				return new CPoint(mapPosition, clValue); // clValue = rayon
			return null;
		}
		public CClients creeClient(Position mapPosition)
		{// Aeronef Detresse
			return new CDetresse(mapPosition);
		}

	}
}
