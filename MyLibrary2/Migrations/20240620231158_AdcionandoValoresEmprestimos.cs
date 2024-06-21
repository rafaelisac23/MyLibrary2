using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLibrary2.Migrations
{
    /// <inheritdoc />
    public partial class AdcionandoValoresEmprestimos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into emprestimos (Data_emprestimo,Data_devolucao,LivroId,UsuarioId) values (now(),'2024-06-27','1','1')");
            mb.Sql("Insert into emprestimos (Data_emprestimo,Data_devolucao,LivroId,UsuarioId) values (now(),'2024-06-27','2','2')");
            mb.Sql("Insert into emprestimos (Data_emprestimo,Data_devolucao,LivroId,UsuarioId) values (now(),'2024-06-27','3','3')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from emprestimos");
        }
    }
}
