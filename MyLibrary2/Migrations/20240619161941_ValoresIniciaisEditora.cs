using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLibrary2.Migrations
{
    /// <inheritdoc />
    public partial class ValoresIniciaisEditora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into editoras (Nome,Endereco,Telefone) values ('Editora1','Rua Feijo,1024','1292146311')");
            mb.Sql("Insert into editoras (Nome,Endereco,Telefone) values ('Editora2','Rua vasconcelos,12','0123456789')");
            mb.Sql("Insert into editoras (Nome,Endereco,Telefone) values ('Editora3','Rua 05,34','9874561230')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from editoras");

        }
    }
}
