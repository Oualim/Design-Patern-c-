﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Liasse
    {
        public IList<Document> documents { get; protected set; }
    }
}