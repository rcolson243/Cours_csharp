namespace outils_perso {
    public class Outils {
        
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
}