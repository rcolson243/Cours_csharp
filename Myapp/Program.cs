using System;
using outils_perso;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        
        class Window {
            public string Title;
            public int Width;

            public Window(string titre, int taille) {
                this.Title = titre;
                this.Width = taille;
            } 
        } 

        
        static void Main(string[] args)
        {
            Person antony = new Person("antony", 18, 765);

            antony.Presentation();
            System.Console.WriteLine($"Mon identifiant c'est le mot de {antony.Id}");

        }
    }
}


