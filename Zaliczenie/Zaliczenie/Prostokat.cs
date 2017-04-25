using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    class Prostokat
    {

        /// <summary>
        /// metoda wypisujaca punkty prastokata
        /// </summary>
        /// <param name="x">wspolrzedna x punktu zaczepienia</param>
        /// <param name="y">wspolrzedna y punktu zaczepienia</param>
        /// <param name="dlugosc">dlugosc prostokata</param>
        /// <param name="szerokosc">szerokosc prostokata</param>
        /// <returns>tablica punktow</returns>
        public double[,] drawProstokat (double x, double y, double dlugosc, double szerokosc)
        {
            //Wspólrzedne kartezjanskie
            //punkt2
            double x1 = x + dlugosc;
            double y1 = y;
            //punkt3
            double x2 = x + dlugosc;
            double y2 = y + szerokosc;
            //punkt4
            double x3 = x;
            double y3 = y + szerokosc;
            Console.WriteLine("Współrzedne kartezjanskie:" +
                "\n P1({0};{1})\n P2({2};{3})\n P3({4};{5})\n P4({6};{7})\n"
                , x, y, x1, y1, x2, y2, x3, y3);

            //Wspólrzedne biegunowe
    
            double r = Math.Round(Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2)),2);
            double fi = Math.Round(Math.Atan(y / x),2);
            double r1 = Math.Round(Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)),2);
            double fi1 = Math.Round(Math.Atan(y1 / x1),2);
            double r2 = Math.Round(Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)),2);
            double fi2 = Math.Round(Math.Atan(y2 / x2),2);
            double r3 = Math.Round(Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2)),2);
            double fi3 = Math.Round(Math.Atan(y3 / x3),2);
            Console.WriteLine("Współrzedne biegunowe:" +
                "\n P1({0};{1})\n P2({2};{3})\n P3({4};{5})\n P4({6};{7})\n"
                , r, fi, r1, fi1, r2, fi2, r3, fi3);

            double[,] punkty = { { x, y }, { x1, y1 }, { x2, y2 }, { x3, y3 },
             { r, fi }, { r1, fi1 }, { r2, fi2 }, { r3, fi3 }};

            return punkty;
        }

        /// <summary>
        /// Metoda do przesuwania prostokata o wektor
        /// </summary>
        /// <param name="wektor">wektor przesuniecia</param>
        /// <returns>punkty przesunięte</returns>
        double[,] Przesun(double[] wektor)
        {
            double[,] punkty_przes = { { 0 } };
            return punkty_przes;
        }

        /// <summary>
        /// metoda do obracania prostokata
        /// </summary>
        /// <param name="kat">kat obrotu</param>
        /// <returns>punkty obrocone</returns>
        double[,] Obroc(double kat)
        {
            double[,] punkty_obr = { { 0 } };
            return punkty_obr;
        }
    }
}
