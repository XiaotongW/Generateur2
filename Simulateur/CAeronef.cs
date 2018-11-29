using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Simulateur
{
	public abstract class CAeronef
	{
		protected string Nom;
		protected int Vitesse;
		protected int Entretient;
		protected int Capacite;
		protected Etat m_etat;
		protected int DernierChangementEtat;

		public CAeronef()
		{
			
		}

		public CAeronef(string Nom, int Vitesse, int Entretient, int Capacite)
		{
			this.Nom = Nom;
			this.Vitesse = Vitesse;
			this.Entretient = Entretient;
			this.Capacite = Capacite;
			m_etat = new CInactif();
			DernierChangementEtat = 0;
		}

		public string nom
		{
			get { return Nom; }
			private set { Nom = value; }
		}
		public int vitesse
		{
			get { return Vitesse; }
			set { Vitesse = value; }
		}
		public int entretient
		{
			get { return Entretient; }
			set { Entretient = value; }
		}
		public int capacite
		{
			get { return Capacite; }
			set { Capacite = value; }
		}
		public Etat etat
		{
			get { return m_etat; }
		}

		public int DebutEtat
		{
			get { return DernierChangementEtat; }
		}

		public EtatAeronef changerEtat(Etat p_etat, int TimerSecs)
		{
			DernierChangementEtat = TimerSecs;
			m_etat = (m_etat.Status == EtatAeronef.Inactif) ? p_etat : m_etat;
			return m_etat.Status;
		}
		public EtatAeronef changerEtat(int TimerSecs)
		{
			DernierChangementEtat = TimerSecs;
			m_etat = m_etat.ChangerEtat(this);
			return m_etat.Status;
		}
	}
}
