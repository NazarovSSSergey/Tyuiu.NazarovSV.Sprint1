using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NazarovSV.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            string k = value;
            int countLetter = 0;
            int CO = 0;
            for (int i = 0; i < k.Length; i++)
            {
                if (char.IsLetter(k[i]))
                {
                    countLetter++;
                }
                else
                {
                    CO++;
                }
            }
            if (countLetter > CO)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}
