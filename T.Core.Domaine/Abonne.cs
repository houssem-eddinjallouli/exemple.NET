using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Core.Domaine
{
    public enum Statut
    {
        Etudiant, Enseignant, Autre
    }
    public class Abonne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Id { get; set; }
        public Statut Statut { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public DateTime DateCreation { get; set; }
        public virtual IList<PretLivre> PretLivres { get; set; }
    }
}
