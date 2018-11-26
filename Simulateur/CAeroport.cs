using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Simulateur
{
	public class CAeroport
	{
		string Nom;
		int MinPassager,
			MaxPassager;
		int MinCargo,
			MaxCargo;
		List<CAeronef> Aeronefs;

		public CAeroport() {
			Aeronefs = new List<CAeronef>();
		}

		public CAeroport(string Nom, int MinPassager, int MaxPassager, int MinCargo,int MaxCargo)
		{
			this.Nom = Nom;
			this.MinPassager = MinPassager;
			this.MaxPassager = MaxPassager;
			this.MinCargo = MinCargo;
			this.MaxCargo = MaxCargo;
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
		public int AjouterAeronef(CAeronef Aeronef)
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
			return string.Format("{0} ({1} N, {2} O), Min Passager : {3}, Max Passager : {4}, Min Marchandise : {5}, Max Marchandise : {6}", new object[] {nom, 0,0,this.MinPassager,this.MaxPassager,this.MinCargo,this.MaxCargo }); 
		}
	}
}
