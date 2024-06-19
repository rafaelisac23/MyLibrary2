using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace MyLibrary2.Model
{
    public class Editora
    {
        public Editora()
        {
            Livros = new Collection<Livro>();
        }
        public int EditoraId { get; set; }

        [StringLength(100)]
        public string? Nome { get; set; }

        [StringLength(100)]
        public string? Endereco { get; set; }

        [StringLength(10)]
        public string? Telefone { get; set; }

        public ICollection<Livro>? Livros { get; set; }
    }
}
