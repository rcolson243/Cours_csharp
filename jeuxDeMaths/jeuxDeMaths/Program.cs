using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void JeuxDeMaths(int nombreUn, int nombreDeux)
        {
            Random rand = new Random();
            int reponseUserInt = 0;
            
            while (true)
            {
                int a = rand.Next(nombreUn, nombreDeux+1);
                int b = rand.Next(nombreUn, nombreDeux+1);

                Console.Write($"{a} + {b} = ");
                string reponseUser = Console.ReadLine();

                try
                {
                    reponseUserInt = int.Parse(reponseUser);
                    break;
                }
                catch
                {
                    Console.WriteLine("Vous devez rentrer un nombres valide");
                }

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            JeuxDeMaths(10, 10);

        }
    }
}