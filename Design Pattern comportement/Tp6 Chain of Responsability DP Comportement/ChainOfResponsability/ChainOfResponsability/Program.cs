﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilisateur utilisateur = new Utilisateur();
            utilisateur.LoadChainOfResponsibility();
        }
    }
}