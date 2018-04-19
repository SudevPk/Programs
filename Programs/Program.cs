using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region FibonacciExample

            Console.WriteLine("Fibonacci series");
            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("Enter the Limit:");
            number = int.Parse(Console.ReadLine());
            Console.Write("\nFibonoci Numbers are :\n");//printing 0 and 1
            Console.Write(n1 + "\n" + n2 + "\n");//printing 0 and 1
            for (i = 2; i <= number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + "\n");
                n1 = n2;
                n2 = n3;
            }

            Console.ReadKey();

            #endregion FibonacciExample
        }
    }
}