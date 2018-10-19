using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CommandeComptant : Commande
    {
        public CommandeComptant(double montant) : base(montant)
        {
        }

        public override void Paye()
        {
            Console.WriteLine("Le paiement de la commande au comptant de : " + montant + " est effectué.");
        }

        public override bool Valide()
        {
            return true;
        }
    }
}
