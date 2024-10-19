using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        Roman b = new Roman("secret", "adam", 300, "eco");
        Roman d = new Roman("boreal", "amine", 200, "info");
        Roman w = new Roman("Linux", "ahmed", 250, "info");


        Revue a = new Revue("amir", "houdaifa", 300, 5, 2005);
        Revue h = new Revue("adamoc", "samir", 300, 5, 2005);
        Revue z = new Revue("simon", "ahmed", 300, 5, 2005);
        List<Livre> livres = new List<Livre>();

     
        livres.Add(z);
        livres.Add(a);
        livres.Add(h);

        livres.Add(b);
        livres.Add(d);
        livres.Add(w);

        foreach (Livre livre in livres)

        {

            livre.AfficherDetails();
        }
    }
}