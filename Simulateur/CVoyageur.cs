using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	class CVoyageur:CDansAeroport
	{
		protected int nombreClient;
		public CVoyageur(typeClient client, CAeroport aeroport, int nombreClient):base(client, aeroport)
		{
			this.nombreClient = nombreClient;
			Destination = aeroport;
		}

		public int clients
		{
			get { return nombreClient; }
			set { nombreClient = value; }
		}
	}
}
