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
		string Nom,
			   Ville;
		int MinPassager,
			MaxPassager;
		int MinCargo,
			MaxCargo;
		Position m_position;
		List<CAeronef> Aeronefs;
		CUsineAeronef UsineAeronef;

		public CAeroport() {
			Aeronefs = new List<CAeronef>();
		}

		public CAeroport(string Nom, string Ville, int MinPassager, int MaxPassager, int MinCargo, int MaxCargo, int posX, int posY)
		{
			this.Nom = Nom;
			this.Ville = Ville;
			this.MinPassager = MinPassager;
			this.MaxPassager = MaxPassager;
			this.MinCargo = MinCargo;
			this.MaxCargo = MaxCargo;
			m_position = new Position(posX, posY);
			UsineAeronef = new CUsineAeronef();
			Aeronefs = new List<CAeronef>();
		}

		public Position position
		{
			get { return m_position; }
			set { m_position = value; }
		}

		public string nom
		{
			get { return Nom; }
			set { Nom = value; }
		}
        public string ville
        {
            get { return Ville; }
            set { Ville = value; }
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

		public CAeronef[] aeronefs{
			get { return Aeronefs.ToArray(); }
			set { Aeronefs = value.ToList(); }
		}

		public CAeronef this[int i]
		{
			get { return Aeronefs.ElementAt(i); }
			set { Aeronefs[i] = value; }
		}

		[XmlIgnore]
        public int nbAeronefs
        {
            get { return Aeronefs.Count; }
        }

		public void CreeAeronef(typeAvion Type, string Nom, int Vitesse, int Entretient, int Capacite)
		{
			AjouterAeronef(UsineAeronef.CreerAeronef(Type, Nom, Vitesse, Entretient, Capacite));
		}

		public void CreeAeronef(typeAvion Type, string Nom, int Vitesse, int Entretient, int Capacite, int Embarquement, int Debarquement, int Data)
		{
			AjouterAeronef(UsineAeronef.CreerAeronef(Type, Nom, Vitesse, Entretient, Capacite, Embarquement, Debarquement,Data));
		}

		public int AjouterAeronef(CAeronef Aeronef)
		{
			Aeronefs.Add(Aeronef);
			return Aeronefs.Count();
		}
		public void RetierAeronef (int i)
		{
			Aeronefs.RemoveAt(i);
		}

		public override string ToString()
		{
			return string.Format("{0} ({1}), Min Passager : {2}, Max Passager : {3}, Min Marchandise : {4}, Max Marchandise : {5}", new object[] {nom, position.ConvertirPosition(),this.MinPassager,this.MaxPassager,this.MinCargo,this.MaxCargo }); 
		}
	}
}
