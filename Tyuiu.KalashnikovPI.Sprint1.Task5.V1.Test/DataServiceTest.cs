using Tyuiu.KalashnikovPI.Sprint1.Task5.V1.Lib;
namespace Tyuiu.KalashnikovPI.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1 = 2;
            double y1 = 2;
            double x2 = 5;
            double y2 = 2;
            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int result = Convert.ToInt32(res);

            int wait = 3;

            Assert.AreEqual(result, wait);
           
        }
    }
}