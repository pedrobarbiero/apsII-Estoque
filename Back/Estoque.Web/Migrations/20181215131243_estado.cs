using Microsoft.EntityFrameworkCore.Migrations;

namespace Estoque.Web.Migrations
{
    public partial class estado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Cidades_CidadeId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_CidadeId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "CidadeId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pessoas");

            migrationBuilder.AddColumn<long>(
                name: "PaisId",
                table: "Estados",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Estados_PaisId",
                table: "Estados",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estados_Paises_PaisId",
                table: "Estados",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estados_Paises_PaisId",
                table: "Estados");

            migrationBuilder.DropIndex(
                name: "IX_Estados_PaisId",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Estados");

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CidadeId",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_CidadeId",
                table: "Pessoas",
                column: "CidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Cidades_CidadeId",
                table: "Pessoas",
                column: "CidadeId",
                principalTable: "Cidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
