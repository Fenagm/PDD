using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TP_Parcial.Migrations
{
    public partial class version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Usuario = table.Column<string>(nullable: true),
                    Clave = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Recursos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true),
                    UsuariosId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recursos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recursos_Usuario_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    titulo = table.Column<string>(nullable: true),
                    vencimiento = table.Column<DateTime>(nullable: false),
                    estimacion = table.Column<int>(nullable: false),
                    recursosId = table.Column<int>(nullable: false),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tareas_Recursos_recursosId",
                        column: x => x.recursosId,
                        principalTable: "Recursos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detalles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fecha = table.Column<DateTime>(nullable: false),
                    tiempo = table.Column<int>(nullable: false),
                    recursosId = table.Column<int>(nullable: false),
                    tareasId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles", x => x.id);
                    table.ForeignKey(
                        name: "FK_Detalles_Recursos_recursosId",
                        column: x => x.recursosId,
                        principalTable: "Recursos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalles_Tareas_tareasId",
                        column: x => x.tareasId,
                        principalTable: "Tareas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_recursosId",
                table: "Detalles",
                column: "recursosId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_tareasId",
                table: "Detalles",
                column: "tareasId");

            migrationBuilder.CreateIndex(
                name: "IX_Recursos_UsuariosId",
                table: "Recursos",
                column: "UsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Tareas_recursosId",
                table: "Tareas",
                column: "recursosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalles");

            migrationBuilder.DropTable(
                name: "Tareas");

            migrationBuilder.DropTable(
                name: "Recursos");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
