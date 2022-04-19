using Microsoft.EntityFrameworkCore.Migrations;

namespace loveladies.Data.Migrations
{
    public partial class AdicionaDescricaoCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentoras_Categorias_CategoriaId",
                table: "Mentoras");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Mentoras",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentoras_Categorias_CategoriaId",
                table: "Mentoras",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentoras_Categorias_CategoriaId",
                table: "Mentoras");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Categorias");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Mentoras",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentoras_Categorias_CategoriaId",
                table: "Mentoras",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
