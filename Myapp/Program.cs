using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void demande_nombre() {
            Random rand = new Random();
            int nombre_magique = rand.Next(1, 10);
            string nombre_user = "";
            int nombre_user_int = 0;
            int nombre_vie = 3;

            while (nombre_user == "" || nombre_user_int != nombre_magique)
            {
                Console.Write("Rentrez un nombre ");
                nombre_user = Console.ReadLine();  

                try
                {
                    nombre_user_int = int.Parse(nombre_user);
                    if (nombre_user_int > nombre_magique)
                    {
                        nombre_vie--;
                        System.Console.WriteLine($"Le nombre magique est plus petit, vie restant ({nombre_vie})");
                    }
                    else if (nombre_user_int < nombre_magique ) {
                        nombre_vie--;
                        System.Console.WriteLine($"Le nombre magique est plus grand, vie restant ({nombre_vie})");
                    }
                    else
                    {
                        System.Console.WriteLine($"Bravo le nombre magique est({nombre_magique})");
                    }
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Veillez entrer un nombre valide");
                }

                if (nombre_vie == 0)
                {
                    System.Console.WriteLine("Vous n'avez plus des vie pour continuer");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            demande_nombre();
        }
    }
}


