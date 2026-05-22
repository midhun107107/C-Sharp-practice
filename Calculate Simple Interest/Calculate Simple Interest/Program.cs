/*T6 - Calculate Simple Interest
Write a C program to calculate the simple interest for a given principal amount, rate of interest, and time period.

Instructions:

Prompt the user to enter the principal amount, rate of interest, and time period in years.
Calculate the simple interest using the formula: Simple Interest = (Principal Amount * Rate of Interest * Time) / 100/ */
using System;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace interest
{

    class simple
    {

        static void Main(string[] a)
        {
            decimal Principal_Amount;
            decimal Rate_of_Interest, Simple_Interest;
            int Time;

            Console.WriteLine("enter the Principal amt , Rate_of_Interest and Time");
            Principal_Amount = Convert.ToDecimal(Console.ReadLine());
            Rate_of_Interest = Convert.ToDecimal(Console.ReadLine());
            Time = Convert.ToInt32(Console.ReadLine());

            Simple_Interest = (decimal)(Principal_Amount * Rate_of_Interest * Time) /(decimal)100;

            Console.WriteLine($"{Simple_Interest}");
        }

    }
}