using outils_perso;
using Heritage;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture ferari = new Voiture("ferari", 2023, 100000);
            Moto toyota = new Moto("toyota", 2026, 600, "rouge");

            Armur soldat = new Armur();
            Console.WriteLine
            ($"{soldat.Defense} DEF / {soldat.Duration} de durabilite");

            Armur soldat2 = new Armur(85, 150);
            Console.WriteLine
            ($"{soldat2.Defense} DEF / {soldat2.Duration} de durabilite");

            // le surcharge d'opérateur
            Armur soldat3 = soldat + soldat2;
            Console.WriteLine
            ($"{soldat3.Defense} DEF / {soldat3.Duration} de durabilite");

            Armur ar = new Armur(50);
            if (ar)
            {
                Console.WriteLine("Cool");
            }else 
                Console.WriteLine("Pas cool");
            

            

        }
    }
}


