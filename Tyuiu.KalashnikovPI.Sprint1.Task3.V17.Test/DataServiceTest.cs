using Tyuiu.KalashnikovPI.Sprint1.Task3.V17.Lib;
namespace Tyuiu.KalashnikovPI.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 14.880;

           

            var res = ds.ZeroCheck(x);

            Assert.IsTrue(res);
        }
    }
}