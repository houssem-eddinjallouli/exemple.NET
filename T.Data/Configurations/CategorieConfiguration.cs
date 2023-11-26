using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.Core.Domaine;

namespace T.Data.Configurations
{
    internal class CategorieConfiguration : IEntityTypeConfiguration<Categorie>
    {
        public void Configure(EntityTypeBuilder<Categorie> builder)
        {
            builder.HasMany(e => e.Livres)
                    .WithOne(e => e.MyCategorie)
                    .HasForeignKey(e => e.CategorieId);
        }
    }
}
