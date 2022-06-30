using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class les_class
    {
        
        public struct Tel
        {
            public string marque;
            public int prix;

        }
        static void Main(string[] args)
        {
            Tel a ;
            a.marque = "Iphone";
            a.prix = 1000;
            System.Console.WriteLine(a.prix);

        }
    }
}