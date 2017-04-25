using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZaliczenieTest
{
    [TestClass]
    public class TrojkatRownTest
    {
       
        [TestMethod]
        public void drawTrojkatTest()
        {
            double x = 5;
            double y = 5;
            double dl_boku = 2;
            double alfa = 0.6;
            double[,] expected_value = { { 5,5 }, { 3.87,6.13}, { 3.87,3.87 }, { 7.07, 0.79 }, { 7.25,1.01 }, { 5.47,0.79 }};
            double[,] actual_value = drawTrojkat(x, y, dl_boku, alfa);
            Assert.AreEqual(expected_value, actual_value);
        }
    }
}
