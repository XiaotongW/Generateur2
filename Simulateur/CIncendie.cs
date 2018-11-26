using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	class CIncendie:CSurCarte
	{
		int Intensite;
		public CIncendie(int posX, int posY, int Intensite):base(posX,posY)
		{
			this.Intensite = Intensite;
		}

		public int intensite
		{
			get { return Intensite; }
		}

		public void reduireIntensite()
		{
			Intensite -= 1;
		}
	}
}
