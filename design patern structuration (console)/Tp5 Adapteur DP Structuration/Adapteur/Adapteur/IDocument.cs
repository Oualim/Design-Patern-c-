using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapteur
{
    public interface IDocument
    {
        string Contenu { set; }
        void Dessine();
        void Imprime();

    }
}
