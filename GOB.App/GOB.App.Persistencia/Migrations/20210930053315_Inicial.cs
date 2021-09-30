using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GOB.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aislamiento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaDiagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    periodoAislamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaRetorno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sintomas = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aislamiento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gobernacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroSedes = table.Column<int>(type: "int", nullable: false),
                    maxNumeroIngresos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gobernacion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gobernadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<int>(type: "int", nullable: false),
                    identificacion = table.Column<int>(type: "int", nullable: false),
                    estadoSalud = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gobernadores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ingreso",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    horaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sedeIngreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    oficinaIngreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estadoIngreso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingreso", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personal",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    turno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<int>(type: "int", nullable: false),
                    identificacion = table.Column<int>(type: "int", nullable: false),
                    estadoSalud = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personal", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "proveedor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lugarServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<int>(type: "int", nullable: false),
                    identificacion = table.Column<int>(type: "int", nullable: false),
                    estadoSalud = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SecretariosDespacho",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    despacho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<int>(type: "int", nullable: false),
                    identificacion = table.Column<int>(type: "int", nullable: false),
                    estadoSalud = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecretariosDespacho", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "oficina",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroOficina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estadoOficina = table.Column<int>(type: "int", nullable: false),
                    GobernadorAsesoresid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oficina", x => x.id);
                    table.ForeignKey(
                        name: "FK_oficina_gobernadores_GobernadorAsesoresid",
                        column: x => x.GobernadorAsesoresid,
                        principalTable: "gobernadores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sedes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroSede = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numeroOficinas = table.Column<int>(type: "int", nullable: false),
                    GobernadorAsesoresid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sedes", x => x.id);
                    table.ForeignKey(
                        name: "FK_sedes_gobernadores_GobernadorAsesoresid",
                        column: x => x.GobernadorAsesoresid,
                        principalTable: "gobernadores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_oficina_GobernadorAsesoresid",
                table: "oficina",
                column: "GobernadorAsesoresid");

            migrationBuilder.CreateIndex(
                name: "IX_sedes_GobernadorAsesoresid",
                table: "sedes",
                column: "GobernadorAsesoresid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aislamiento");

            migrationBuilder.DropTable(
                name: "gobernacion");

            migrationBuilder.DropTable(
                name: "ingreso");

            migrationBuilder.DropTable(
                name: "oficina");

            migrationBuilder.DropTable(
                name: "personal");

            migrationBuilder.DropTable(
                name: "proveedor");

            migrationBuilder.DropTable(
                name: "SecretariosDespacho");

            migrationBuilder.DropTable(
                name: "sedes");

            migrationBuilder.DropTable(
                name: "gobernadores");
        }
    }
}
