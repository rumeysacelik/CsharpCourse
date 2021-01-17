using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!"
            decimal number6 = 10.4m;
            double number5 = 10.4;
            char character = 'A';
            bool condition = false;
            byte number4 = 0;
            short number3 = -32768;
            int number1 = 2147483647;
            long number2 = -9223372036854775807;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine((int)Days.Friday);<
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}s