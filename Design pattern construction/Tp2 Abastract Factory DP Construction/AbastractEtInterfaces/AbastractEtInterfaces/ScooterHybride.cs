using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractEtInterfaces
{
    public class ScooterHybride : Scooter
    {
        public ScooterHybride(string modele, string couleur,
          int puissance) : base(modele, couleur, puissance) { }

        public override void afficheCaracteristiques()
        {
            Console.WriteLine("Scooter à hybride de modèle : " +
              modele + " de couleur : " + couleur +
              " de puissance : " + puissance);
        }

    }
}
