using System;
using System.IO;

namespace FileDirOpdracht
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DirectoryInfo dirinfo = new DirectoryInfo("C:/Users/pinkf/Documents/Mediacollege Amsterdam/Bewijzenmap/Periode 1.4/GD/test");

            Console.WriteLine("Listing all files, subdirectories and their files in C:/Users/pinkf/Documents/Mediacollege Amsterdam/Bewijzenmap/Periode 1.4/GD/test \n");

            ProcessDirectory(dirinfo);

            Console.ReadLine();
        }

        public static void ProcessDirectory(DirectoryInfo targetDirectory)
        {
            Console.WriteLine("\n" + targetDirectory.Name.ToString());

            FileInfo[] fileEntries = targetDirectory.GetFiles();
            foreach (FileInfo file in fileEntries)
                ProcessFile(file);

            DirectoryInfo[] subdirectoryEntries = targetDirectory.GetDirectories();
            foreach (DirectoryInfo subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        public static void ProcessFile(FileInfo file)
        {
            Console.WriteLine("--File: " + file.Name.ToString());
        }

    }
}
