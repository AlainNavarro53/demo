using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Data.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Complejo_ComplejoId",
                table: "Evento");

            migrationBuilder.DropTable(
                name: "AreaPolideportivo");

            migrationBuilder.DropTable(
                name: "EquipamientoEvento");

            migrationBuilder.DropTable(
                name: "EventoComisario");

            migrationBuilder.DropTable(
                name: "Complejo");

            migrationBuilder.DropTable(
                name: "Deporte");

            migrationBuilder.DropTable(
                name: "Sede");

            migrationBuilder.DropTable(
                name: "TipoComplejo");

            migrationBuilder.RenameColumn(
                name: "NumParticipantes",
                table: "Evento",
                newName: "NroParticipantes");

            migrationBuilder.RenameColumn(
                name: "NumComisarios",
                table: "Evento",
                newName: "IdComplejoPolideportivo");

            migrationBuilder.RenameColumn(
                name: "ComplejoId",
                table: "Evento",
                newName: "IdComplejoDeporteUnico");

            migrationBuilder.RenameIndex(
                name: "IX_Evento_ComplejoId",
                table: "Evento",
                newName: "IX_Evento_IdComplejoDeporteUnico");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Equipamiento",
                newName: "Tipo");

            migrationBuilder.AlterColumn<string>(
                name: "Duracion",
                table: "Evento",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Evento",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdEvento",
                table: "Equipamiento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEvento",
                table: "Comisario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Comisario",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "EventoEquipamiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEvento = table.Column<int>(type: "int", nullable: false),
                    IdEquipamiento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventoEquipamiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventoEquipamiento_Equipamiento_IdEquipamiento",
                        column: x => x.IdEquipamiento,
                        principalTable: "Equipamiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventoEquipamiento_Evento_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "Evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SedeOlimpica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Presupuesto = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SedeOlimpica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComplejoDeportivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Localizacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JefeOrganizacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AreaTotal = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    IdSedeOlimpica = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplejoDeportivo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplejoDeportivo_SedeOlimpica_IdSedeOlimpica",
                        column: x => x.IdSedeOlimpica,
                        principalTable: "SedeOlimpica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComplejoDeporteUnico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Localizacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Area = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    IdComplejoDeportivo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplejoDeporteUnico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplejoDeporteUnico_ComplejoDeportivo_IdComplejoDeportivo",
                        column: x => x.IdComplejoDeportivo,
                        principalTable: "ComplejoDeportivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComplejoPolideportivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Localizacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Area = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    IdComplejoDeportivo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplejoPolideportivo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplejoPolideportivo_ComplejoDeportivo_IdComplejoDeportivo",
                        column: x => x.IdComplejoDeportivo,
                        principalTable: "ComplejoDeportivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evento_IdComplejoPolideportivo",
                table: "Evento",
                column: "IdComplejoPolideportivo");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamiento_IdEvento",
                table: "Equipamiento",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Comisario_IdEvento",
                table: "Comisario",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_ComplejoDeporteUnico_IdComplejoDeportivo",
                table: "ComplejoDeporteUnico",
                column: "IdComplejoDeportivo");

            migrationBuilder.CreateIndex(
                name: "IX_ComplejoDeportivo_IdSedeOlimpica",
                table: "ComplejoDeportivo",
                column: "IdSedeOlimpica");

            migrationBuilder.CreateIndex(
                name: "IX_ComplejoPolideportivo_IdComplejoDeportivo",
                table: "ComplejoPolideportivo",
                column: "IdComplejoDeportivo");

            migrationBuilder.CreateIndex(
                name: "IX_EventoEquipamiento_IdEquipamiento",
                table: "EventoEquipamiento",
                column: "IdEquipamiento");

            migrationBuilder.CreateIndex(
                name: "IX_EventoEquipamiento_IdEvento",
                table: "EventoEquipamiento",
                column: "IdEvento");

            migrationBuilder.AddForeignKey(
                name: "FK_Comisario_Evento_IdEvento",
                table: "Comisario",
                column: "IdEvento",
                principalTable: "Evento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamiento_Evento_IdEvento",
                table: "Equipamiento",
                column: "IdEvento",
                principalTable: "Evento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_ComplejoDeporteUnico_IdComplejoDeporteUnico",
                table: "Evento",
                column: "IdComplejoDeporteUnico",
                principalTable: "ComplejoDeporteUnico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_ComplejoPolideportivo_IdComplejoPolideportivo",
                table: "Evento",
                column: "IdComplejoPolideportivo",
                principalTable: "ComplejoPolideportivo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comisario_Evento_IdEvento",
                table: "Comisario");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipamiento_Evento_IdEvento",
                table: "Equipamiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_ComplejoDeporteUnico_IdComplejoDeporteUnico",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_ComplejoPolideportivo_IdComplejoPolideportivo",
                table: "Evento");

            migrationBuilder.DropTable(
                name: "ComplejoDeporteUnico");

            migrationBuilder.DropTable(
                name: "ComplejoPolideportivo");

            migrationBuilder.DropTable(
                name: "EventoEquipamiento");

            migrationBuilder.DropTable(
                name: "ComplejoDeportivo");

            migrationBuilder.DropTable(
                name: "SedeOlimpica");

            migrationBuilder.DropIndex(
                name: "IX_Evento_IdComplejoPolideportivo",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Equipamiento_IdEvento",
                table: "Equipamiento");

            migrationBuilder.DropIndex(
                name: "IX_Comisario_IdEvento",
                table: "Comisario");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "IdEvento",
                table: "Equipamiento");

            migrationBuilder.DropColumn(
                name: "IdEvento",
                table: "Comisario");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Comisario");

            migrationBuilder.RenameColumn(
                name: "NroParticipantes",
                table: "Evento",
                newName: "NumParticipantes");

            migrationBuilder.RenameColumn(
                name: "IdComplejoPolideportivo",
                table: "Evento",
                newName: "NumComisarios");

            migrationBuilder.RenameColumn(
                name: "IdComplejoDeporteUnico",
                table: "Evento",
                newName: "ComplejoId");

            migrationBuilder.RenameIndex(
                name: "IX_Evento_IdComplejoDeporteUnico",
                table: "Evento",
                newName: "IX_Evento_ComplejoId");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Equipamiento",
                newName: "Nombre");

            migrationBuilder.AlterColumn<int>(
                name: "Duracion",
                table: "Evento",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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

            migrationBuilder.CreateTable(
                name: "Sede",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaTotal = table.Column<float>(type: "real", nullable: false),
                    JefeOrganizacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Localizacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                name: "Complejo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SedeId = table.Column<int>(type: "int", nullable: false),
                    TipoComplejoId = table.Column<int>(type: "int", nullable: false),
                    AreaOcupada = table.Column<float>(type: "real", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                name: "IX_EventoComisario_EventoId",
                table: "EventoComisario",
                column: "EventoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Complejo_ComplejoId",
                table: "Evento",
                column: "ComplejoId",
                principalTable: "Complejo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
