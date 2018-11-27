using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	abstract class CSurCarte:CClients
	{
		Position m_position;
		public CSurCarte(Position position)
		{
			m_position = position;
		}

		public Position position
		{
			get { return m_position; }
			set { m_position = value; }
		}
	}
}
