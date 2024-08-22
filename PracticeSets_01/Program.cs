using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"The number is {number} positive.");

            }
            else
            {
                Console.WriteLine($"The number {number} is negative ");
            }


        }
    }
}
