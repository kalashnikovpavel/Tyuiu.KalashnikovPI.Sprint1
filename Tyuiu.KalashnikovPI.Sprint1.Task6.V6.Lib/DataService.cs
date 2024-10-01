using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KalashnikovPI.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            String[] arrOfStr = value.Split(' ');


            String res = "";


            foreach (String a in arrOfStr)
            {
                res += a.Substring(1, a.Length - 1)+ " ";
            }

            return res;
        }

    }
}
