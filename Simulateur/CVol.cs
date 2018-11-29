using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	class CVol:Etat
	{
		protected Position m_posActuelle;
		protected Position m_posArriver;
		EtatAeronef m_prevEtat;	
		public CVol(EtatAeronef dernierEtat, Position posActuelle, Position posArriver):base(EtatAeronef.Vol)
		{
			m_posActuelle = posActuelle;
			m_posArriver = posArriver;
			m_prevEtat = dernierEtat;
		}

		public Position Actuelle
		{
			get { return m_posActuelle; }
		}

		public Position Arriver
		{
			get { return m_posArriver; }
		}

		public bool Fini
		{
			get { return m_posActuelle == m_posArriver; }
		}

		public Etat ChangerEtat(CAeronef aeronef, int TimerSecs)
		{
			if (!Fini)
			{
				int TimeDiff = TimerSecs - aeronef.DebutEtat;
				//if (TimeDiff >= 3600)
				//{
				//	double DistanceParcouru = aeronef.vitesse * (TimeDiff / 3600);
				//	double t = (TimeDiff / 3600) / 1+(Math.Abs((m_posArriver.x + m_posArriver.y) + (m_posActuelle.x - m_posActuelle.y) / aeronef.vitesse));
				//}

			}
			if (m_prevEtat == EtatAeronef.Embarquement)
				return Fini ? new CDebarquement(aeronef.DebutEtat,(aeronef as CTransport).debarquement,aeronef.capacite) : base.ChangerEtat(aeronef);

			return Fini ? new CMaintenance(aeronef.DebutEtat,aeronef.entretient): base.ChangerEtat(aeronef);
		}
	}
}
