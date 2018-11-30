using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	public enum EtatAeronef {Inactif,Embarquement,Vol,Debarquement,Maintenance, Sauvetage,Observation,Largage};

	public abstract class Etat
	{
		EtatAeronef m_Etat;
		public Etat(EtatAeronef etat)
		{
			m_Etat = etat;
		}

		public EtatAeronef Status
		{
			get { return m_Etat; }
			set { m_Etat = value; }
		}
		protected virtual Etat ChangerEtat()
		{
			return this;
		}
		public abstract Etat ChangerEtat(CAeronef aeronef);
		public virtual Etat ChangerEtat(CAeronef aeronef, Position depart,Position arriver)
		{
			return this;
		} 
	}
}
