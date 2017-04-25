using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    class TrojkatRown
    {
        public double[,] drawTrojkat(double x, double y, double dl_boku, double alfa)
        {
            //Wspólrzedne kartezjańskie
            //punkt2
            double x1 = Math.Round(x - dl_boku*Math.Sin(alfa),2);
            double y1 = Math.Round(y + dl_boku*Math.Sin(alfa),2);
            //punkt3
            double x2 = Math.Round(x - dl_boku * Math.Sin(alfa),2);
            double y2 = Math.Round(y - dl_boku * Math.Sin(alfa),2);
            
            Console.WriteLine("Współrzedne kartezjanskie:" +
                "\n P1({0};{1})\n P2({2};{3})\n P3({4};{5})\n "
                , x, y, x1, y1, x2, y2);

            //Wspólrzedne biegunowe

            double r = Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)), 2);
            double fi = Math.Round(Math.Atan(y / x), 2);
            double r1 = Math.Round(Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)), 2);
            double fi1 = Math.Round(Math.Atan(y1 / x1), 2);
            double r2 = Math.Round(Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)), 2);
            double fi2 = Math.Round(Math.Atan(y2 / x2), 2);
           
            Console.WriteLine("Współrzedne biegunowe:" +
                "\n P1({0};{1})\n P2({2};{3})\n P3({4};{5})\n "
                , r, fi, r1, fi1, r2, fi2);

            double[,] punkty = { { x, y }, { x1, y1 }, { x2, y2 },
             { r, fi }, { r1, fi1 }, { r2, fi2 }};

            return punkty;
        }

        double[,] Przesun(double[] wektor)
        {
            double[,] punkty_przes = { { 0 } };
            return punkty_przes;
        }

        double[,] Obroc(double kat)
        {
            double[,] punkty_obr = { { 0 } };
            return punkty_obr;
        }
    }
}
