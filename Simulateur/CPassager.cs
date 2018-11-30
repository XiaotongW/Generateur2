using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Simulateur
{
	public class CPassager:CTransport
	{
		int nbPassager;

		public CPassager()
		{
			type = typeAvion.Passager;
			m_etat = new CInactif();
		}
		public CPassager(string Nom, int Vitesse, int Entretient, int Capacite, int Embarquement, int Debarquement,int nbPassager) : base(Nom, Vitesse, Entretient, Capacite, Embarquement, Debarquement)
		{
			this.nbPassager = nbPassager;
			m_etat = new CInactif();
			type = typeAvion.Passager;
		}
		public int Passager
		{
			get { return nbPassager; }
			set { nbPassager = value; }
		}

		public override string ToString()
		{
			return string.Format(
				"{0} {1} (Passager), Capacité : {2}, Vitesse : {3}, Temps embarquement : {4}, débarquement : {5}, entretient {6}", 
				new object []{ this.Nom, this.Passager,this.Capacite,this.vitesse,this.embarquement,this.debarquement,this.entretient}
			);
		}
	}
}
