using Tyuiu.NazarovSV.Sprint1.Task7.V3.Lib;
namespace Tyuiu.NazarovSV.Sprint1.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                        *");
            Console.WriteLine("**************************************************************************");

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("* Результатом полученным после применения формулы является: " + ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
