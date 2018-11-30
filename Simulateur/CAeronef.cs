using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Simulateur
{
	public enum typeAvion { Passager, Cargo, Loisir, Secours, Citerne };
	[XmlInclude(typeof(CLoisir))]
	[XmlInclude(typeof(CCiterne))]
	[XmlInclude(typeof(CSecours))]
	[XmlInclude(typeof(CPassager))]
	[XmlInclude(typeof(CCargo))]
	[XmlInclude(typeof(CTransport))]
	public abstract class CAeronef
	{
		protected string Nom;
		protected int Vitesse;
		protected int Entretient;
		protected int Capacite;
		protected Etat m_etat;
		protected int DernierChangementEtat;
		protected typeAvion type;
		public CAeronef()
		{
			m_etat = new CInactif();
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

		[XmlIgnore]
		public typeAvion Type
		{
			get { return type; }
		}

		public string nom
		{
			get { return Nom; }
			set { Nom = value; }
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
		[XmlIgnore]
		public Etat etat
		{
			get { return m_etat; }
		}
		[XmlIgnore]
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
		public EtatAeronef changerEtat(int TimerSecs, Position posDepart, Position posArriver)
		{
			DernierChangementEtat = TimerSecs;
			m_etat = (m_etat.Status==EtatAeronef.Embarquement)?m_etat.ChangerEtat(this,posDepart,posArriver):m_etat.ChangerEtat(this);
			return m_etat.Status;
		}
	}
}
