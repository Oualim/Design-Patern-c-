using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractEtInterfaces

    // créer les definitions d'objet

{
    public interface IFabriqueVehicule // I signifie "Interface" sur le diagramme uml, l'interface est ecrit en italique
    {
        Automobile CreeAutomobile(string modele, string couleur, int puissance, double espace);

        Scooter CreeScooter(string modele, string couleur, int puissance);

    }
}
