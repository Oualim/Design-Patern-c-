using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Client
    {
        protected IList<Commande> commandes = new List<Commande>();

        protected abstract Commande creeCommande(double montant);

        public void nouvelleCommande(double montant)
        {
            Commande commande = this.creeCommande(montant);
            if (commande.Valide())
            {
                commande.Paye();
                commandes.Add(commande);
            }
        }
    }
}
