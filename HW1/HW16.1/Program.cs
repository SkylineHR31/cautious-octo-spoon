using System;
using System.IO;

namespace HW16._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter source file path: ");
            string sourcePath = Console.ReadLine();

            Console.Write("Enter destination file path: ");
            string destinationPath = Console.ReadLine();

            try
            {
                File.Copy(sourcePath, destinationPath, true);
                Console.WriteLine("File successfully copied!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The source file does not exist.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: Access denied. Check file permissions.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
