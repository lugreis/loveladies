using Microsoft.EntityFrameworkCore.Migrations;

namespace loveladies.Data.Migrations
{
    public partial class AlteraIdParaString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentorias_AspNetUsers_UserId1",
                table: "Mentorias");

            migrationBuilder.DropIndex(
                name: "IX_Mentorias_UserId1",
                table: "Mentorias");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Mentorias");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Mentorias",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Mentorias_UserId",
                table: "Mentorias",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentorias_AspNetUsers_UserId",
                table: "Mentorias",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentorias_AspNetUsers_UserId",
                table: "Mentorias");

            migrationBuilder.DropIndex(
                name: "IX_Mentorias_UserId",
                table: "Mentorias");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Mentorias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Mentorias",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mentorias_UserId1",
                table: "Mentorias",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentorias_AspNetUsers_UserId1",
                table: "Mentorias",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
