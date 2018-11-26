using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	abstract class CDansAeroport:CClients
	{
		private CAeroport Destination;

		public CDansAeroport()
		{

		}

		public CDansAeroport(CAeroport Destination)
		{
			this.Destination = Destination;
		}

		public Position destination
		{
			get { return Destination.position; }
		}
	}
}
