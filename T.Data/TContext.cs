using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.Core.Domaine;
using T.Data.Configurations;

namespace T.Data
{
    internal class TContext : DbContext
    {
        public DbSet<Abonne> Abonnes { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Livre> Livres { get; set; }
        public DbSet<PretLivre> PretLivres { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=testhoussembase;Integrated Security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PretLivreConfig());
            modelBuilder.ApplyConfiguration(new CategorieConfiguration());
        }
    }
}
