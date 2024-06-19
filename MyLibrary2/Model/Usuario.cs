using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace MyLibrary2.Model
{
    public class Usuario
    {
        public Usuario()
        {
            Emprestimos = new Collection<Emprestimo>();
        }
        public int UsuarioId { get; set; }

        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(100)]
        public string? Endereco { get; set; }

        [StringLength(100)]
        public string? Telefone { get; set; }

        [StringLength(100)]
        public string? Email { get; set; }

        public ICollection<Emprestimo>? Emprestimos { get; set; }
    }
}
