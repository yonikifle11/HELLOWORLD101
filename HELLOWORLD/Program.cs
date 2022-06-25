//even odd program
using System;

namespace evenorodd
{
    class parity
    {
        static void Main(string[] args)
        {
            int num;
            char choice;
            do
            {
                Console.WriteLine("enter the number");
                num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (num % 2 == 0)
                    Console.WriteLine("the number is even");
                else
                    Console.WriteLine("the number is odd");

                Console.WriteLine("do u want to continue Y or N");

                choice = Console.ReadLine()[0];
            }
            while (choice != 'N' && choice != 'n');

        }

    }
}