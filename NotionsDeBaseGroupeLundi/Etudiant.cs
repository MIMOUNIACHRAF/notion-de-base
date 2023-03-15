using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsDeBaseGroupeLundi
{
    class Etudiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Genre { get; set; }
        public string Tel { get; set; }
        public Etudiant()
        {
                
        }
        public Etudiant(int Id,string Nom,string Prenom,string Genre, string Tel)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Genre = Genre;
            this.Tel = Tel;
        }

        public override string ToString()
        {
            return this.Nom + " - " + this.Prenom;
        }



    }
}
