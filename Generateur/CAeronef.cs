using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Generateur
{
	public abstract class CAeronef
	{
		protected string Nom;
		protected int Vitesse;
		protected int Entretient;
		protected int Capacite;

		public CAeronef()
		{

		}

		public CAeronef(string Nom, int Vitesse, int Entretient, int Capacite)
		{
			this.Nom = Nom;
			this.Vitesse = Vitesse;
			this.Entretient = Entretient;
			this.Capacite = Capacite;
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
	}
}
