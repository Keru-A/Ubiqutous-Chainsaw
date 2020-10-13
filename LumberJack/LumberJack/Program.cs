using System;
using System.Threading;

namespace LumberJack
{
    class Program
    {
        // method to swap two numbers
        public static void Swap(ref int number1, ref int number2)
        {
            //swapping numbers with temporary variable
            int temp = number1;
            number1 = number2;
            number2 = number1;
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
            Console.WriteLine("The hot water has run out.");
        }
    }
}
