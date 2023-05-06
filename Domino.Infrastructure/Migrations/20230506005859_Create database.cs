using Microsoft.EntityFrameworkCore.Migrations;

namespace Domino.Infrastructure.Migrations
{
    public partial class Createdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DominoPiece_Users_userid",
                table: "DominoPiece");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "DominoPiece",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "DominoPiece",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_DominoPiece_userid",
                table: "DominoPiece",
                newName: "IX_DominoPiece_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "DominoPiece",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DominoPiece_Users_UserId",
                table: "DominoPiece",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DominoPiece_Users_UserId",
                table: "DominoPiece");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "DominoPiece",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DominoPiece",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_DominoPiece_UserId",
                table: "DominoPiece",
                newName: "IX_DominoPiece_userid");

            migrationBuilder.AlterColumn<int>(
                name: "userid",
                table: "DominoPiece",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_DominoPiece_Users_userid",
                table: "DominoPiece",
                column: "userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
