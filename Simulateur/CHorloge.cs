using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Simulateur
{
	class CHorloge
	{
		Timer m_Timer;
		bool enPause;
		int TimeSpeed;
		int Heures, Minutes, Secondes;
		TimeDelegue UpdateDelegue;

		public CHorloge(TimeDelegue monDelegue,int speed=1)
		{
			m_Timer = new Timer((int)(1000 / speed));
			m_Timer.Elapsed += OnTimedEvent;
			m_Timer.AutoReset = false;
			TimeSpeed = speed;
			enPause = false;
			Heures = 0;
			Minutes = 0;
			Secondes = 0;
			UpdateDelegue = monDelegue;
		}

		public string DebutHorloge()
		{
			restart();
			return ToString();
		}

		public void setPause()
		{
			enPause = true;
			m_Timer.AutoReset = false;
			m_Timer.Stop();
		}

		public void restart()
		{
			enPause = false;
			m_Timer.AutoReset = true;
			m_Timer.Start();
		}

		public void resetTimer()
		{
			m_Timer = new Timer((int)(1000 / TimeSpeed));
			m_Timer.Elapsed += OnTimedEvent;
			Heures = 0;
			Minutes = 0;
			Secondes = 0;
			restart();
		}

		public int speed
		{
			get { return TimeSpeed; }
			set {
				TimeSpeed = (value <= 1000 && value >= 1) ? value:TimeSpeed;
				m_Timer.Interval = (int)(1000 / TimeSpeed);
			}
		}

		public int secondesEcouler()
		{
			return Heures * 60 * 60 + Minutes * 60 + Secondes;
		}

		public override string ToString()
		{
			string heuresStr = (Heures <= 9) ? "0" + Heures.ToString() : Heures.ToString();
			string MinutesStr = (Minutes <= 9) ? "0" + Minutes.ToString() : Minutes.ToString();
			string SecondesStr = (Secondes <= 9) ? "0" + Secondes.ToString() : Secondes.ToString();
			return string.Format("{0} : {1} : {2}",heuresStr,MinutesStr,SecondesStr);
		}

		private void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			if (!enPause) Secondes += 1;
			if (Secondes > 59)
			{
				do
				{
					Minutes += 1;
					while (Minutes >= 60)
					{
						Heures = (Heures+1 == 24) ? 0 : Heures+1;
						Minutes -= 60;
					}
					Secondes -= 60;
				} while (Secondes >= 60);
			}

			UpdateDelegue(ToString());
		}
	}
}
