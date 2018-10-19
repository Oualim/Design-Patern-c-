using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandeTVA
{
    public class Luxembourg : Pays
    {
        public override decimal CalculeTva(decimal montantHt) // override (surcharge) permet de réutiliser la methode avec un retour aleatoire
        {
            return montantHt * 0.15M;
        }
    }
}
