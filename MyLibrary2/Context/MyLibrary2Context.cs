using Microsoft.EntityFrameworkCore;
using MyLibrary2.Model;

namespace MyLibrary2.Context
{
    public class MyLibrary2Context : DbContext
    {

        public MyLibrary2Context(DbContextOptions<MyLibrary2Context>options) : base(options){}


        public DbSet<Editora>? Editoras { get; set; }
        public DbSet<Autor>? Autores { get; set; }
        public DbSet<Genero>? Generos { get; set; }
        public DbSet<Livro>? Livros { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Emprestimo>? Emprestimos {  get; set; } 

    }
}
