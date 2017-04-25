using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat p = new Prostokat();
            p.drawProstokat(2, 3, 1, 2);
            TrojkatRown t = new TrojkatRown();
            t.drawTrojkat(5, 5, 2, 0.6);
            Console.ReadKey();
        }
    }
}
