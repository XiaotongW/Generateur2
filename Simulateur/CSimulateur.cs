using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Serialization;
using System.IO;

namespace Simulateur
{
	public delegate void TimeDelegue(string timeString);
	public class CSimulateur
	{
		[STAThread]
		static void Main()
		{
			new CSimulateur();
		}

		CHorloge Timer;
		fchSimulateur VSimulateur;
		Scenario m_scenario;
		TimeDelegue UpdateTime;
		Thread formRun;

		public CSimulateur()
		{
			UpdateTime = new TimeDelegue(UpdateHorloge);
			Timer = new CHorloge(1000,UpdateTime,1);
			VSimulateur = new fchSimulateur(this);
			formRun = new Thread(new ThreadStart(() => Application.Run(VSimulateur)));
			formRun.Start();
			Timer.Start();
		}

		public Scenario scenario
		{
			get { return m_scenario; }
			set { m_scenario = value; }
		}

		public void chargerScenario(string LeScenario)
		{
			XmlSerializer xs = new XmlSerializer(typeof(Scenario));
			using (StreamReader sr = new StreamReader(LeScenario))
			{
				scenario = xs.Deserialize(sr) as Scenario;
			}
		}

		private void UpdateHorloge(string timeString)
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
