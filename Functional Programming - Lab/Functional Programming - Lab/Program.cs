using System;
using System.IO;

namespace Functional_Programming___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // random things below
            //StreamWriter sw = new StreamWriter(@"C:\Temp\output.txt");
            //sw.WriteLine("HEHEHEHEHA");
            //sw.Close();

            //StreamReader sr = new StreamReader(@"C:\Temp\output.txt");
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr);
            //sr.Close();
            //Func<int, int, long> func = PrintResult;
            //Console.WriteLine(func(2, 3));
            //Console.Write(new string('=', 5));
            PrintResult(1, 2, Multiply);
        }
        static long Multiply (int a, int b)
        {
            return a * b;

        }
        
        static void PrintResult( int a, int b, Func<int, int, long>func)
        {
            for (int i = 0; i < 5; i++)
            {
                var result = func(a + i, b + i);
                Console.WriteLine(new String('-', 50));
                Console.WriteLine(result);
                Console.WriteLine(new String('-', 50));
            }        
        }
        static bool EvenNumbers(int x)
        {
            return x % 2 == 0;
        }
    }
}
