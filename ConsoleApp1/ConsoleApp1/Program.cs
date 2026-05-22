/*using static System.Net.Mime.MediaTypeNames;

WAP to Find average of 3 float values
Program should read 3 float values from user and print their average.

Sample executions :
Test case 1:
Input: 25.7 1.1 28.2
Output: 18.333333*/

using System;

namespace avg
{
    class pgrgram
    {
         
        static void Main(string[] arg)
        {
            float a, b, c;

            Console.WriteLine("Enter hree nums");

            a= Convert.ToSingle(Console.ReadLine());
            b= Convert.ToSingle(Console.ReadLine());
            c= Convert.ToSingle(Console.ReadLine());


            Console.WriteLine($"{(a + b + c) / 3}");

        }


    }
}