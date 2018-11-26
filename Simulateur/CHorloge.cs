using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simulateur
{
	class CHorloge
	{
		DateTime Debut;
		DateTime DateNow;
		bool enPause;
		int[] TimeBuff;
		int TimeSpeed;

		public CHorloge(int speed=1)
		{
			Debut = DateTime.Now;
			DateNow = Debut;
			TimeBuff = new int[3];
			for (int i =0; i < TimeBuff.Count(); i++)
			{
				TimeBuff[i] = 0;
			}
			TimeSpeed = speed;
			enPause = false;
		}

		public string DebutHorloge()
		{
			Debut = DateTime.Now;
			enPause = false;
			return this.ToString();
		}

		public void setPause()
		{
			enPause = true;
			Debut = DateNow;
		}

		public void restart()
		{
			enPause = false;
			DateNow = DateTime.Now;
			Debut = DateNow;
		}

		public bool isDiff()
		{
			if (!enPause) DateNow = DateTime.Now;
			return !enPause && ((Debut.Second != DateNow.Second) || (Debut.Minute != DateNow.Minute) || (Debut.Hour != DateNow.Second));
		}

		public override string ToString()
		{
			ChangeHorloge();
			return string.Format("{0} : {1} : {2}", TimeBuff[0], TimeBuff[1], TimeBuff[2]);
		}

		private void ChangeHorloge()
		{
			int buffMinutes = 0;
			int buffHeure = 0;
			if (!isDiff()) return;
			TimeBuff[2] += Math.Abs(DateNow.Second - Debut.Second)*TimeSpeed;
			if (TimeBuff[2] > 59){
				buffMinutes = (int)(TimeBuff[0]/60);
				TimeBuff[2] = TimeBuff[2]%60;
				
			}

			TimeBuff[1] += (Math.Abs(DateNow.Minute - Debut.Minute)+buffMinutes);
			if (TimeBuff[1] > 59)
			{
				buffHeure = (int)(TimeBuff[1] / 60);
				TimeBuff[1]= TimeBuff[1]%60;
			}
			TimeBuff[0] += (Math.Abs(DateNow.Hour - Debut.Hour) + buffHeure);
			if (TimeBuff[0] > 23)
			{
				TimeBuff[0] = 0;
			}
			
			Debut = DateNow;
		}
	}
}
