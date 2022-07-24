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

            toyota.Demarre();
            
            Console.WriteLine(toyota.Fiche_vehicul());
            Console.WriteLine();
            Console.WriteLine(ferari.Fiche_vehicul());

        }
    }
}


