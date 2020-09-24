using System;

namespace LumberJack
{
    class Program
    {
        static void Main()
        {
            int age, dollars = 0, card;
            string temp;
            char again;
            Random rand = new Random();

            Console.Write("Please enter your age:   ");
            temp = Console.ReadLine();
            age = Convert.ToInt32(temp);

            if (age < 19)
            {
                Console.WriteLine("Good bye you are too young to play.");
            }
            else
            {
                do
                {
                    for (int i = 0; i <= 5; i++)
                    {
                        card = rand.Next(1, 14);
                        switch (card)
                        {
                            case 1:
                                Console.WriteLine("You drew an Ace, collect $20");
                                dollars = dollars + 20;
                                Console.WriteLine($"Your current total is {dollars:C}");
                                break;
                            case 11:
                            case 12:
                            case 13:
                                Console.WriteLine($"You drew a {card}, collect $10");
                                dollars = dollars + 10;
                                Console.WriteLine($"Your current total is {dollars:C}");
                                break;
                            default:
                                Console.WriteLine($"You drew a {card}, you loose {card:C}");
                                dollars = dollars - card;
                                Console.WriteLine($"Your current total is {dollars:C}");
                                break;
                        }
                    }
                    Console.Write("Do you want to play again?   ");
                    temp = Console.ReadLine();
                    temp = temp.ToLower();
                    again = Convert.ToChar(temp[0]);
                } while (again == 'y');
            }
            Console.ReadLine();

        }
    }
}
