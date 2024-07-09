using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriuitBasket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> basket = new Stack<string>();
            Console.Write("How many fruit/s you would like to catch? ");
            int numFruit = Convert.ToInt32(Console.ReadLine());

            int eatFruit = numFruit;
            while (numFruit > 0)
            {

                Console.WriteLine("\nPick " + numFruit + " Fruit/s you want to put in the basket.");
                Console.WriteLine("[A] Apple" + "\n[O] Orange" + "\n[M] Mango" + "\n[G] Guava");

                string pick = Console.ReadLine();

                if (pick == "A" || pick == "a")
                {
                    basket.Push("Apple");
                    Console.WriteLine("\nYou put Apple in the basket");
                    numFruit--;
                }
                else if (pick == "O" || pick == "o")
                {
                    basket.Push("Orange");
                    Console.WriteLine("\nYou put Orange in the basket");
                    numFruit--;
                }
                else if (pick == "M" || pick == "m")
                {
                    basket.Push("Mango");
                    Console.WriteLine("\nYou put Mango in the basket");
                    numFruit--;
                }
                else if (pick == "G" || pick == "g")
                {
                    basket.Push("Guava");
                    Console.WriteLine("\nYou put Guava in the basket");
                    numFruit--;
                }
                else
                {
                    Console.WriteLine("\nInvalid Syntax!");
                }


            }
            Console.WriteLine("\nBasket is full!");
            Console.ReadLine();
            Console.WriteLine("\nYour basket have: ");

            foreach (var item in basket)
            {
                Console.WriteLine(item);
            }

            while (eatFruit > 0)
            {
                Console.Write("\nPress 'E' to eat the fruit: ");
                string eat = Console.ReadLine();

                if (eat == "E" || eat == "e")
                {
                    eatFruit--;
                    Console.WriteLine("\nYou eat " + basket.Pop());

                    Console.WriteLine("\nYour basket have " + eatFruit + " fruit/s now");
                    foreach (var item in basket)
                    {
                        Console.WriteLine(item);
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Syntax!");
                }

            }

            Console.WriteLine("No more fruits!\n");

        }
    }
}
