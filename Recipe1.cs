using System;
using System.Threading;

namespace ConsoleApp1
{
    public class Program
    {
        static void PrintNumbers()
        {
            Console.WriteLine("Starting...");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i + "PrintNumbers");
            }
        }


        public static void Main(string[] args)
        {
            Thread t = new Thread(PrintNumbers);
            t.Start();
            PrintNumbers();
        }
    }
}
