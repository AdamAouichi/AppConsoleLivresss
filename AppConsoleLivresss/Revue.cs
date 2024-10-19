using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Revue : Livre
    {
        public int Numero {  get; set; }
        public int Anne { get; set; }
     public Revue (string titre, string auteur, int nombrepages,int numero,int anne) 
            :base(titre,auteur,nombrepages)
            
        {
            Numero = numero;
            Anne=  anne;   
        }
        public override void AfficherDetails()
        {
           base.AfficherDetails();
            Console.WriteLine($"le nombre est:{Anne},le numero est{Numero}");
        }
    }
}
