using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Generateur
{
	public class CAeroport
	{
		string Nom;
		int MinPassager,
			MaxPassager;
		int MinCargo,
			MaxCargo;
		Position position;
		List<CAeronef> Aeronefs;
		CUsineAeronef UsineAeronef;

		public CAeroport() {
			Aeronefs = new List<CAeronef>();
		}

		public CAeroport(string Nom, int MinPassager, int MaxPassager, int MinCargo,int MaxCargo, int posX, int posY)
		{
			this.Nom = Nom;
			this.MinPassager = MinPassager;
			this.MaxPassager = MaxPassager;
			this.MinCargo = MinCargo;
			this.MaxCargo = MaxCargo;
			position = new Position(posX, posY);
			UsineAeronef = new CUsineAeronef();
			Aeronefs = new List<CAeronef>();
		}
		public string nom
		{
			get { return Nom; }
			set { Nom = value; }
		}
		public int Passager_Min
		{
			get { return MinPassager; }
			set { MinPassager = value; }
		}
		public int Passager_Max
		{
			get { return MaxPassager; }
			set { MaxPassager = value; }
		}
		public int Cargo_Min
		{
			get { return MinCargo; }
			set { MinCargo = value; }
		}
		public int Cargo_Max
		{
			get { return MaxCargo; }
			set { MaxCargo = value; }
		}
		public CAeronef this[int i]
		{
			get { return Aeronefs.ElementAt(i); }
			set { Aeronefs[i] = value; }
		}

		public void CreeAeronef(typeAvion Type, string Nom, int Vitesse, int Entretient, int Capacite)
		{
			AjouterAeronef(UsineAeronef.CreerAeronef(Type, Nom, Vitesse, Entretient, Capacite));
		}

		public void CreeAeronef(typeAvion Type, string Nom, int Vitesse, int Entretient, int Capacite, int Embarquement, int Debarquement, int Data)
		{
			AjouterAeronef(UsineAeronef.CreerAeronef(Type, Nom, Vitesse, Entretient, Capacite, Embarquement, Debarquement,Data));
		}

		protected int AjouterAeronef(CAeronef Aeronef)
		{
			Aeronefs.Add(Aeronef);
			return Aeronefs.Count();
		}
		public void RetierAeronef (CAeronef Aeronef)
		{
			Aeronefs.RemoveAt(Aeronefs.FindIndex(e => e == Aeronef));
		}

		public override string ToString()
		{
			return string.Format("{0} ({1}), Min Passager : {2}, Max Passager : {3}, Min Marchandise : {4}, Max Marchandise : {5}", new object[] {nom, position.ConvertirPosition(),this.MinPassager,this.MaxPassager,this.MinCargo,this.MaxCargo }); 
		}
	}
}
