using Tyuiu.KalashnikovPI.Sprint1.Task4.V2.Lib;
namespace Tyuiu.KalashnikovPI.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 6;
            double wait = 0.25;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}