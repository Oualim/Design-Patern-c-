using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Liasse
    {
        protected IList<string> contenu = new List<string>(); //protected car accessible que dans cette classe et les classes enfants
        public abstract void ajouteDocument(string document);
        public abstract void imprime();
    }
}
