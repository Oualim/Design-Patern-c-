using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilisateur utilisateur = new Utilisateur();

            utilisateur.LoadFactoryMethod(); // l'action (loadfactorymethod) doit forcement etre dans le meme fichier que la classe (objet)
        }
    }
}
