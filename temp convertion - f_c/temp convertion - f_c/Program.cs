/*using System.Xml.Linq;

Write a program that takes a temperature in Fahrenheit as input and converts it to Celsius using the formula: 

celsius = (fahrenheit - 32) * 5 / 9

Note: Comment the prompting messages 

like printf("enter the number ");*/


using System;

namespace temp
{

    class convert
    {

        static void Main(string[] arg)
        {
            float f,c;
            Console.WriteLine("Enter he temp in Fahrentheit");

            f = Convert.ToSingle(Console.ReadLine());

            c = (f - 32) * (float)5 / 9;

            Console.WriteLine($"Celsius {c}");
        }
    }
}