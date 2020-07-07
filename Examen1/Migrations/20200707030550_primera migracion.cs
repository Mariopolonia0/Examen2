using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen2.Migrations
{
    public partial class primeramigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    proyectoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fecha = table.Column<DateTime>(nullable: false),
                    descripcionproyecto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.proyectoId);
                });

            migrationBuilder.CreateTable(
                name: "TareaDetalle",
                columns: table => new
                {
                    tipoId = table.Column<int>(nullable: false),
                    tipoTarea = table.Column<string>(nullable: true),
                    requerimiento = table.Column<string>(nullable: true),
                    tiempo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TareaDetalle", x => x.tipoId);
                    table.ForeignKey(
                        name: "FK_TareaDetalle_Proyectos_tipoId",
                        column: x => x.tipoId,
                        principalTable: "Proyectos",
                        principalColumn: "proyectoId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TareaDetalle");

            migrationBuilder.DropTable(
                name: "Proyectos");
        }
    }
}
