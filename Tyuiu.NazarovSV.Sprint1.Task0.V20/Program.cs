using Tyuiu.NazarovSV.Sprint1.Task0.V20.Lib;

namespace Tyuiu.NazarovSV.Sprint1.Task0.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 7;

            int b = a % 3 + 1;

            a++;

            b *= a - 5;

            int x = a - b;



            Console.WriteLine(x);
        }
    }
}
