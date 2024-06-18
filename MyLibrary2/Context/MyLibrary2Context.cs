using Microsoft.EntityFrameworkCore;
using MyLibrary2.Model;

namespace MyLibrary2.Context
{
    public class MyLibrary2Context : DbContext
    {

        public MyLibrary2Context(DbContextOptions<MyLibrary2Context>options) : base(options){}


        public DbSet<Editora>? Editoras { get; set; }
    }
}
