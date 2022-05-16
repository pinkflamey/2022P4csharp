using System;

namespace EnumOpdracht
{
    internal enum Colors
    {
        Red,
        Green,
        Blue,
        Pink
    }
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Colors[] colors = (Colors[])Enum.GetValues(typeof(Colors));

            foreach (Colors color in colors)
            {
                Console.WriteLine(color.ToString());
            }
            
            string value = Console.ReadLine();

            Colors parsedColor;

            try
            {
                parsedColor = (Colors)Enum.Parse(typeof(Colors), value);
                Console.WriteLine("You have chosen the color: " + parsedColor.ToString());
            }
            catch
            {
                Console.WriteLine("This color is not available.");
            }

            Console.ReadLine();
        }
    }
}
