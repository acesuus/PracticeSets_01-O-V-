﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number3
{
    internal class Program
    {


        static void Main(string[] args)
        {

            int age = int.Parse(Console.ReadLine());
            int income = int.Parse(Console.ReadLine());
            if (age >= 25 && age <= 35 && income > 50000)
            {
                Console.WriteLine("Young Professional");
            }
            else if (age >= 36 && age <= 55 && income > 70000)
            {

                Console.WriteLine("Middle-Aged Professional.");
            }



            else if (age >= 56 && income < 30000)
            {
                Console.WriteLine("Senior Citizen");
            }
            else
            {
                Console.WriteLine("Other");
            }


        }
    }
}
