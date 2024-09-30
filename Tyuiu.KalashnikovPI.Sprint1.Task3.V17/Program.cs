using Tyuiu.KalashnikovPI.Sprint1.Task3.V17.Lib;
using Tyuiu.KalashnikovPI.Sprint1.Task3.V17.Lib;
namespace Tyuiu.KalashnikovPI.Sprint1.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил Калашников П. И. |СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Калашников Павел Ильич | СМАРТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая определяет, есть ли среди первых трех цифр  *");
            Console.WriteLine("* из дробной части заданного вещественного числа цифра 0.                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 24.024257;
            Console.WriteLine(" Проверяемое число X = " + x);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            ds.ZeroCheck(x);

            Console.WriteLine("*в дробной части есть число 0                                             *");

            Console.ReadKey();
        }
    }
    
}
