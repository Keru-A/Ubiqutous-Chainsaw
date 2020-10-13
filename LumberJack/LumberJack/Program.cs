using System;
using System.Threading;

namespace LumberJack
{
    class Program
    {
        /* Main method that ask for numbers and the sents them to be sorted*/
        // method to swap two numbers
        public static void Swap(ref int number1, ref int number2)
        {
            //swapping numbers with temporary variable
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }

        //method to sort numbers into ascending order
        public static void SortNumbers(ref int number1, ref int number2, ref int number3)
        {
            //checking numbers against eachoether to sort into ascending order
            if (number1 > number2)
            {
                Swap(ref number1, ref number2);
            }

            if (number2 > number3)
            {
                Swap(ref number2, ref number3);
            }

            if (number1 > number2)
            {
                Swap(ref number1, ref number2);
            }
        }
        static void Main()
        {
            int num1, num2, num3;
            Console.Write("Please enter your first number:   ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your second number:   ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your third number:   ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The current numbers are {num1}, {num2}, and {num3}.");
            SortNumbers(ref num1, ref num2, ref num3);
            Console.WriteLine($"The proper order is numbers are {num1}, {num2}, and {num3}.");
            Console.ReadLine();
        }
    }
}
