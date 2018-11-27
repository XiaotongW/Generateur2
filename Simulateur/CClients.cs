using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	public enum typeClient {Voyageur,Cargaison,Point,Incendie,Detresse};
	abstract class CClients
	{
		protected typeClient m_client;
		public CClients(typeClient client)
		{
			m_client = client;
		}

		public typeClient TypeClient
		{
			get { return m_client; }
			private set { m_client = value; }
		}
	}
}
