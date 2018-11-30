using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	class CInactif:Etat
	{

		public CInactif():base(EtatAeronef.Inactif)
		{
			
		}

		public override Etat ChangerEtat(CAeronef aeronef)
		{
			return base.ChangerEtat();
		}
	}
}
