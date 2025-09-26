using Tyuiu.NazarovSV.Sprint1.Task2.V8.Lib;
namespace Tyuiu.NazarovSV.Sprint1.Task2.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
                                                                        
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int a;

            Console.WriteLine("Ведите значение a:");
            a = Convert.ToInt32(Console.ReadLine());

            int b;

            Console.WriteLine("Ведите значение b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                              *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine($"Периметр треугольника со сторонами {a} и {b} равен: " + ds.CalculatePerimetr(a, b));

            Console.ReadLine();
        }
    }
}
