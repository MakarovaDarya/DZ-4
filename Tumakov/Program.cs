using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива?");
            int razmer = Convert.ToInt16(Console.ReadLine());

            double[] massive = new double[razmer];
            double summa;
            summa = 0;
            var digitsRow = Console.ReadLine();
            var digits = digitsRow.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < razmer; i++)
            {

                foreach (var digit in digits)
                {
                    massive[i] = Convert.ToDouble(digit);

                }
            }
            Console.WriteLine(String.Join(",",massive));
        }
    }
}
