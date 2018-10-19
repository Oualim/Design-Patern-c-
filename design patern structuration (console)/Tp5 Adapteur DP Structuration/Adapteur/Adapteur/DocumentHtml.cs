﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapteur
{
    public class DocumentHtml : IDocument
    {
        protected string _contenu;

        public string Contenu
        {
            protected get
            {
                return _contenu;
            }
            set
            {
                _contenu = value;
            }
        }

        public void Dessine()
        {
            Console.WriteLine("Dessine document HTML : " +
              Contenu);
        }

        public void Imprime()
        {
            Console.WriteLine("Imprime document HTML : " +
              Contenu);
        }

    }
}
