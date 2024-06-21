using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLibrary2.Migrations
{
    /// <inheritdoc />
    public partial class ValoresIniciaisAutores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into autores (Nome,Data_nasc,Nacionalidade) values ('Autor1','2000-10-20','Brasileiro')");
            mb.Sql("Insert into autores (Nome,Data_nasc,Nacionalidade) values ('Autor2','2020-09-15','Portugues')");
            mb.Sql("Insert into autores (Nome,Data_nasc,Nacionalidade) values ('Autor3','2004-01-10','Mexicano')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from autores");
        }
    }
}
