using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Program 
    {
        static void Main(string[] args)
        {

            Utilisateur utilisateur = new Utilisateur();

            utilisateur.age = 0;
            
            utilisateur.prenom = "tata";

            string aaaa = utilisateur.nom;
            Console.WriteLine(aaaa);
            Console.ReadLine();
        }
    }
}
