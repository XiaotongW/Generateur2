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
            m_clique = false;
        }

        public int PositionX
        {
            get { return m_position.X - 7; }
        }

        public int PositionY
        {
            get { return m_position.Y - 7; }
        }

        private void picCarteMonde_MouseClick(object sender, MouseEventArgs e)
        //Enregistrer la position du clique, puis rafraîchir l'affichage du cadre d'image
        {
            m_position = new Point(e.X - 7, e.Y - 7);

            m_clique = true;

            picCarteMonde.Refresh();
        }

        private void picCarteMonde_Paint(object sender, PaintEventArgs e)
        //Desiner l'icône d'aéroport à l'endroit enregistrer du clique de souris
        {
            if (m_clique)
            {
                Icon iconeAeroport = new Icon("Aeroport.ico");

                Rectangle rect = new Rectangle(m_position.X, m_position.Y, 15, 15);

                e.Graphics.DrawIcon(iconeAeroport, rect);
            }
        }
    }
}
