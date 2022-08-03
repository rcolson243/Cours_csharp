namespace outils_perso {
    class Voiture {
        public string Marque { get; set; } = "lancia";
        public int Annee { get; set; } = 2021;
        public int PrixEuros { get; set;} = 10000000;

        public Voiture(string marque, int annee, int prixeuros) {
            this.Marque = marque;
            this.Annee = annee;
            this.PrixEuros = prixeuros;
        }

        public virtual void Demarre() => Console.WriteLine("Le vehicul est en marche");

        public string Fiche_vehicul() {
            return $"Marque : {this.Marque}\n Année : {this.Annee}\n Prix : {this.PrixEuros}€";
        }
    }

    class Moto : Voiture {
        public string Color { get; set; } = "red";

        public Moto(string marque , int annee , int prixeuros, string color ) : base(marque, annee, prixeuros)
        { 
            this.Color = color;
        }

        public override void Demarre() => Console.WriteLine
        ("La moto est en marche");
    }

    public class Person {

            private int _Id;
            #region le get et le set pour utiliser l'atribue _id en déhors
            public int Id 
            {
                get => _Id;
                set => _Id = value;
            }
            #endregion

            public string Nom;
            public int Age;
            
            #region le constructeur de class
            public Person(string nom, int age, int id){
                // un constructeur de classe 
                this.Nom = nom;
                this.Age = age;
                this._Id = id;
            }
            #endregion

            #region La methode Presentation
            public void Presentation() => Console.WriteLine
            ($"Helllo moi c'est {this.Nom} et j'ai {this.Age}");
            #endregion

        }


    public class Armur {
        public int Defense { get; set;}
        public int Duration { get; set;}

        public Armur (int defense = 250, int Duration = 100){
            this.Defense = defense;
            this.Duration = Duration; 
        }

        #region le surcharge d'opérateur
        public static Armur operator + (Armur a, Armur b) 
        { 
            return new Armur(a.Defense + b.Duration, a.Duration + b.Duration);
        }

        public static bool operator true (Armur a) => a.Defense >= 100;
        public static bool operator false (Armur a) => a.Defense < 100;
        
        #endregion
    }
}