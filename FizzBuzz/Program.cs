using System;

namespace Buzz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            if(a >= 1 && a <= 100)
            {
                if(a % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if(a % 5 == 0)
                {
                    Console.Write("Buzz");
                }
            }
            else
            {
                Console.WriteLine("Wrong number!");
            }
        }
    }
}