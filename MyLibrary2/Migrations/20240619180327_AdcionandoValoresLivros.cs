using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLibrary2.Migrations
{
    /// <inheritdoc />
    public partial class AdcionandoValoresLivros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into livros (Titulo,AutorId,GeneroId,EditoraId,Data_publi) values ('Livro1','1','1','2','2000-10-30')");
            mb.Sql("Insert into livros (Titulo,AutorId,GeneroId,EditoraId,Data_publi) values ('Livro2','2','2','3','2000-10-20')");
            mb.Sql("Insert into livros (Titulo,AutorId,GeneroId,EditoraId,Data_publi) values ('Livro3','3','3','4','2000-10-10')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from livros");
        }
    }
}
