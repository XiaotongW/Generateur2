﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	class CObservation:CVol
	{
		Position m_Depart;
		public CObservation(Position posActuelle, Position posArriver) :base(EtatAeronef.Vol,posActuelle,posArriver)
		{
			m_Depart = posActuelle;
		}

		public override Etat ChangerEtat(CAeronef aeronef)
		{
			return Fini ? new CVol(EtatAeronef.Observation, m_posArriver, m_Depart) : base.ChangerEtat(aeronef);
		}
	}
}
