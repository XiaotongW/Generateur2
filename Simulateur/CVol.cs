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
		protected Position m_posDepart;
		EtatAeronef m_prevEtat;	
		public CVol(EtatAeronef dernierEtat, Position posActuelle, Position posArriver):base(EtatAeronef.Vol)
		{
			m_posActuelle = posActuelle;
			m_posArriver = posArriver;
			m_posDepart = posActuelle;
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

		public Position Depart
		{
			get { return m_posDepart; }
		}

		public bool Fini
		{
			get { return m_posActuelle == m_posArriver; }
		}

		public Etat ChangerEtat(CAeronef aeronef, int TimerSecs)
		{
			if (!Fini)
			{
				double TimeDiff = (TimerSecs - aeronef.DebutEtat)/3600.0;
				if (TimeDiff >= 1)
				{
					double a = (double)(m_posArriver.y - m_posActuelle.y) / (double)(m_posArriver.x - m_posActuelle.x);
					double x = (m_posActuelle.x + aeronef.vitesse * TimeDiff);
					double b = (a * (double)m_posActuelle.x - m_posActuelle.y)*-1;
					double y = a * x + b;
						
					m_posActuelle.x = (int)x;
					m_posActuelle.y = (int)y;
				}

			}
			if (m_prevEtat == EtatAeronef.Embarquement)
				return Fini ? new CDebarquement(aeronef.DebutEtat,(aeronef as CTransport).debarquement,aeronef.capacite) : base.ChangerEtat(aeronef);

			return Fini ? new CMaintenance(aeronef.DebutEtat,aeronef.entretient): base.ChangerEtat(aeronef);
		}
	}
}
