using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public class Scenario
    {
        List<CAeroport> ListeAeroports;

        public Scenario()
        {
            ListeAeroports = new List<CAeroport>();
        }

        public void AjouterAeroport(CAeroport Aeroport)
        {
            ListeAeroports.Add(Aeroport);
        }
        public void RetirerAeroport(CAeroport Aeroport)
        {
            ListeAeroports.Remove(Aeroport);
        }

        public void AjouterAeronef(CAeroport Aeroport,CAeronef Aeronef)
        {
             Aeroport.AjouterAeronef(Aeronef);
        }
        public void RetirerAeronef(CAeroport Aeroport,CAeronef Aeronef)
        {
            Aeroport.RetierAeronef(Aeronef);
        }

    }
}
