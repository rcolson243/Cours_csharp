using System;

namespace MyApp
{
    internal class Program
    {
        public static int somme (int x , int y) => x + y; 
        public static void affiche_text (int text) => Console.WriteLine(text);
        public static void say(string name = "Inconnu", string message = "Hello") { 
            Console.WriteLine($"{name} : {message}");
        }
        static void Main(string[] args)
        {   
            #region les arguments nommer 
                // say("Raphael","J'ai un rêve");
            #endregion

            Program.say("Raphael", "J'ai un rêve");
        }

    }
}