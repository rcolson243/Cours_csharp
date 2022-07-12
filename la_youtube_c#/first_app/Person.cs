class Person {
    public string nom;
    public string prenom;
    // la méthode
    public void presentation(){ 
        Console.WriteLine($"Mon c'est {nom} et mon prenom c'est {prenom}");
    }
    public void parle() {
        System.Console.WriteLine($"hello c'est moi {nom} votre ami");
    }
}