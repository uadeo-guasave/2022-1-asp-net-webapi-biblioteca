using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiBiblioteca.Migrations
{
    public partial class CreateTablePrestamos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaLimite = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaDeRetorno = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Observaciones = table.Column<string>(type: "TEXT", nullable: true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    DocenteId = table.Column<int>(type: "INTEGER", nullable: true),
                    AlumnoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestamos_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Prestamos_Docentes_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "Docentes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Prestamos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EjemplarPrestamo",
                columns: table => new
                {
                    EjemplaresId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrestamosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EjemplarPrestamo", x => new { x.EjemplaresId, x.PrestamosId });
                    table.ForeignKey(
                        name: "FK_EjemplarPrestamo_Ejemplares_EjemplaresId",
                        column: x => x.EjemplaresId,
                        principalTable: "Ejemplares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EjemplarPrestamo_Prestamos_PrestamosId",
                        column: x => x.PrestamosId,
                        principalTable: "Prestamos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EjemplarPrestamo_PrestamosId",
                table: "EjemplarPrestamo",
                column: "PrestamosId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_AlumnoId",
                table: "Prestamos",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_DocenteId",
                table: "Prestamos",
                column: "DocenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_UsuarioId",
                table: "Prestamos",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EjemplarPrestamo");

            migrationBuilder.DropTable(
                name: "Prestamos");
        }
    }
}
