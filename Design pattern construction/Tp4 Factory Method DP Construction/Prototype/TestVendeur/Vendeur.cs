using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVendeur
{
    public class Vendeur
    {
        public string nom { get; set; }
        public string adresse { get; set; }
        public string email { get; set; }

        private static Vendeur _instance = null; // creer une methode avec le nom de la classe et lui assigner une valeur "null"

        private Vendeur() { } // cree constrcuteur (du meme nom que la class) en private

        public static Vendeur Instance() // avoir une methode qui va retourner à chaque fois l'instance initiale
        {
            if (_instance == null)
                _instance = new Vendeur();
            return _instance;
        }

        public void affiche()
        {
            Console.WriteLine("Nom : " + nom);
            Console.WriteLine("Adresse : " + adresse);
            Console.WriteLine("Email : " + email);
        }

    }
}
