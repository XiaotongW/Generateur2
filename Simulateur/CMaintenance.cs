using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	class CMaintenance:Etat
	{
		protected bool MaintenanceFini;
		int FinMaintenance;
		public CMaintenance(int timerDebut,int tempsMaintenance):base(EtatAeronef.Maintenance)
		{
			FinMaintenance = (timerDebut + tempsMaintenance <= timerDebut) ? 0: timerDebut + tempsMaintenance;
			MaintenanceFini = tempsMaintenance <= 0;
		}

		public bool Fini
		{
			get { return MaintenanceFini; }
		}

		public override Etat ChangerEtat(CAeronef aeronef)
		{
			return Fini ? new CInactif():base.ChangerEtat(aeronef);
		}
	}
}
