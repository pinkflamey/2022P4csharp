using System;
using System.Collections.Generic;

namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "uil", "kraai", "hond", "papegaai" };
            string[] animals2 = { "meeuw", "duif" };

            List<string> birds = new List<string>();
            birds.AddRange(animals);

            List<string> birds2 = new List<string>();
            birds2.AddRange(animals2);

            birds.AddRange(birds2);
            foreach(string item in birds)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            Console.Write("Remove this one from the list: ");
            string input = Console.ReadLine();

            int removeIndex = birds.IndexOf(input);

            if(removeIndex != -1)
            {
                birds.RemoveAt(removeIndex);
            }
            else
            {
                Console.WriteLine("This animal was not in the list. The list remains unchanged.");
            }

            Console.WriteLine("----------");

            foreach (string item in birds)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
