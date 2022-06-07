using System;

namespace premier_programme
{
    internal class Program
    {
        // cette function demande le nom 
        static string Demande_nom(string num_person)
        {
            //ici on demande le nom
            string nom_user = "";
            while (nom_user == "")
            {
                Console.Write("Bonjour quel est votre nom ? ");
                nom_user = Console.ReadLine();

                nom_user = nom_user.Trim();
                if (nom_user == "")
                {
                    Console.WriteLine("Vous devez rentrer un nom");
                }
            }
            return nom_user;
        }

        // cette function demande le nom 
        static int Demande_age()

        {
            int age_num = 0;
            while (age_num <= 0)
            {
                //on demande l'age 
                Console.Write("Quel est votre age ? ");
                string age_str = Console.ReadLine();

                try
                {
                    age_num = int.Parse(age_str);
                    if (age_num < 0)
                    {
                        Console.WriteLine("Vous devez rentrer un nombre positive");
                    }
                    if (age_num == 0)
                    {
                        Console.WriteLine("Votre age doit pas être zéro");
                    }
                }
                catch
                {
                    Console.WriteLine("Vous devez rentrer un age valide");
                }
            }

            return age_num;
        }

        static void Main(string[] args)
        {
            string nom_user = Demande_nom();
            int age_num     = Demande_age();

            Console.WriteLine
            ("Bonjour votre nom est " + nom_user + " et vous avez " + age_num + " ans");

            int age_prochain = age_num + 1;
            Console.WriteLine
            ("Bientôt vous aurez " + age_prochain + " ans");

        }
    }
}