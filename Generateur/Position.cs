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
            string laPosition;//String a retourner

            int L = 1920;//longeur de l'image
            int H = 1080;//Hauteur de l'image
            int XM = L / 2;//X milieu
            int YM = H / 2; //Y milieu
            int degrerX = 0; //degrer en X
            int degrerY = 0; //degrer en Y
            int MinuteX = 0; //Minute en X
            int MinuteY = 0; // minute en Y
            

            TrouverCardinalite(XM, YM);

            switch (Ycardinalite)
            {
                case 'N':
                    degrerY = ((Y - YM) / YM) * 90;
                    if (((Y - YM) % YM) != 0)
                    {
                        string[] Separateur;//Separe les degrer des minutes
                        float restant = ((Y - YM) / (float)YM);
                        
                        Separateur = restant.ToString().Split(',');
                        restant = int.Parse(Separateur[1][0].ToString() + Separateur[1][1].ToString());
                        restant = restant / 100;
                        MinuteY = (int)(restant * 60);
                    }
                    else
                    {
                        MinuteY = 0;
                    }
                    break;
                case 'S':
                    degrerY = ((Y + YM) / YM) * 90;
                    if (((Y + YM) % YM) != 0)
                    {
                        string[] Separateur;//Separe les degrer des minutes
                        float restant = (Y + YM) / (float)YM;
                       
                        Separateur = restant.ToString().Split(',');
                        restant = int.Parse(Separateur[1][0].ToString() + Separateur[1][1].ToString());
                        restant = restant / 100;
                        MinuteY = (int)(restant * 60);
                    }
                    else
                    {
                        MinuteY = 0;
                    }
                    break;
            }
            switch (Xcardinalite)
            {
                case 'E':
                    degrerX = ((X - XM) / XM) * 180;
                    if (((X - XM) % XM) != 0)
                    {
                        string[] Separateur;//Separe les degrer des minutes
                        float restant = ((X - XM) / (float)XM);
                  
                        Separateur = restant.ToString().Split(',');
                        restant = int.Parse(Separateur[1][0].ToString() + Separateur[1][1].ToString());
                        restant = restant / 100;
                        MinuteX = (int)(restant * 60);
                    }
                    else
                    {
                        MinuteX = 0;
                    }
                    break;
                case 'O':
                    degrerX = ((X + XM) / XM) * 180;
                    if (((X + XM) % XM) != 0)
                    {
                        string[] Separateur;//Separe les degrer des minutes
                        float restant = ((X + XM) / (float)XM);
                        Separateur = restant.ToString().Split(',');
                        restant = int.Parse(Separateur[1][0].ToString() + Separateur[1][1].ToString());
                        restant = restant / 100;
                        MinuteX = (int)(restant * 60);
                    }
                    else
                    {
                        MinuteX = 0;
                    }
                    break;
            }

            laPosition = degrerY.ToString() + "° " + MinuteY + "' " + Ycardinalite + ", " + degrerX.ToString() + "° " + MinuteX + "' " + Xcardinalite;
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
