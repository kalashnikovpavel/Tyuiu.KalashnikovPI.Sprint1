using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KalashnikovPI.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            value = value.Substring(1);
            return value;
        }
    }
}
