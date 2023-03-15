using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsDeBaseGroupeLundi
{
    static class ProfessorExt
    {
        //this professeur est le type qui doit etre passer en paramaetre dans ce cas la methode vide n'accepte que le type professeur
        public static void Vider(this Professeur prf)
        {
            prf.Etudiants.Clear();
        }

        public static IEnumerable<Etudiant> HaveFix(this Professeur prf)
        {
            foreach (Etudiant item in prf.Etudiants)
            {
                if(item.Tel.StartsWith("05"))
                {
                    yield return item;
                }
            }
        }

        public static void Show(this List<Etudiant> list)
        {
            foreach (Etudiant item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
        //cette  methode utilise un delegue , {predicate} where est le nom de la methode 
        public static IEnumerable<Etudiant> Where(this Professeur prf, Predicate<Etudiant> condition)
        {
            foreach (Etudiant item in prf.Etudiants)
            {
                if (condition(item))
                {
                    yield return item;
                }
            }
        }
    }
}
