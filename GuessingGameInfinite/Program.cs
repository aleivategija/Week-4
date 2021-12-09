using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Palun arva number (1-10):");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber != userGuess)
                {
                    Console.WriteLine("Vale arv. Arva uuesti!");
                    int v = Convert.ToInt32(Console.ReadLine());
                    int userGuess2 = v;
                    loopActive = true;
                }
                if (cpuNumber == userGuess)
                {
                    Console.WriteLine("Arvasid 6igesti!");
                    break;
                    
                }

                
                



            }



        }
    }
}
