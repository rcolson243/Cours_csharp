using System;

namespace nbMagique
{
    class Program
    {
        static void NombreMagique()
        {
            const int nbMagique = 8;
            int nombreVie = 5;
            int reponseUserInt = 0;
            
            while (reponseUserInt != nbMagique)
            {
                Console.WriteLine("Deviner un nombre entre (1 et 10)");
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
                        ($"Bravo vous avez trouver \nLe nombre magique était bien le {reponseUserInt}"); ;
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
            NombreMagique();
        }
    }
}

