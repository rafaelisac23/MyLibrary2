using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLibrary2.Migrations
{
    /// <inheritdoc />
    public partial class AdcionandoValoresUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into usuarios(Name,Endereco,Telefone,Email) values ('usuario1','Rua Feijó,1','1234567890','usuario1@gmail.com') ");
            mb.Sql("Insert into usuarios(Name,Endereco,Telefone,Email) values ('usuario1','Rua Feijó,2','1234567890','usuario2@gmail.com') ");
            mb.Sql("Insert into usuarios(Name,Endereco,Telefone,Email) values ('usuario1','Rua Feijó,3','1234567890','usuario3@gmail.com') ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete From usuarios");
        }
    }
}
