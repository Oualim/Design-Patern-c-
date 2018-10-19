using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapteur
{
    public class ServeurWeb
    {

        public void LoadAdapter()
        {
            IDocument document1, document2;
            document1 = new DocumentHtml();
            document1.Contenu = "Hello";
            document1.Dessine();
            Console.WriteLine();
            document2 = new DocumentPdf();
            document2.Contenu = "Bonjour";
            document2.Dessine();
        }
    }
}
