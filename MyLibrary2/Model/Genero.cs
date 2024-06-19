using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace MyLibrary2.Model
{
    public class Genero
    {
        public Genero()
        {
            Livros = new Collection<Livro>();
        }
        public int GeneroId { get; set; }

        [StringLength(100)]
        public string? Nome { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}
