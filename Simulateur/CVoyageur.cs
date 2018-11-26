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
		public CVoyageur(CAeroport aeroport, int nombreClient):base(aeroport)
		{
			this.nombreClient = nombreClient;
		}

		public int clients
		{
			get { return nombreClient; }
			set { nombreClient = value; }
		}
	}
}
