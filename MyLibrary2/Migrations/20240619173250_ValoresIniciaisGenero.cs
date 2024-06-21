using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLibrary2.Migrations
{
    /// <inheritdoc />
    public partial class ValoresIniciaisGenero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert Into Generos (Nome) values ('ação')");
            mb.Sql("Insert Into Generos (Nome) values ('aventura')");
            mb.Sql("Insert Into Generos (Nome) values ('romance')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete From Generos");
        }
    }
}
