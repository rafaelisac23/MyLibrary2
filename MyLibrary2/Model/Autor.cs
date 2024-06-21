using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace MyLibrary2.Model
{
    public class Autor
    {
        public Autor()
        {
            Livros = new Collection<Livro>();
        }
        public int AutorId { get; set; }

        [StringLength(150)]
        public string? Nome { get; set; }

        public DateOnly Data_nasc { get; set; }

        [StringLength(100)]
        public string? Nacionalidade { get; set; }

        public ICollection<Livro>? Livros { get; set; }
    }
}
