using System;
using System.IO;

namespace ReadingFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\wishlist";
            string userFile = "wishlist";
            string fullFilePath = $@"{rootDirectory}\{userFile}.txt";

            string[] dataFromFile = File.ReadAllLines(fullFilePath);

            foreach(string line in dataFromFile)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();

            dataFromFile[0] = "pink unicorn";

            foreach (string line in dataFromFile)
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines(fullFilePath, dataFromFile);


        }
    }
}
