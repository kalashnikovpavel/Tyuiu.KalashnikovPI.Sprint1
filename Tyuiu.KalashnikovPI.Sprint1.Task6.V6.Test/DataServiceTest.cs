using Tyuiu.KalashnikovPI.Sprint1.Task6.V6.Lib;
namespace Tyuiu.KalashnikovPI.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "������";
            DataService ds = new DataService();
            string res = ds.DeleteFirstLetter(strTest);
            string wait = "�����";
            Assert.AreEqual(wait, res);
        }
    }
}