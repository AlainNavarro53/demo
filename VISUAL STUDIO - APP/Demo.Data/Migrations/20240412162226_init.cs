using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comisario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comisario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deporte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deporte", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipamiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sede",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Localizacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JefeOrganizacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AreaTotal = table.Column<float>(type: "real", nullable: false),
                    PresupuestoAproximado = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sede", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoComplejo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoComplejo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Complejo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SedeId = table.Column<int>(type: "int", nullable: false),
                    TipoComplejoId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AreaOcupada = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complejo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complejo_Sede_SedeId",
                        column: x => x.SedeId,
                        principalTable: "Sede",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Complejo_TipoComplejo_TipoComplejoId",
                        column: x => x.TipoComplejoId,
                        principalTable: "TipoComplejo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreaPolideportivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplejoId = table.Column<int>(type: "int", nullable: false),
                    DeporteId = table.Column<int>(type: "int", nullable: false),
                    Localizacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaPolideportivo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AreaPolideportivo_Complejo_ComplejoId",
                        column: x => x.ComplejoId,
                        principalTable: "Complejo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AreaPolideportivo_Deporte_DeporteId",
                        column: x => x.DeporteId,
                        principalTable: "Deporte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplejoId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duracion = table.Column<int>(type: "int", nullable: false),
                    NumParticipantes = table.Column<int>(type: "int", nullable: false),
                    NumComisarios = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evento_Complejo_ComplejoId",
                        column: x => x.ComplejoId,
                        principalTable: "Complejo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipamientoEvento",
                columns: table => new
                {
                    EquipamientoId = table.Column<int>(type: "int", nullable: false),
                    EventosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipamientoEvento", x => new { x.EquipamientoId, x.EventosId });
                    table.ForeignKey(
                        name: "FK_EquipamientoEvento_Equipamiento_EquipamientoId",
                        column: x => x.EquipamientoId,
                        principalTable: "Equipamiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipamientoEvento_Evento_EventosId",
                        column: x => x.EventosId,
                        principalTable: "Evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventoComisario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventoId = table.Column<int>(type: "int", nullable: false),
                    ComisarioId = table.Column<int>(type: "int", nullable: false),
                    Tarea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventoComisario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventoComisario_Comisario_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Comisario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventoComisario_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaPolideportivo_ComplejoId",
                table: "AreaPolideportivo",
                column: "ComplejoId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaPolideportivo_DeporteId",
                table: "AreaPolideportivo",
                column: "DeporteId");

            migrationBuilder.CreateIndex(
                name: "IX_Complejo_SedeId",
                table: "Complejo",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Complejo_TipoComplejoId",
                table: "Complejo",
                column: "TipoComplejoId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipamientoEvento_EventosId",
                table: "EquipamientoEvento",
                column: "EventosId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_ComplejoId",
                table: "Evento",
                column: "ComplejoId");

            migrationBuilder.CreateIndex(
                name: "IX_EventoComisario_EventoId",
                table: "EventoComisario",
                column: "EventoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaPolideportivo");

            migrationBuilder.DropTable(
                name: "EquipamientoEvento");

            migrationBuilder.DropTable(
                name: "EventoComisario");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Deporte");

            migrationBuilder.DropTable(
                name: "Equipamiento");

            migrationBuilder.DropTable(
                name: "Comisario");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "Complejo");

            migrationBuilder.DropTable(
                name: "Sede");

            migrationBuilder.DropTable(
                name: "TipoComplejo");
        }
    }
}
