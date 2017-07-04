using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                foreach (string arg in args)
                    Console.WriteLine(arg);
            }
            else
            {
                Console.WriteLine("No args were provided");
            }

            Console.ReadLine();
        }
    }
}
