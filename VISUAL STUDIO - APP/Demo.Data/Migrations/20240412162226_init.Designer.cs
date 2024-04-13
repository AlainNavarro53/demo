﻿// <auto-generated />
using System;
using Demo.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demo.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240412162226_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Demo.Entities.AreaPolideportivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComplejoId")
                        .HasColumnType("int");

                    b.Property<int>("DeporteId")
                        .HasColumnType("int");

                    b.Property<string>("Localizacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ComplejoId");

                    b.HasIndex("DeporteId");

                    b.ToTable("AreaPolideportivo");
                });

            modelBuilder.Entity("Demo.Entities.Comisario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Comisario");
                });

            modelBuilder.Entity("Demo.Entities.Complejo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("AreaOcupada")
                        .HasColumnType("real");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SedeId")
                        .HasColumnType("int");

                    b.Property<int>("TipoComplejoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SedeId");

                    b.HasIndex("TipoComplejoId");

                    b.ToTable("Complejo");
                });

            modelBuilder.Entity("Demo.Entities.Deporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Deporte");
                });

            modelBuilder.Entity("Demo.Entities.Equipamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Equipamiento");
                });

            modelBuilder.Entity("Demo.Entities.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComplejoId")
                        .HasColumnType("int");

                    b.Property<int>("Duracion")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumComisarios")
                        .HasColumnType("int");

                    b.Property<int>("NumParticipantes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComplejoId");

                    b.ToTable("Evento");
                });

            modelBuilder.Entity("Demo.Entities.EventoComisario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComisarioId")
                        .HasColumnType("int");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<string>("Tarea")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.ToTable("EventoComisario");
                });

            modelBuilder.Entity("Demo.Entities.Sede", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("AreaTotal")
                        .HasColumnType("real");

                    b.Property<string>("JefeOrganizacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Localizacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("PresupuestoAproximado")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Sede");
                });

            modelBuilder.Entity("Demo.Entities.TipoComplejo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TipoComplejo");
                });

            modelBuilder.Entity("Demo.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("EquipamientoEvento", b =>
                {
                    b.Property<int>("EquipamientoId")
                        .HasColumnType("int");

                    b.Property<int>("EventosId")
                        .HasColumnType("int");

                    b.HasKey("EquipamientoId", "EventosId");

                    b.HasIndex("EventosId");

                    b.ToTable("EquipamientoEvento");
                });

            modelBuilder.Entity("Demo.Entities.AreaPolideportivo", b =>
                {
                    b.HasOne("Demo.Entities.Complejo", "Complejo")
                        .WithMany("AreasPolideportivo")
                        .HasForeignKey("ComplejoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Demo.Entities.Deporte", "Deporte")
                        .WithMany("AreasPolideportivo")
                        .HasForeignKey("DeporteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Complejo");

                    b.Navigation("Deporte");
                });

            modelBuilder.Entity("Demo.Entities.Complejo", b =>
                {
                    b.HasOne("Demo.Entities.Sede", "Sede")
                        .WithMany("Complejos")
                        .HasForeignKey("SedeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Demo.Entities.TipoComplejo", "TipoComplejo")
                        .WithMany("Complejos")
                        .HasForeignKey("TipoComplejoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Sede");

                    b.Navigation("TipoComplejo");
                });

            modelBuilder.Entity("Demo.Entities.Evento", b =>
                {
                    b.HasOne("Demo.Entities.Complejo", "Complejo")
                        .WithMany("Eventos")
                        .HasForeignKey("ComplejoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Complejo");
                });

            modelBuilder.Entity("Demo.Entities.EventoComisario", b =>
                {
                    b.HasOne("Demo.Entities.Comisario", "Comisario")
                        .WithMany("EventosComisario")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Demo.Entities.Evento", "Evento")
                        .WithMany("EventosComisario")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Comisario");

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("EquipamientoEvento", b =>
                {
                    b.HasOne("Demo.Entities.Equipamiento", null)
                        .WithMany()
                        .HasForeignKey("EquipamientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo.Entities.Evento", null)
                        .WithMany()
                        .HasForeignKey("EventosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Demo.Entities.Comisario", b =>
                {
                    b.Navigation("EventosComisario");
                });

            modelBuilder.Entity("Demo.Entities.Complejo", b =>
                {
                    b.Navigation("AreasPolideportivo");

                    b.Navigation("Eventos");
                });

            modelBuilder.Entity("Demo.Entities.Deporte", b =>
                {
                    b.Navigation("AreasPolideportivo");
                });

            modelBuilder.Entity("Demo.Entities.Evento", b =>
                {
                    b.Navigation("EventosComisario");
                });

            modelBuilder.Entity("Demo.Entities.Sede", b =>
                {
                    b.Navigation("Complejos");
                });

            modelBuilder.Entity("Demo.Entities.TipoComplejo", b =>
                {
                    b.Navigation("Complejos");
                });
#pragma warning restore 612, 618
        }
    }
}