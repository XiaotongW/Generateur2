using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generateur
{
    public partial class ficheCarte : Form
    {
        private Point m_position;
        private bool m_clique;

        public ficheCarte()
        {
            InitializeComponent();
        }

        ~ficheCarte()
        {

        }

        private void picCarteMonde_MouseClick(object sender, MouseEventArgs e)
        {
            m_clique = true;
            m_position = new Point(e.X - 7, e.Y - 7);
            picCarteMonde.Refresh();
        }

        private void picCarteMonde_Paint(object sender, PaintEventArgs e)
        {
            Icon iconeAeroport = new Icon("Aeroport.ico");

            Rectangle rect = new Rectangle(m_position.X, m_position.Y, 15, 15);

            e.Graphics.DrawIcon(iconeAeroport, rect);
        }
    }
}
