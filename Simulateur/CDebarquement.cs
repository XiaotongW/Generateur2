using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	class CDebarquement:Etat
	{
		protected bool DebarquementFini;
		int FinDebarquement;
		public CDebarquement(int timerDebut, int tempsDebarquement, int nbrDembarquer) :base(EtatAeronef.Debarquement)
		{
			DebarquementFini = tempsDebarquement <= 0;
			FinDebarquement = (timerDebut + tempsDebarquement * nbrDembarquer <= timerDebut) ? 0 : timerDebut + tempsDebarquement * nbrDembarquer;
		}

		public bool Fini
		{
			get { return DebarquementFini; }
		}

		public override Etat ChangerEtat(CAeronef aeronef)
		{
			return Fini ? new CMaintenance(aeronef.DebutEtat,aeronef.entretient):base.ChangerEtat(aeronef);
		}

	}
}
