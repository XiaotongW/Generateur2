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

        public int x
        {
            get { return X; }
            set { X = value; }
        }

        public int y
        {
            get { return Y; }
            set { Y = value; }
        }


        public string ConvertirPosition() //converti la coordonnée cartésienne en coordonée gps
        {
            string laPosition;//String a retourner

            int L = 1000;//longeur de l'image
            int H = 531;//Hauteur de l'image
            int XM = L / 2;//X milieu
            int YM = H / 2; //Y milieu
            float result;
            int degrerX = 0; //degrer en X
            int degrerY = 0; //degrer en Y
            int MinuteX = 0; //Minute en X
            int MinuteY = 0; // minute en Y
            string[] Separateur;//Separe les degrer des minutes

            TrouverCardinalite(XM, YM);

            switch (Ycardinalite)
            {
                case 'S':
                    result = (((Y - YM) / (float)YM) * 90);
                    Separateur = result.ToString().Split(',');
                    degrerY = int.Parse(Separateur[0]);

                    if (((Y - YM) % (float)YM) != 0)
                    {
                        float restant;
                        if (Separateur[1].ToString().Length > 1)
                        {
                            restant = int.Parse(Separateur[1][0].ToString() + Separateur[1][1].ToString());
                        }
                        else
                        {
                            restant = int.Parse(Separateur[1][0].ToString());
                        }
                        restant = restant / 100;
                        MinuteY = (int)(restant * 60);
                    }
                    else
                    {
                        MinuteY = 0;
                    }
                    break;
                case 'N':
                    result = (((Y + YM) / (float)YM) * 90);
                    Separateur = result.ToString().Split(',');
                    degrerY = 180 - int.Parse(Separateur[0]);

                    if (((Y + YM) % (float)YM) != 0)
                    {

                        float restant;
                        if (Separateur[1].ToString().Length > 1)
                        {
                            restant = int.Parse(Separateur[1][0].ToString() + Separateur[1][1].ToString());
                        }
                        else
                        {
                            restant = int.Parse(Separateur[1][0].ToString());
                        }
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
                    result = (((X - XM) / (float)XM) * 180);
                    Separateur = result.ToString().Split(',');
                    degrerX = int.Parse(Separateur[0]);

                    if (((X - XM) % (float)XM) != 0)
                    {

                        float restant;
                        if (Separateur[1].ToString().Length > 1)
                        {
                            restant = int.Parse(Separateur[1][0].ToString() + Separateur[1][1].ToString());
                        }
                        else
                        {
                            restant = int.Parse(Separateur[1][0].ToString());
                        }
                        restant = restant / 100;
                        MinuteX = (int)(restant * 60);
                    }
                    else
                    {
                        MinuteX = 0;
                    }
                    break;
                case 'O':
                    result = (((X + XM) / (float)XM) * 180);
                    Separateur = result.ToString().Split(',');
                    degrerX = 360 - int.Parse(Separateur[0]);

                    if (((X + XM) % (float)XM) != 0)
                    {

                        float restant;
                        if (Separateur[1].ToString().Length > 1)
                        {
                            restant = int.Parse(Separateur[1][0].ToString() + Separateur[1][1].ToString());
                        }
                        else
                        {
                            restant = int.Parse(Separateur[1][0].ToString());
                        }
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
                Ycardinalite = 'S';
            }
            else if (Y < YM)
            {
                Ycardinalite = 'N';
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
