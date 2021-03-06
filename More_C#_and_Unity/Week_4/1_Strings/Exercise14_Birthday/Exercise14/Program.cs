﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14 {
    /// <summary>
    /// Exercise 14 solution
    /// </summary>
    class Program {
        /// <summary>
        /// Gets birthday and prints reminder
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            // get birth month and day
            Console.Write("Type in the month you were born: ");
            string birthMonth = Console.ReadLine();
            Console.Write("Type in the day you were born: ");
            int birthDay = int.Parse(Console.ReadLine());

            // print birthday
            Console.WriteLine();
            Console.WriteLine("Your birthday is " + birthMonth + " " + birthDay);

            // print reminder message
            Console.WriteLine("You'll receive a reminder on " + birthMonth + " " + (birthDay - 1));

            Console.WriteLine();
        }
    }
}
