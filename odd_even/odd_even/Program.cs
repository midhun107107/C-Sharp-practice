/*using System.Runtime.Intrinsics.X86;

WAP to check whether number is even or odd

Instructions:
Use if else condition*/

using System;

namespace odd
{
    class even
    {

        static void Main(String[] arg)
        {
            int a;

            while (true)
            {
                Console.WriteLine("\nEnter a num");
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
                
            }
        }
    }
}