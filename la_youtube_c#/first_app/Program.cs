using System; // Nous permet de travailler des methode et module de c#

namespace Variable // Note: actual namespace depends on the project name.
{
    class Program
    {   
        static void Main(string[] args)
        {
            var random_num = new Random();
            random_num.Next(1, 100);

            var tab_num = new int[5];
            tab_num[0] = 1;

            for (int i = 0; i < tab_num.Length; i++) {
                System.Console.WriteLine(tab_num[i]);
            }
        }   
    }
}