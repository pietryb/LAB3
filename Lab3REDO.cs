using System;

namespace Lab3REDO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number between 1-100");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 1)
            {
                Console.WriteLine($"Odd and {num}");

            }
            //even
            else if (num % 2 == 0 && num >= 2 && num <= 25)

            {
                Console.WriteLine("Even and less tham 25");
            }
            else if (num % 2 == 0 && num >= 26 && num <= 60)
            {
                Console.WriteLine("Even.");

            }
            else if (num % 2 == 0 && num > 60)
            {
                Console.WriteLine($"{num} and even");
            }
            else if (num % 2 == 1 && num > 60)
            {
                Console.WriteLine($"{num} and odd");
            }
        }


    }
}
