using Microsoft.EntityFrameworkCore.Migrations;

namespace VemDeZap.Infra.Migrations
{
    public partial class AjusteiEnvio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Envio_Campanha_CampanhaId",
                table: "Envio");

            migrationBuilder.DropForeignKey(
                name: "FK_Envio_Contato_ContatoId",
                table: "Envio");

            migrationBuilder.DropForeignKey(
                name: "FK_Envio_Grupo_GrupoId",
                table: "Envio");

            migrationBuilder.RenameColumn(
                name: "GrupoId",
                table: "Envio",
                newName: "IdGrupo");

            migrationBuilder.RenameColumn(
                name: "ContatoId",
                table: "Envio",
                newName: "IdContato");

            migrationBuilder.RenameColumn(
                name: "CampanhaId",
                table: "Envio",
                newName: "IdCampanha");

            migrationBuilder.RenameIndex(
                name: "IX_Envio_GrupoId",
                table: "Envio",
                newName: "IX_Envio_IdGrupo");

            migrationBuilder.RenameIndex(
                name: "IX_Envio_ContatoId",
                table: "Envio",
                newName: "IX_Envio_IdContato");

            migrationBuilder.RenameIndex(
                name: "IX_Envio_CampanhaId",
                table: "Envio",
                newName: "IX_Envio_IdCampanha");

            migrationBuilder.AddForeignKey(
                name: "FK_Envio_Campanha_IdCampanha",
                table: "Envio",
                column: "IdCampanha",
                principalTable: "Campanha",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envio_Contato_IdContato",
                table: "Envio",
                column: "IdContato",
                principalTable: "Contato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envio_Grupo_IdGrupo",
                table: "Envio",
                column: "IdGrupo",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Envio_Campanha_IdCampanha",
                table: "Envio");

            migrationBuilder.DropForeignKey(
                name: "FK_Envio_Contato_IdContato",
                table: "Envio");

            migrationBuilder.DropForeignKey(
                name: "FK_Envio_Grupo_IdGrupo",
                table: "Envio");

            migrationBuilder.RenameColumn(
                name: "IdGrupo",
                table: "Envio",
                newName: "GrupoId");

            migrationBuilder.RenameColumn(
                name: "IdContato",
                table: "Envio",
                newName: "ContatoId");

            migrationBuilder.RenameColumn(
                name: "IdCampanha",
                table: "Envio",
                newName: "CampanhaId");

            migrationBuilder.RenameIndex(
                name: "IX_Envio_IdGrupo",
                table: "Envio",
                newName: "IX_Envio_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_Envio_IdContato",
                table: "Envio",
                newName: "IX_Envio_ContatoId");

            migrationBuilder.RenameIndex(
                name: "IX_Envio_IdCampanha",
                table: "Envio",
                newName: "IX_Envio_CampanhaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Envio_Campanha_CampanhaId",
                table: "Envio",
                column: "CampanhaId",
                principalTable: "Campanha",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envio_Contato_ContatoId",
                table: "Envio",
                column: "ContatoId",
                principalTable: "Contato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envio_Grupo_GrupoId",
                table: "Envio",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
