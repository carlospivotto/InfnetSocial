using Microsoft.EntityFrameworkCore.Migrations;

namespace InfnetSocial.Data.Migrations
{
    public partial class Dominio_02_Amizade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amizade",
                columns: table => new
                {
                    UsuarioIdA = table.Column<int>(nullable: false),
                    UsuarioIdB = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amizade", x => new { x.UsuarioIdA, x.UsuarioIdB });
                    table.ForeignKey(
                        name: "FK_Amizade_Usuario_UsuarioIdA",
                        column: x => x.UsuarioIdA,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Amizade_Usuario_UsuarioIdB",
                        column: x => x.UsuarioIdB,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amizade_UsuarioIdB",
                table: "Amizade",
                column: "UsuarioIdB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amizade");
        }
    }
}
