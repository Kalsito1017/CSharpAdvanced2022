namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();

            using (StreamReader streamReader = new StreamReader(inputFilePath))
            {
                int counter = 0;

                string inputLine;
                while ((inputLine = streamReader.ReadLine()) != null)
                {
                    if (counter % 2 == 0)
                    {
                        string newLine = inputLine.Replace('-', '@').Replace(',', '@').Replace('.', '@').Replace('!', '@').Replace('?', '@');
                        string finalLine = string.Join(" ", newLine.Split(' ').Reverse());

                        sb.AppendLine(finalLine);
                    }
                    counter++;
                }
            }
            return sb.ToString();
        }
    }
}