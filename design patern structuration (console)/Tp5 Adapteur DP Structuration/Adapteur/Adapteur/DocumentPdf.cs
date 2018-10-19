using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapteur
{
    public class DocumentPdf : IDocument
    {
        protected ComposantPdf outilPdf = new ComposantPdf();

        public string Contenu
        {
            set
            {
                outilPdf.PdfFixeContenu(value);
            }
        }

        public void Dessine()
        {
            outilPdf.PdfPrepareAffichage();
            outilPdf.PdfRafraichit();
            outilPdf.PdfTermineAffichage();
        }

        public void Imprime()
        {
            outilPdf.PdfEnvoieImprimante();
        }
    }
}
