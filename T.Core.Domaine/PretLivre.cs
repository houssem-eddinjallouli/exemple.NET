using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Core.Domaine
{//class de relation
    public class PretLivre
    {
        public DateTime DateFin { get; set; }
        public DateTime DateDebut { get; set; }
        
        
        public Abonne MyAbonne { get; set; }
        public int AbonneFk { get; set; }
        public Livre MyLivre { get; set; }
        public int LivreFk { get; set; }
    }
}
