using System;
using System.IO;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();

            bool randomName = false;

            Console.WriteLine("Enter file name or nothing for random:");

            string filename = Console.ReadLine(); //Get name for file

            if(filename == "") //Set random name to true if no name given
            {
                randomName = true;
            }
            

            string path = pr.CreateTextFile(filename, randomName); //Create file and return it's path

            pr.ShowContent(path); //Print the text

            Console.ReadLine();

            while (true)
            {
                pr.AddContent(path); //Let user add text

                pr.ShowContent(path); //Print the text

                Console.ReadLine();
            }
        }

        public string CreateTextFile(string filename, bool randomName)
        {
            if (randomName) //Create random file name
            {
                filename = Path.GetRandomFileName() + ".txt";
            }

            string path = "C:/Users/pinkf/Documents/Mediacollege Amsterdam/Bewijzenmap/Periode 1.4/GD/2022P4csharp/Csharp2Opdrachten/FileIOOpdracht/files/" + filename;

            using (StreamWriter sw = File.CreateText(path)) //Create file
            {
                sw.WriteLine(DateTime.Now.ToString()); //Add date time
            }

            return path;

        }

        public void ShowContent(string path)
        {
            string[] lines = File.ReadAllLines(path); //Put all lines in array

            Console.WriteLine("\nCONTENTS OF\n" + path + ":\n------------------------------------------------------------\n\n");

            foreach (string line in lines) //For every line in array print the line
            {
                Console.WriteLine(line);
            }
        }

        public void AddContent(string path)
        {
            Console.WriteLine("Enter content:");
            string[] contents = { "" };

            contents[0] = Console.ReadLine();

            File.AppendAllLines(path, contents);
        }
    }
}
