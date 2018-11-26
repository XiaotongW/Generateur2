using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Simulateur
{
	public abstract class CTransport : CAeronef
	{
		protected int Embarquement;
		protected int Debarquement;
		public CTransport()
		{

		}
		public CTransport(string Nom, int Vitesse, int Entretient, int Capacite, int Embarquement, int Debarquement):base(Nom,Vitesse,Entretient,Capacite)
		{
			this.Embarquement = Embarquement;
			this.Debarquement = Debarquement;
		}

		public int embarquement
		{
			get { return Embarquement; }
			set { Embarquement = value; }
		}

		public int debarquement
		{
			get { return Debarquement; }
			set { Debarquement = value; }
		}
	}
}
