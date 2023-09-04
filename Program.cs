using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Limitation = 5;
            float sum = 0;

            for (int l = 0; l < Limitation; l++)
            {
                Console.Write("Enter Number(You can only type 5 numbers sowwy :3): ");
                sum += float.Parse(Console.ReadLine());

            }

            float ave = sum / Limitation;
            Console.WriteLine($"The average {ave}");
            Console.ReadKey();
        }
    }
}
