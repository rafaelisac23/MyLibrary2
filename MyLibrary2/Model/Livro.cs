using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace MyLibrary2.Model
{
    public class Livro
    {
        public Livro()
        {
            Emprestimos = new Collection<Emprestimo>();
        }
        public int LivroId { get; set; }

        [StringLength(150)]
        public string? Titulo { get; set; }

        public int AutorId { get; set; }
        public Autor? Autor { get; set; }

        public int GeneroId { get; set; }
        public Genero? Genero { get; set; }

        public int EditorId { get; set; }
        public Editora? Editora { get; set; }

        public ICollection<Emprestimo>? Emprestimos { get; set;}
    }
}
