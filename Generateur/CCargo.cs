using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Generateur
{
	public class CCargo:CTransport
	{
		private int qteCargo;
		public CCargo()
		{

		}
		public CCargo(string Nom, int Vitesse, int Entretient, int Capacite, int Embarquement, int Debarquement, int qteCargo) : base(Nom, Vitesse, Entretient, Capacite, Embarquement,Debarquement)
		{
			this.qteCargo = qteCargo;
		}

		public int QteCargo
		{
			get { return qteCargo; }
			set { qteCargo = value; }
		}

		public override string ToString()
		{
			return string.Format(
				"{0} {1} (Cargo), Capacité : {2}, Vitesse : {3}, Temps embarquement : {4}, débarquement : {5}, entretient {6}",
				new object[] { this.Nom, this.QteCargo, this.Capacite, this.vitesse, this.embarquement, this.debarquement, this.entretient }
			);
		}
	}
}
