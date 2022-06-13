using System;
using System.IO;

namespace StringSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\pinkf\Documents\Mediacollege Amsterdam\Bewijzenmap\Periode 1.4\GD\2022P4csharp\Csharp2Opdrachten\StringSplit\stringsplit.txt");

            string[] data = text.Split(":");

            string[] data2 = data[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(data[0] + "\n");
            for(int i = 0; i < data.Length; i++)
            {
                data2[i] = data2[i].Replace(" ", "");
            }
            foreach (string s in data2)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        
        }
    }
}
