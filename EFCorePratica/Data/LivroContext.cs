using EFCorePratica.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCorePratica.Data
{
    public class LivroContext : DbContext

    {
        public DbSet<Livro> Livros { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFCore.pratica;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Livro>()
                .ToTable("Livros");

            modelBuilder.Entity<Livro>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Livro>()
                .Property(x => x.Titulo)
                .HasColumnType("varchar(50)");
        }

    }
}
