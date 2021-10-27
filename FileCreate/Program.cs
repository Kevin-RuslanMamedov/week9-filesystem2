using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\wishlist";
            string userFile = "wishlist";
            string fullFilePath = $@"{rootDirectory}\{userFile}.txt";

            bool directoryexists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(fullFilePath);

            if(directoryexists && fileExists)
            {
                Console.WriteLine($"{userFile} already exists in {rootDirectory}");
            }
            else if (!directoryexists)
            {
                Console.WriteLine($"{rootDirectory} does not exists.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} has been created.");
                File.Create(fullFilePath);
                Console.WriteLine($"{userFile}.txt has been created in {rootDirectory}.");
            }
            else
            {
                File.Create(fullFilePath);
                Console.WriteLine($"{userFile}.txt has been created in {rootDirectory}.");
            }

            


        }
    }
}
