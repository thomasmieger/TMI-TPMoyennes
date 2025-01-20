using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TMI_TPMoyennes
{
    class Eleve
    {
        public string prenom {  get; set; }
        public string nom { get; set; }
        public List<Note> notes { get; set; }
        private Classe classe;
        public Eleve (string prenom, string nom, Classe classe)
        {
            this.prenom = prenom;
            this.nom = nom;
            notes = new List<Note> ();
            this.classe = classe;
        }
        public void ajouterNote(Note note)
        {
            try
            {
                if (notes.Count < 200)
                {
                    notes.Add(note);
                }
                else
                {
                    throw new Exception("Le nombre maximal de notes pour un élève qui est de 200 a été dépassé");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public double moyenneMatiere(int matiere)
        {
            var moyenne = notes.Where(n => n.matiere == matiere).Select(n => n.note);
            return moyenne.Any() ? Math.Round(moyenne.Average(), 2) : 10.0;
        }

        public double moyenneGeneral()
        {
            var moyenne = classe.matieres.Keys.Select(moyenneMatiere);
            return moyenne.Any() ? Math.Round(moyenne.Average(), 2) : 10.0;

        }
        }
}
