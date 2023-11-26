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
    internal class PretLivreConfig : IEntityTypeConfiguration<PretLivre>
    {
        public void Configure(EntityTypeBuilder<PretLivre> builder)
        {
            builder.HasKey(e => new
            {
                e.DateDebut,
                e.AbonneFk,
                e.LivreFk

            });
            builder.HasOne(e => e.MyLivre)
                .WithMany(e => e.PretLivres)
                .HasForeignKey(e => e.LivreFk);

            builder.HasOne(e => e.MyAbonne)
                .WithMany(e => e.PretLivres)
                .HasForeignKey(e => e.AbonneFk);
        }
    }
}
