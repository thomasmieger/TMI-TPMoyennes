using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNI_TPmoyennes
{
    class Classe
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public List<Eleve> eleves { get; set; }
        public List<string> matieres { get; set; }
        public Classe(string prenom, string nom)
        {
            this.nom = nom;
            this.prenom = prenom;
            eleves = new List<Eleve>();
            matieres = new List<string>();
        }
    }
}
