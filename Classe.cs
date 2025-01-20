using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMI_TPMoyennes
{
    class Classe
    {
        public List<Eleve> eleves { get; set; }
        public Dictionary<int,string> matieres { get; set; }
        public string nomClasse { get; set; }
        public Classe(string nomClasse)
        {
            this.nomClasse = nomClasse;
            eleves = new List<Eleve>();
            matieres = new Dictionary<int, string>();
        }
        public void ajouterEleve(string prenom, string nom)
        {
            try
            {
                if (eleves.Count < 30)
                {
                    eleves.Add(new Eleve(prenom, nom, this));
                }
                else
                {
                    throw new Exception("Le nombre maximum d'élèves pour une classe qui est de 30 a été dépassé");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public void ajouterMatiere(string matiere)
        {
            try
            {
                if (matieres.Count < 10)
                {
                    int idMatiere = matieres.Count + 1;
                    matieres[idMatiere] = matiere;
                }
                else
                {
                    throw new Exception("Le nombre maximum de matières pour une classe qui est de 10 a été dépassé");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public virtual double moyenneMatiere(int matiere)
        {
            var moyenne = eleves.Select(e => e.moyenneMatiere(matiere));
            return moyenne.Any() ? Math.Round(moyenne.Average(), 2) : 0.0;
        }
        public virtual double moyenneGeneral()
        {
            var moyenne = matieres.Keys.Select(moyenneMatiere);
            return moyenne.Any() ? Math.Round(moyenne.Average(), 2) : 0.0;
        }
    }
}
