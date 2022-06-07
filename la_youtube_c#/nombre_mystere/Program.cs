internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Devinez le nombre magique");

        int nombre_mstr = 20;
        int nombre_vie = 3;
        string reponse_user = "";

        try
        {
            while (reponse_user == "")
            {
                Console.WriteLine
                ("Devinez le nombre mysteren Attention vos vie sont compté");
                reponse_user = Console.ReadLine();
                nombre_vie--;

                try
                {
                    int reponse_user_int = int.Parse(reponse_user);

                    if (reponse_user_int > nombre_mstr)
                    {
                        Console.WriteLine
                        ("Le nombre magique est plus petit il vous reste");
                    }
                    else if (reponse_user_int < nombre_mstr)
                    {
                        Console.WriteLine
                        ("Vous avez perdu le nombre magique est plus grand");
                    }
                    else
                    {
                        Console.WriteLine
                        ($"Bravo vous avez gagner le nombre magique est bien le {reponse_user_int}");
                    }
                }
                catch
                {
                    Console.WriteLine("Vous devez rentrer un nombre");
                }
                
                if (nombre_vie == 0)
                {
                    System.Console.WriteLine("Sorry vos vie sont épuiser");
                    break;
                }

                

            }
        }
        catch
        {
            Console.WriteLine("Un probleme est survenu");
        }
    }
}