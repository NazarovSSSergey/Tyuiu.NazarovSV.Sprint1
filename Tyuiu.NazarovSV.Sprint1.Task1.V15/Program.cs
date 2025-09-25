using Tyuiu.NazarovSV.Sprint1.Task1.V15.Lib;
namespace Tyuiu.NazarovSV.Sprint1.Task1.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Назаров С. В. | СМАРТб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("Вариант  #15                                                             *");
            Console.WriteLine("* Выполнил: Назаров Сергей Викторович | СМАРТб-25-1                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивет у пользователя исходые данные,  *");
            Console.WriteLine("* вычисляет результат по формуле (4+2*x)/7 и печатает его на экране      *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* (4+2*x)/7                                                               ");
            Console.WriteLine("**************************************************************************");

            double x;
            Console.WriteLine("Введите занчение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate(x));
            Console.WriteLine();
        }
    }
}
