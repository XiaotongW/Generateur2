using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
	public enum typeAvion { Passager,Cargo,Loisir,Secours,Citerne};

	public class CUsineAeronef
	{
		public CUsineAeronef()
		{

		}

		public CAeronef CreerAeronef(typeAvion Type,string Nom, int Vitesse, int Entretient, int Capacite, int Embarquement, int Debarquement, int Data)
		{
			if (Type == typeAvion.Passager)
				return new CPassager(Nom, Vitesse, Entretient, Capacite, Embarquement, Debarquement, Data);
			else if (Type == typeAvion.Cargo)
				return new CCargo(Nom, Vitesse, Entretient, Capacite, Embarquement, Debarquement, Data);

			return null;
		}

		public CAeronef CreerAeronef(typeAvion Type, string Nom, int Vitesse, int Entretient, int Capacite)
		{
			if (Type == typeAvion.Loisir)
				return new CLoisir(Nom, Vitesse, Entretient, Capacite);
			else if (Type == typeAvion.Secours)
				return new CSecours(Nom, Vitesse, Entretient, Capacite);
			else if (Type == typeAvion.Citerne)
				return new CCiterne(Nom, Vitesse, Entretient, Capacite);

			return null;
		}
	}
}
