using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_
{
    internal class Program
    {
        static void KvU()
        {
            Console.Write("Введите первый коэффициент: \t");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второй коэффициент: \t");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третий коэффициент: \t");
            int c = int.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine($"x1 = {x1} \nx2 = {x2}");
            }
            else if (D == 0)
            {
                double x = (-b) / 2 * a;
                Console.WriteLine($"x = {x}");
            }
            else if (D < 0)
            {
                Console.WriteLine("Корней нет");
            }
        }
        static void Massiv()
        {
            Random rand = new Random();
            int[] mass = new int[20];
            for (int i = 0; i < 20; i++)
            {
                mass[i] = rand.Next(1,30);
            }
            Console.WriteLine(String.Join(",", mass));
            Console.Write("Какие числа вы хотите поменять через пробел? \t");
            int[] chisla = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index1 = Array.IndexOf(mass, chisla[0]);
            int index2 = Array.IndexOf(mass, chisla[1]);
            int izmen = 0;
            izmen = mass[index1];
            mass[index1] = mass[index2];
            mass[index2] = izmen;
            Console.WriteLine(String.Join(",", mass));
            
        }
        static int[] BubbleSort(int[] mas)
        {
            int maxim;
            int len = mas.Length;
            for(int i = 0; i < len; i++)
            {
                for(int j=0; j < len - 1-i; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        maxim = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = maxim;
                    }
                }
            }
            return mas;
        }
        static int MethodMassiv(ref int Proisv, out double CrArifm, params int[] massiV)
        {
            int sum = 0;
            for (int i = 0; i < massiV.Length; i++)
            {
                sum += massiV[i];
                Proisv *= massiV[i];
            }
            CrArifm = sum / massiV.Length;
            Console.WriteLine($"Произведение массива: {Proisv}"); 
            Console.WriteLine($"Среднее арифметическое массива: {CrArifm}");
            Console.Write("Сумма: ");
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            KvU();
            Console.ReadKey();

            Console.WriteLine("Задание 2");
            Massiv();
            Console.ReadKey();

            Console.WriteLine("Задание 3");
            Random Rand = new Random();
            int[] massiv = new int[10];
            for (int i = 0; i < 10; i++)
            {
                massiv[i] = Rand.Next(1, 30);
            }
            Console.WriteLine(String.Join(",", massiv));
            Console.WriteLine(String.Join(",", BubbleSort(massiv)));
            Console.ReadKey();

            Console.WriteLine("Задание 4");
            Random Random = new Random();
            int proisv = 1;
            double CrArifm;
            int[] MassiV = new int[10];
            for (int i = 0; i < 10; i++)
            {
                MassiV[i] = Random.Next(1, 30);
            }
            Console.WriteLine(String.Join(",", MassiV));
            Console.WriteLine(MethodMassiv(ref proisv, out CrArifm, MassiV));
            Console.ReadKey();

            Console.WriteLine("Задание 5");

            Console.ReadKey();

            Console.WriteLine("Задание 6");

            Console.ReadKey();

            Console.WriteLine("Задание 7");

            Console.ReadKey();


        }
    }
}
