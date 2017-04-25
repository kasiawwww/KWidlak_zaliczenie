using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZaliczenieTest
{
    [TestClass]
    public class ProstokatTest
    {
        
        [TestMethod]
        public void drawProstokatTest()
        {
            double x = 2;
            double y = 3;
            double dlugosc = 1;
            double szerokosc = 2;
            double[,] expected_value = { {2,3 }, {3,3}, {3,5 },{2,5 },{3.61,0.98},{4.24,0.79},{5.83,1.83 },{5.39,1.19 } };
            double[,] actual_value = drawProstokat(x,y,dlugosc,szerokosc);
            Assert.AreEqual(expected_value, actual_value);

        }
    }
}
