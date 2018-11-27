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
		int m_TimeSpeed, m_Step;
		int Heures, Minutes, Secondes;
		TimeDelegue UpdateDelegue;

		public CHorloge(int speed, TimeDelegue timeDelegue, int Step)
		{
			m_TimeSpeed = speed;
			m_Step = Step;
			UpdateDelegue = timeDelegue;
			ResetTimer();
		}

		public CHorloge(TimeDelegue timeDelegue) : this (1, timeDelegue, 1)
		{

		}

		public CHorloge(int speed,TimeDelegue timeDelegue) :this(speed,timeDelegue,1)
		{

		}

		public CHorloge(TimeDelegue timeDelegue, int Step):this(1,timeDelegue,Step)
		{

		}

		public int speed
		{
			get { return m_TimeSpeed; }
			set {
				m_TimeSpeed = (value <= 1000 && value >= 1) ? value:m_TimeSpeed;
				m_Timer.Interval = 1000 / m_TimeSpeed;
			}
		}

		public int Step
		{
			get { return m_Step; }
			set { m_Step = (value >= 1 && value <= int.MaxValue) ? value : m_Step; }
		}

		public void Start()
		{
			m_Timer.Start();
		}

		public void Pause()
		{
			m_Timer.Stop();
		}

		public Timer ResetTimer()
		{
			m_Timer = new Timer(1000 / m_TimeSpeed);
			m_Timer.Elapsed += OnTimedEvent;
			Heures = 0;
			Minutes = 0;
			Secondes = 0;
			return m_Timer;
		}

		public int SecondesEcouler()
		{
			return Heures * 60 * 60 + Minutes * 60 + Secondes;
		}

		public override string ToString()
		{
			return string.Format("{0} : {1} : {2}",
				(Heures <= 9) ? "0" + Heures.ToString() : Heures.ToString(),
				(Minutes <= 9) ? "0" + Minutes.ToString() : Minutes.ToString(),
				(Secondes <= 9) ? "0" + Secondes.ToString() : Secondes.ToString()
				);
		}

		private void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			if (m_Timer.Enabled) Secondes += m_Step;
			if (Secondes > 59)
			{
				Minutes += (Secondes - Secondes % 60) / 60;
				Secondes = Secondes % 60;
				Heures += (Minutes - Minutes % 60) / 60;
				Minutes = Minutes % 60;
			}
			UpdateDelegue(ToString());
		}
	}
}
