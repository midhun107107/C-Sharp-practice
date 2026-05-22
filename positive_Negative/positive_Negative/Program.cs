/*using System.Runtime.Intrinsics.X86;

WAP to check whether a number is positive or negative

Instructions:
Use if else condition to check*/


using System;

namespace pos
{

    class neg
    {
        
        static void Main(string[] arg)
        {
            int a;
            while(true)
            {
                Console.WriteLine("Enter the number");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Number is Zero");
                }
                else if (a > 0)
                {
                    Console.WriteLine("Psivtie");
                }
                else
                {
                    Console.WriteLine("Negative");
                }

            }
        }
    }

}