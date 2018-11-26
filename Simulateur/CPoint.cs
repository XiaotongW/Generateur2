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
		public CPoint(Position position, int rayon) : base(position.x,position.y)
		{
			this.rayon = rayon;
		}
	}
}
