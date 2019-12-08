using EFCorePratica.Data;
using System;

namespace EFCorePratica
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LivroContext())
            {

                db.Database.EnsureCreated();
                db.Livros.Add(new Model.Livro {  Autor = "PauloPitte", AnoPublicacao = 2019, Titulo = "Paulo" });
                db.SaveChanges();
            }
        }
    }
}
