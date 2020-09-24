using System;
using System.Threading;

namespace LumberJack
{
    class Program
    {
        static void Main()
        {
            string temp;
            int age, round, card = 0, winnings = 0;
            Random rand = new Random();

            Console.WriteLine("Welcome to the card game. How old are you?");
            temp = Console.ReadLine();
            age = Convert.ToInt32(temp);

            if (age >= 18)
            {
                for (round = 0; round < 5; round++)
                {
                    card = rand.Next(1, 14);

                    switch (card)
                    {
                        case 1:
                            winnings = winnings + 20;
                            break;
                        case 11:
                        case 12:
                        case 13:
                            winnings = winnings + 10;
                            break;
                        default:
                            winnings = winnings - card;
                            break;
                    }

                    Console.WriteLine($"You drew a {card} card!");
                    Console.WriteLine($"Your total winnings are {winnings}!");
                    Thread.Sleep(1000);
                }

            }

            else
            {
                Console.WriteLine("You are too young to play. Get the hell out of here!!!!!");
            }

            Console.WriteLine("Thanks!");
            Console.ReadLine();
        }
    }
}
