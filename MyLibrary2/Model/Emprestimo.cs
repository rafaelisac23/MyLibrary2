using System.ComponentModel.DataAnnotations;

namespace MyLibrary2.Model
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data_emprestimo{ get; set; }

        [DataType(DataType.Date)]
        public DateTime Data_devolucao { get; set; }


    }
}
