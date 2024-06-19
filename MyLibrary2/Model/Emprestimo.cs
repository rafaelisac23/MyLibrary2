using System.ComponentModel.DataAnnotations;

namespace MyLibrary2.Model
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Data_emprestimo{ get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Data_devolucao { get; set; }

        [Required]
        public int LivroId { get; set; }
        public Livro? Livro { get; set; }

        [Required]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }  


    }
}
