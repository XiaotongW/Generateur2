using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	class CPoint:CSurCarte
	{
		int rayon;
		public CPoint(typeClient client,Position position, int rayon) : base(client,position)
		{
			this.rayon = rayon;
		}
	}
}
