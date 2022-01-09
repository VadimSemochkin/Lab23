using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);
            Console.WriteLine("Идет выполнение задачи");
            Console.ReadKey();

        }

        static void Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i < n+1; i++)
            {
                f *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine($"Факториал числа {n} равен {f}");
           
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(()=>Factorial(n));
        }
    }
}
