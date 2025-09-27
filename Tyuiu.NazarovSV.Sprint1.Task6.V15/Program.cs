using Tyuiu.NazarovSV.Sprint1.Task6.V15.Lib;
namespace Tyuiu.NazarovSV.Sprint1.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                        *");
            Console.WriteLine("**************************************************************************");

            string value = Convert.ToString(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("* Результатом полученным после применения формулы является: " + ds.CheckLettersCount(value));
            Console.ReadLine();
        }
    }
}
