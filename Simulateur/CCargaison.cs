using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	class CCargaison:CDansAeroport
	{
		protected double m_poid;

		public CCargaison (CAeroport aeroport, double poid):base(aeroport)
		{
			m_poid = poid;
		}

		public double poid
		{
			get { return m_poid; }
			set { m_poid = value; }
		}
	}
}
