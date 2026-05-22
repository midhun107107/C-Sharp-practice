/*T5 - Temperature Conversion - (int)Fahrenheit to Celcius(float)*/


using System;

namespace temp
{
    class temp_conv
    {

        static void Main(string[] arg)
        {
            int Fahrenheit;
            float Celcius;

            Console.WriteLine("enter Fahrenheit");
            
            Fahrenheit = Convert.ToInt32(Console.ReadLine());

            Celcius = (float)(Fahrenheit - 32) * (float)5 / 9;

            Console.WriteLine($"Celcius { Celcius }" );



        }
    }

}