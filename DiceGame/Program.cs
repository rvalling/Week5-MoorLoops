using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, ongi mängu võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitjat

            Random rnd = new Random();

            //arvuti vise
            int cpuRandom = rnd.Next(1, 7);
            //kasutaja vise
            int userRandom = rnd.Next(1, 7);

            int cpuScore = 0;
            int userScore = 0;
            

            for(int i = 0; i < 3; i++)
            {
                cpuRandom = rnd.Next(1, 7);
                userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");
                

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on viske võitnud.");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on viske võitnud.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }

            if(cpuScore > userScore)
            {
                Console.WriteLine("Punktide järgi on mängu võitnud arvuti. Palju õnne!");
            }
            else if (userScore > cpuScore)
            {
                Console.WriteLine("Punktide järgi on mängu võitnud kasutaja. Palju õnne!");
            }
            else
            {
                Console.WriteLine("Punktide järgi ei võitnud keegi vaid on viik!");
            }
            
           
            
        }
    }
}
