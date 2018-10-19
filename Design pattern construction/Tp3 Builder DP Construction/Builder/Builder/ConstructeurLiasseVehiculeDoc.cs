using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConstructeurLiasseVehiculeDoc : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeDoc()
        {
            liasse = new LiasseDoc();
        }

        public override void construitBonDeCommande(string
          nomClient)
        {
            string document = "<Doc>Bon de commande Client : " + nomClient + "</Doc>";
            liasse.ajouteDocument(document);
        }

        public override void construitDemandeImmatriculation(string nomDemandeur)
        {
            string document = "<Doc>Demande d'immatriculation Demandeur : " + nomDemandeur + "</Doc>";
            liasse.ajouteDocument(document);
        }
    }
}
