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
			Timer = new CHorloge(UpdateTime,1000);
			formRun = new Thread(new ThreadStart(() => Application.Run(VSimulateur)));
			formRun.Start();
			Timer.DebutHorloge();
		}

		public void UpdateHorloge(string timeString)
		{
			try
			{
				VSimulateur.Invoke(VSimulateur.timeDelegue,new object[] {timeString});
			}
			catch (Exception)
			{
				formRun.Abort();
			}
		}
	}
}
