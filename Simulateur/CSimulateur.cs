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

	public delegate void Update();
	public delegate void TimeDelegue(string timeString);
	public delegate void UpdateDelegueEtat(int TimeSecs);
    public delegate void UpdateDelegueClient(int TimeSecs);

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
		Update updateDelegue;
		Thread formRun;

		public CSimulateur()
		{
			updateDelegue = new Update(Update);
			Timer = new CHorloge(1000,updateDelegue,1);
			VSimulateur = new fchSimulateur(this);
			formRun = new Thread(new ThreadStart(() => Application.Run(VSimulateur)));
			formRun.Start();
			m_scenario = new Scenario();
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

		private void Update()
		{
			// Méthode delegue pour Update l'horloge de la fchSimulateur
			try
			{
				VSimulateur.Invoke(VSimulateur.timeDelegue, new object[] {Timer.ToString()});
				m_scenario.UpdateEtat(Timer.SecondesEcouler());
				m_scenario.UpdateClient(Timer.SecondesEcouler());
			}
			catch
			{
				formRun = null;
				Application.Exit();
			}
		}
	}
}
