using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Livre
    {
        public string Titre { get; set; }
        public string Auteur {  get; set; }
        public int NombrePages { get; set; }


        public Livre(string titre,string auteur,int nombrepages)
        { 
            Titre = titre;
            Auteur = auteur;
            NombrePages = nombrepages;
        }
        public virtual void AfficherDetails() 
        {
         Console.WriteLine($"le titre du livre est{Titre},l'auteur est {Auteur},le nombre de pages est{NombrePages}");
        }
        
    }

}
