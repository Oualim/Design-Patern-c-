using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractEtInterfaces
{

    public class FabriqueVehiculeElectricite : IFabriqueVehicule
    {
        public Automobile CreeAutomobile(string modele, string couleur, int puissance, double espace)
        {
            return new AutomobileElectricite(modele, couleur, puissance, espace);
        }

        public Scooter CreeScooter(string modele, string couleur, int puissance)
        {
            return new ScooterElectricite(modele, couleur, puissance);
        }
    }
}
