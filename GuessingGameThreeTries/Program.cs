using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while (i <= 3)
            {
                Console.WriteLine("Palun arva number vahemikus 1-10 kolme katsega:");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber != userGuess)
                {
                    i++;
                    Console.WriteLine("Vale arv. Arva uuesti!");
                    int v = Convert.ToInt32(Console.ReadLine());
                    int userGuess2 = v;
                    
                }
                if (cpuNumber == userGuess)
                {
                    Console.WriteLine("Arvasid 6igesti!");
                    Console.WriteLine("Kena p2eva");
                    break;

                }
            }
        }
    }
}
