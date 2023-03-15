using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsDeBaseGroupeLundi
{
    class Professeur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Specialite { get; set; }
        public List<Etudiant> Etudiants { get; set; }
        public Professeur(int Id, string Nom, string Prenom, string Specialite)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Specialite = Specialite;
            this.Etudiants = new List<Etudiant>();
        }
        public void Ajouter()
        {
            Etudiant e = new Etudiant();
            Console.Write("Saisir l'Id : ");
            e.Id = int.Parse(Console.ReadLine());
            Console.Write("Saisir le Nom : ");
            e.Nom = Console.ReadLine();
            Console.Write("Saisir le Prenom : ");
            e.Prenom = Console.ReadLine();
            Console.Write("Saisir le Genre : ");
            e.Genre = Console.ReadLine();
            Console.Write("Saisir le Tel : ");
            e.Tel = Console.ReadLine();
            this.Etudiants.Add(e);
        }

        public void Supprimer(int id)
        {
            foreach (Etudiant item in this.Etudiants)
            {
                if(id == item.Id)
                {
                    this.Etudiants.Remove(item);
                    break;
                }
            }
        }

        public IEnumerable<Etudiant> FindByGenre(string genre)
        {

            foreach (Etudiant etudiant in this.Etudiants)
            {
                if(etudiant.Genre == genre)
                {
                    yield return etudiant;
                }else if(genre == "")
                {
                    yield return etudiant;
                }
            }
        }

        public string ToString(string genre, Func<string, IEnumerable<Etudiant>> fnc)
        {
            string chaine = this.Nom + " - " + this.Prenom + " - " + this.Specialite + " : \n";
            List<Etudiant> etudiants = fnc(genre).ToList();
            foreach (Etudiant item in etudiants)
            {
                chaine += item.ToString() + ". \n";
            }
            return chaine;
        }






    }
}
