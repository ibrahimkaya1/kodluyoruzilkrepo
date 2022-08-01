using System;

namespace UcgenCizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            trigon(n);
        }

        private static void trigon(int n)
        {
           for(int i = 0; i < n; i++)
           {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
           }
        }
    }
}
