using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractEtInterfaces
{
    public class AutomobileEssence : Automobile // "base" fait reference à la classe mère Automobile
    {
        public AutomobileEssence(string modele, string couleur,
          int puissance, double espace) : base(modele, couleur,
          puissance, espace)
        { }

        public override void afficheCaracteristiques()
        {
            Console.WriteLine("Automobile à essence de modèle : "
              + modele + " de couleur : " + couleur +
              " de puissance : " + puissance + " d’espace : " +
              espace);
        }
    }
}
