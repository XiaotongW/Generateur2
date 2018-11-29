using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	class CObservation:CVol
	{
		
		public CObservation(Position posActuelle, Position posArriver) :base(EtatAeronef.Vol,posActuelle,posArriver)
		{
			
		}

		public override Etat ChangerEtat(CAeronef aeronef)
		{
			return Fini ? new CVol(EtatAeronef.Observation, m_posArriver, m_posDepart) : base.ChangerEtat(aeronef);
		}
	}
}
