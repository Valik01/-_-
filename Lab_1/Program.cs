using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value a and b");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                double c = Math.Sqrt(a - b);
                Console.WriteLine("Squaring the difference a and b equals {0} ", c);
            }
            else
                Console.WriteLine("Тhe root of a negative number is not extracted ");
        }
    }
}
