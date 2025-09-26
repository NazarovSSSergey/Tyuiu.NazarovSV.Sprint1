using Tyuiu.NazarovSV.Sprint1.Task3.V16.Lib;
namespace Tyuiu.NazarovSV.Sprint1.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                        *");
            Console.WriteLine("**************************************************************************");

            double x1 = (Convert.ToDouble(Console.ReadLine()));

            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("* Коэффициент приведенного квадратного уравнения равен: " + ds.CoeffOfQuadraticEquation(x1, x2));
            Console.ReadLine();

        }
    }
}
