using Microsoft.EntityFrameworkCore;

namespace MyLibrary2.Context
{
    public class MyLibrary2Context : DbContext
    {

        public MyLibrary2Context(DbContextOptions<MyLibrary2Context>options) : base(options){}
    }
}
