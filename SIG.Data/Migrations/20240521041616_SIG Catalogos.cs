using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIG.Data.Migrations
{
    /// <inheritdoc />
    public partial class SIGCatalogos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catalogoUsuarios");

            migrationBuilder.AddColumn<string>(
                name: "ApellidoMaterno",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApellidoPaterno",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Contraseña",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Creado",
                table: "Usuarios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreadoPor",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EsActivo",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modificado",
                table: "Usuarios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModificadoPor",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CatalogoDependecias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false),
                    Creado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modificado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoDependecias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogoPuestoEmpleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoPuestoEmpleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "catalogoRolesUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false),
                    Creado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modificado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catalogoRolesUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogoTipoDeBienes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false),
                    Creado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modificado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoTipoDeBienes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogoUbicaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoUbicaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistroFacturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UUID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anotaciones = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroFacturas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogoDepartamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCatalogoDependecia = table.Column<int>(type: "int", nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false),
                    Creado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modificado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoDepartamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogoDepartamentos_CatalogoDependecias_IdCatalogoDependecia",
                        column: x => x.IdCatalogoDependecia,
                        principalTable: "CatalogoDependecias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CatalogoDeEmpleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDeControl = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCatalogoDepartamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoDeEmpleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogoDeEmpleados_CatalogoDepartamentos_IdCatalogoDepartamento",
                        column: x => x.IdCatalogoDepartamento,
                        principalTable: "CatalogoDepartamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogoDeEmpleados_IdCatalogoDepartamento",
                table: "CatalogoDeEmpleados",
                column: "IdCatalogoDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogoDepartamentos_IdCatalogoDependecia",
                table: "CatalogoDepartamentos",
                column: "IdCatalogoDependecia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogoDeEmpleados");

            migrationBuilder.DropTable(
                name: "CatalogoPuestoEmpleados");

            migrationBuilder.DropTable(
                name: "catalogoRolesUsuarios");

            migrationBuilder.DropTable(
                name: "CatalogoTipoDeBienes");

            migrationBuilder.DropTable(
                name: "CatalogoUbicaciones");

            migrationBuilder.DropTable(
                name: "RegistroFacturas");

            migrationBuilder.DropTable(
                name: "CatalogoDepartamentos");

            migrationBuilder.DropTable(
                name: "CatalogoDependecias");

            migrationBuilder.DropColumn(
                name: "ApellidoMaterno",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ApellidoPaterno",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Contraseña",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Creado",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CreadoPor",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EsActivo",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Modificado",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ModificadoPor",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Usuarios");

            migrationBuilder.CreateTable(
                name: "catalogoUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catalogoUsuarios", x => x.Id);
                });
        }
    }
}
