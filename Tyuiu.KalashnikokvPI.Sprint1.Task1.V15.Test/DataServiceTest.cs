
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using Tyuiu.KalashnikovPI.Sprint1.Task1.V15.Lib;
namespace Tyuiu.KalashnikokvPI.Sprint1.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -2.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(0, res);

        }
    }
}