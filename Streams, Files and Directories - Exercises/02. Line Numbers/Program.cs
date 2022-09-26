

namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }
        
         public static void ProcessLines(string inputFilePath, string outputFilePath)
         {
            string[] input = File.ReadAllLines(inputFilePath);
            string line = "";
            for (int i = 0; i < input.Length; i++)
            {
                int letters = input[i].Count(c => char.IsLetter(c));
                int punctuation = input[i].Count(c => char.IsPunctuation(c));
                line = $"Line {i + 1}: {input[i]} ({letters})({punctuation})";
                Console.WriteLine(line);
            }
         }
        

    }
}
