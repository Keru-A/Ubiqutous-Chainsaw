using System;
using System.Threading;

namespace LumberJack
{
    class Program
    {
        /* Main method that ask for numbers and the sents them to be sorted*/
        static void Main()
        {
            double num1, num2, num3;
            Console.Write("Please enter your first number:   ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter your second number:   ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter your third number:   ");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The current numbers are {num1}, {num2}, and {num3}.");
            SortNumbers(ref num1, ref num2, ref num3);
            Console.WriteLine($"The proper order is numbers are {num1}, {num2}, and {num3}.");
        }
    }
}
