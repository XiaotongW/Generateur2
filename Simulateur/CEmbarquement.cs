using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	class CEmbarquement : Etat
	{
		protected bool EmbarquementFini;
		int FinEmbarquement;
		Position depart;
		Position arriver;
		public CEmbarquement(int timerDebut, int tempsEmbarquement, int nbrEmbarquer,Position depart,Position arriver) : base(EtatAeronef.Embarquement)
		{
			EmbarquementFini = tempsEmbarquement <= 0;
			FinEmbarquement = (timerDebut + tempsEmbarquement * nbrEmbarquer <= timerDebut) ? 0 : timerDebut + tempsEmbarquement * nbrEmbarquer;
			this.depart = depart;
			this.arriver = arriver;
		}

		public bool Fini
		{
			get { return EmbarquementFini; }
			private set { EmbarquementFini = value; }
		}

		public override Etat ChangerEtat(CAeronef aeronef)
		{
			return Fini ? new CVol(EtatAeronef.Embarquement,depart, arriver): base.ChangerEtat();
		}
	}
}
