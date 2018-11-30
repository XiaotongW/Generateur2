using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
	public enum typeClient {Voyageur,Cargaison,Point,Incendie,Detresse};
	public abstract class CClients
	{
		private typeClient m_client;
		public CClients(typeClient client)
		{
			m_client = client;
		}

		public typeClient TypeClient
		{
			get { return m_client; }
		}
	}
}
