using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Simulateur
{
	public delegate void TimeDelegue(string timeString);
	public class CSimulateur
	{
		CHorloge Timer;
		fchSimulateur VSimulateur;
		TimeDelegue UpdateTime;
		Thread formRun;
		public CSimulateur()
		{
			VSimulateur = new fchSimulateur(this);
			UpdateTime = new TimeDelegue(UpdateHorloge);
			Timer = new CHorloge(1000,UpdateTime,2);
			formRun = new Thread(new ThreadStart(() => Application.Run(VSimulateur)));
			formRun.Start();
			Timer.Start();
		}

		public void UpdateHorloge(string timeString)
		{
			// Méthode delegue pour Update l'horloge de la fchSimulateur
			try
			{
				VSimulateur.Invoke(VSimulateur.timeDelegue, new object[] {timeString});
			}
			catch
			{
				formRun = null;
				Application.Exit();
			}
		}
	}
}
