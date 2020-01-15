using Microsoft.EntityFrameworkCore.Migrations;

namespace VemDeZap.Infra.Migrations
{
    public partial class AjusteiCampanha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campanha_Usuario_UsuarioId",
                table: "Campanha");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Campanha",
                newName: "IdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Campanha_UsuarioId",
                table: "Campanha",
                newName: "IX_Campanha_IdUsuario");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Campanha",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Campanha_Usuario_IdUsuario",
                table: "Campanha",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campanha_Usuario_IdUsuario",
                table: "Campanha");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Campanha",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Campanha_IdUsuario",
                table: "Campanha",
                newName: "IX_Campanha_UsuarioId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Campanha",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AddForeignKey(
                name: "FK_Campanha_Usuario_UsuarioId",
                table: "Campanha",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
