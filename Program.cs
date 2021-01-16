using System;

namespace Exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0, 50);
            int response = random.Next(0,50);
            int attempt = 1;
            for (int i = 1; i < 50; i++)
            while (response != random.Next(0,50))
            {
                Console.WriteLine("Devine le nombre secret entre 0 et 50");
                response = int.Parse(Console.ReadLine());
                if (response < number)
                {
                    Console.WriteLine("Non c'est plus grand");
                    Console.WriteLine("Tentative n° " + attempt);
                        ++attempt;
                }
                else if (response > number)
                {
                    Console.WriteLine("Non c'est plus petit");
                    Console.WriteLine("Tentative n° " + attempt);
                        ++attempt;
                }
                else if (response == number)
                {
                    Console.WriteLine("Bravo, vous avez trouvé !");
                }
            }
        }
    }
}