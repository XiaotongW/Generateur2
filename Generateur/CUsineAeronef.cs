using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Generateur
{
	public class CUsineAeronef
	{
		public CUsineAeronef()
		{

		}

		public CAeronef CreerAeronef(string Type,string Nom, int Vitesse, int Entretient, int Capacite, int Embarquement, int Debarquement, int Data)
		{
			if (Type == "Passager")
				return new CPassager(Nom, Vitesse, Entretient, Capacite, Embarquement, Debarquement, Data);
			else if (Type == "Cargo")
				return new CCargo(Nom, Vitesse, Entretient, Capacite, Embarquement, Debarquement, Data);

			return null;
		}

		public CAeronef CreerAeronef(string Type, string Nom, int Vitesse, int Entretient, int Capacite)
		{
			if (Type == "Loisir")
				return new CLoisir(Nom, Vitesse, Entretient, Capacite);
			else if (Type == "Secours")
				return new CSecours(Nom, Vitesse, Entretient, Capacite);
			else if (Type == "Citerne")
				return new CCiterne(Nom, Vitesse, Entretient, Capacite);

			return null;
		}
	}
}
