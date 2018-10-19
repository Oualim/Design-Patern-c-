using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractEtInterfaces
{
    class Program
    {
        static void Main (string[] args)
        {
            Catalogue monCatalogue = new Catalogue();

            monCatalogue.LoadCatalogue();
        }
    }
}
