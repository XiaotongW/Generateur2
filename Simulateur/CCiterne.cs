using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Simulateur
{
	public class CCiterne : CAeronef
	{
		public CCiterne()
		{
			m_etat = new CInactif();
			type = typeAvion.Citerne;
		}
		public CCiterne(string Nom, int Vitesse, int Entretient, int Capacite) : base(Nom, Vitesse, Entretient, Capacite)
		{
			m_etat = new CInactif();
			type = typeAvion.Citerne;
		}
		public override string ToString()
		{
			return string.Format(
				"{0} (Citerne), Capacité : {1}, Vitesse : {2}, entretient {3}",
				new object[] { this.Nom, this.Capacite, this.vitesse, this.entretient }
			);
		}
	}
}
