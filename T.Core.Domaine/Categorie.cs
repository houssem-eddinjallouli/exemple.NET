using System.ComponentModel.DataAnnotations;

namespace T.Core.Domaine
{
    public class Categorie
    {
        [Key]
        public int Code { get; set; }
        public string Libelle { get; set; }
        public virtual IList<Livre> Livres { get; set; }

    }
}