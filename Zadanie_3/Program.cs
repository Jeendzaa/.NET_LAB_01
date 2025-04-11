using System;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --== OODCZYT ARGUMENTÓW ==--");
            if (args.Length == 0) Console.WriteLine("Brak argumentów");
            else
            {
                foreach(string arg in args)
                {
                    Console.WriteLine($"{arg}");
                }
            }

            Console.WriteLine(" --== OODCZYT ZMIENNYCH ==--");
            foreach(var env in Environment.GetEnvironmentVariables().Keys)
            {
                Console.WriteLine($"{env} = {Environment.GetEnvironmentVariables()}");
            }
        }
    }
}
