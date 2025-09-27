using Tyuiu.NazarovSV.Sprint1.Task5.V3.Lib;
namespace Tyuiu.NazarovSV.Sprint1.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                        *");
            Console.WriteLine("**************************************************************************");

            int k = Convert.ToInt32(Console.ReadLine());
            int h = ds.Calculate(k);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("* Результатом полученным после применения формулы является: " + h);
            Console.ReadLine();
        }
    }
}
