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

            int x1;

            Console.WriteLine("Ведите значение a:");
            x1 = Convert.ToInt32(Console.ReadLine());

            int x2;

            Console.WriteLine("Ведите значение b:");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                              *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine($"Периметр треугольника со сторонами {x1} и {x2} равен: " + ds.CalculatePerimetr(x1, x2));

            Console.ReadLine();
        }
    }
}
