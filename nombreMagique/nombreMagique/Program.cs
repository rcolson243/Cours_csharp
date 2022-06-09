using System;

namespace nbMagique
{
    class Program
    {
        static void NombreMagique()
        {
            Random rand = new Random();
            int nbMagique = rand.Next(1, 11); ;
            int nombreVie = 5;
            int reponseUserInt = 0;
            
            while (reponseUserInt != nbMagique)
            {
                Console.Write ("Deviner un nombre entre (1 et 10)");
                string reponseUserStr = Console.ReadLine();

                try
                {
                    reponseUserInt = int.Parse(reponseUserStr);

                    if(reponseUserInt < nbMagique)
                    {
                        nombreVie--;
                        Console.WriteLine($"Le nombre magique est plus grand il vous reste {nombreVie}");
                    }
                    else if (reponseUserInt > nbMagique)
                    {
                        nombreVie--;
                        Console.WriteLine($"Le nombre magique est plus petit il vous reste {nombreVie}");
                    }
                    else
                    {
                        Console.WriteLine
                        ($"Bravo vous avez trouver \nLe nombre magique était bien {reponseUserInt}"); ;
                    }
                }
                catch
                {
                    Console.WriteLine("Vous devez rentrer un nombre valide");
                }

                 if (nombreVie == 0)
                 {
                    Console.WriteLine($"Vous avez perdu le nombre magique était {nbMagique}");
                    break;

                 }
            }

        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int nb_magique = rand.Next(1, 10);
            Console.WriteLine(nb_magique);

            NombreMagique();
        }
    }
}

