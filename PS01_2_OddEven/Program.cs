using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine($"The number {n} is even");
            }
            else
            {
                Console.WriteLine($"The number {n} is odd");
            }

        }
    }
}
