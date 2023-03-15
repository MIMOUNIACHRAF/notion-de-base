using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsDeBaseGroupeLundi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Professeur p = new Professeur(1, "MANI", "Adil", "Programmation");
            //p.ToString("Homme", ( nom) => 
            //{
            //    return null;
            //});

            //List<Etudiant> etudiants = p.HaveFix().ToList();
            //etudiants.Show();

            //p.Where((e) =>e.Id > 0 && e.Id < 10);

            Professeur p = new Professeur(1, "MANI", "Adil", "Programmation");
            p.FindByGenre("Femme");
            p.ToString("Femme",  ( message) => null);

            p.Vider();

            p.Where(( e) => e.Tel.StartsWith("06"));
            p.Where(( e) => e.Id > 10 && e.Id < 20);

           // database.Filiere.Where((f) => f.libelle == "GI").ToList();
        }







   

    }
}
