using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulateur
{
	public partial class fchSimulateur : Form
	{
		CSimulateur simulateur;
		public TimeDelegue timeDelegue;

		public fchSimulateur(CSimulateur simulateur)
		{
			this.simulateur = simulateur;
			timeDelegue = new TimeDelegue(setHorloge);
			InitializeComponent();
		}

		public void setHorloge(string Time)
		{
			lblHorloge.Text = Time;
		}
    }
}
