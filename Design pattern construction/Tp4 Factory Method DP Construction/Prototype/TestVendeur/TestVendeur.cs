using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVendeur
{
    public class TestVendeur
    {
        public static void affiche()
        {
            Vendeur leVendeur = Vendeur.Instance();
            leVendeur.affiche();
        }

        public void LoadSingleton()
        {
            // initialisation du vendeur du système
            Vendeur leVendeur = Vendeur.Instance();
            leVendeur.nom = "Vendeur Auto";
            leVendeur.adresse = "Paris";
            leVendeur.email = "vendeur@vendeur.com";
            // affichage du vendeur du système
            affiche();
            Vendeur leVendeur2 = Vendeur.Instance();
            leVendeur2.nom = "Vendeur Auto Godwin";
            leVendeur2.adresse = "Lyon";
            leVendeur2.email = "vendeur@vendeurgodwin.com";
            affiche();

        }
    }
}
