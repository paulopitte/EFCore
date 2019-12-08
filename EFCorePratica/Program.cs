using EFCorePratica.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCorePratica
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LivroContext())
            {


                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();



                if (db.Livros.Any())
                    db.Database.ExecuteSqlCommand("DELETE FROM dbo.Livros");


                db.Livros.Add(new Model.Livro { Autor = "PauloPitte", AnoPublicacao = 2019, Titulo = "Paulo1" });
                db.Livros.Add(new Model.Livro { Autor = "Eric Evans", AnoPublicacao = 2007, Titulo = "Domain driven designer" });
                db.Livros.Add(new Model.Livro { Autor = "PauloPitte2", AnoPublicacao = 2019, Titulo = "Paulo2" });
                db.Livros.Add(new Model.Livro { Autor = "PauloPitte3", AnoPublicacao = 2019, Titulo = "Paulo3" });
                db.Livros.Add(new Model.Livro { Autor = "PauloPitte4", AnoPublicacao = 2019, Titulo = "Paulo4" });
                db.Livros.Add(new Model.Livro { Autor = "PauloPitte5", AnoPublicacao = 2019, Titulo = "Paulo5" });
                db.SaveChanges();
            }
        }
    }
}
