﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMI_TPMoyennes
{
    // Classes fournies par HNI Institut
    class Note
    {
        public int matiere { get; private set; }
        public float note { get; private set; }
        public Note(int m, float n)
        {
            matiere = m;
            note = n;
        }
    }
}
