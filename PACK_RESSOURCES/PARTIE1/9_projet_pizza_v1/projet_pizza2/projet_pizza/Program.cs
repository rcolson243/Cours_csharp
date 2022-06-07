﻿using System;
using System.Collections.Generic;
using System.Text;

namespace projet_pizza
{
    class Pizza
    {
        string nom;
        float prix;
        bool vegetarienne;

        public Pizza(string nom, float prix, bool vegetarienne)
        {
            this.nom = nom;
            this.prix = prix;
            this.vegetarienne = vegetarienne;
        }

        public void Afficher()
        {
            //4 fromages (V) - 11.5€
            /*string badgeVegetarienne = " (V)";
            if (!vegetarienne)
            {
                badgeVegetarienne = "";
            }*/

            string badgeVegetarienne = vegetarienne ? " (V)" : "";

            string nomAfficher = FormatPremiereLettreMajuscules(nom);

            Console.WriteLine(nomAfficher + badgeVegetarienne + " - " + prix + "€");
            
        }

        private static string FormatPremiereLettreMajuscules(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            string minuscules = s.ToLower();
            string majuscules = s.ToUpper();

            string resultat = majuscules[0] + minuscules[1..];

            return resultat;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Class Pizza
            // nom (4 fromages)
            // prix : 11.5
            // vegetarienne (vrai ou faux)
            // Constructeur
            // Afficher
            // 4 fromages (V) - 11.5€
            // Créer une liste de pizzas
            // boucler pour afficher les pizzas

            //var pizza1 = new Pizza("4 fromages", 11.5f, false);
            //pizza1.Afficher();

            var pizzas = new List<Pizza>() {
                new Pizza("4 fromages", 11.5f, true),
                new Pizza("indienne", 10.5f, false),
                new Pizza("MEXICAINE", 13f, false),
                new Pizza("margherita", 8f, true),
                new Pizza("Calzone", 12f, false),
                new Pizza("complète", 9.5f, false),
            };

            foreach(var pizza in pizzas)
            {
                pizza.Afficher();
            }

        }
    }
}
