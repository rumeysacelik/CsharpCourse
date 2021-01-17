using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
        

            string[] students2 = { "Engin", "Derin", "Salih" };
          
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
