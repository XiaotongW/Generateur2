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

		public CClients ajouterClient(CAeroport aeroport, int nombreClient)
		{
			return new CVoyageur(aeroport,nombreClient);
		}
		public CClients ajouterClient(CAeroport aeroport, double poid)
		{
			return new CCargaison(aeroport, poid);
		} 

		public CClients ajouterClient(int x,int y, int intensite)
		{
			return new CIncendie(x, y, intensite);
		}
		public CClients ajouterClient(int x, int y)
		{
			return new CDetresse(x, y);
		}
		public CClients ajouterClient (Position position, int rayon)
		{
			return new CPoint(position, rayon);
		}
	}
}
