using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    class Position
    {
        int X;
        int Y;
        private char Xcardinalite;
        private char Ycardinalite;
        public Position(int p_X, int p_Y)
        {
            X = p_X;
            Y = p_Y;
        }

        public string ConvertirPosition() //converti la coordonnée cartésienne en coordonée gps
        {
            string laPosition="";
            
            int L = 0;//longeur de l'image
            int H = 0;//Hauteur de l'image
            int XM = L / 2;//X milieu
            int YM = H / 2; //Y milieu
            int degrerX; //degrer en X
            int degrerY; //degrer en Y
            int MinuteX; //Minute en X
            int MinuteY; // minute en Y

            TrouverCardinalite(XM,YM);
            //manque le reste pour calculer minute sur 60
            switch (Ycardinalite)
            {
                case 'N':
                    degrerY = ((Y - YM) / YM) * 90;
                    if (((Y - YM) % YM) != 0)
                    {
                        float restant = ((Y - YM) % YM);
                        MinuteX = (int)restant * 60;
                    }
                    break;
                case 'S':
                    degrerY = ((Y + YM) / YM) * 90;
                    break;
            }
            switch (Xcardinalite)
            {
                case 'E':
                    degrerX = ((X - XM) / XM) * 180;
                    break;
                case 'O':
                    degrerX = ((X + XM) / XM) * 180;
                    break;
            }
             

            return laPosition;
        }

        private void TrouverCardinalite(int XM, int YM)
        {
            if (Y > YM)
            {
                Ycardinalite = 'N';
            }
            else if (Y < YM)
            {
                Ycardinalite = 'S';
            }
            else { Ycardinalite = '0'; }

            if (X > XM)
            {
                Xcardinalite = 'E';
            }
            else if (X < XM)
            {
                Xcardinalite = 'O';
            }
            else { Xcardinalite = '0'; }
        }
        
    }
}
