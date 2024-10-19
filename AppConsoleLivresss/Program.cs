using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        

        Revue a = new Revue("amir", "houdaifa", 300, 5, 2005);
        Revue h = new Revue("adamoc", "samir", 300, 5, 2005);
        Revue z = new Revue("simon", "ahmed", 300, 5, 2005);
        List<Livre> livres = new List<Livre>();

     
        livres.Add(z);
        livres.Add(a);
        livres.Add(h);

        foreach (Livre livre in livres)

        {

            livre.AfficherDetails();
        }
    }
}