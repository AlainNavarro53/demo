﻿// <auto-generated />
using System;
using Demo.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demo.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Demo.Entities.Comisario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdEvento")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdEvento");

                    b.ToTable("Comisario");
                });

            modelBuilder.Entity("Demo.Entities.ComplejoDeporteUnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Area")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("IdComplejoDeportivo")
                        .HasColumnType("int");

                    b.Property<string>("Localizacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdComplejoDeportivo");

                    b.ToTable("ComplejoDeporteUnico");
                });

            modelBuilder.Entity("Demo.Entities.ComplejoDeportivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AreaTotal")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("IdSedeOlimpica")
                        .HasColumnType("int");

                    b.Property<string>("JefeOrganizacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Localizacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdSedeOlimpica");

                    b.ToTable("ComplejoDeportivo");
                });

            modelBuilder.Entity("Demo.Entities.ComplejoPolideportivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Area")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("IdComplejoDeportivo")
                        .HasColumnType("int");

                    b.Property<string>("Localizacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdComplejoDeportivo");

                    b.ToTable("ComplejoPolideportivo");
                });

            modelBuilder.Entity("Demo.Entities.Equipamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdEvento")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdEvento");

                    b.ToTable("Equipamiento");
                });

            modelBuilder.Entity("Demo.Entities.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Duracion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdComplejoDeporteUnico")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("IdComplejoPolideportivo")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NroParticipantes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdComplejoDeporteUnico");

                    b.HasIndex("IdComplejoPolideportivo");

                    b.ToTable("Evento");
                });

            modelBuilder.Entity("Demo.Entities.EventoEquipamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdEquipamiento")
                        .HasColumnType("int");

                    b.Property<int>("IdEvento")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEquipamiento");

                    b.HasIndex("IdEvento");

                    b.ToTable("EventoEquipamiento");
                });

            modelBuilder.Entity("Demo.Entities.SedeOlimpica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Presupuesto")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("SedeOlimpica");
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

            modelBuilder.Entity("Demo.Entities.Comisario", b =>
                {
                    b.HasOne("Demo.Entities.Evento", "Evento")
                        .WithMany("Comisarios")
                        .HasForeignKey("IdEvento")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("Demo.Entities.ComplejoDeporteUnico", b =>
                {
                    b.HasOne("Demo.Entities.ComplejoDeportivo", "ComplejoDeportivo")
                        .WithMany("ComplejoDeporteUnico")
                        .HasForeignKey("IdComplejoDeportivo")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ComplejoDeportivo");
                });

            modelBuilder.Entity("Demo.Entities.ComplejoDeportivo", b =>
                {
                    b.HasOne("Demo.Entities.SedeOlimpica", "SedeOlimpica")
                        .WithMany("ComplejosDeportivo")
                        .HasForeignKey("IdSedeOlimpica")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SedeOlimpica");
                });

            modelBuilder.Entity("Demo.Entities.ComplejoPolideportivo", b =>
                {
                    b.HasOne("Demo.Entities.ComplejoDeportivo", "ComplejoDeportivo")
                        .WithMany("ComplejoPolideportivo")
                        .HasForeignKey("IdComplejoDeportivo")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ComplejoDeportivo");
                });

            modelBuilder.Entity("Demo.Entities.Equipamiento", b =>
                {
                    b.HasOne("Demo.Entities.Evento", "Evento")
                        .WithMany("Equipamiento")
                        .HasForeignKey("IdEvento")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("Demo.Entities.Evento", b =>
                {
                    b.HasOne("Demo.Entities.ComplejoDeporteUnico", "ComplejoDeporteUnico")
                        .WithMany("Eventos")
                        .HasForeignKey("IdComplejoDeporteUnico")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Demo.Entities.ComplejoPolideportivo", "ComplejoPolideportivo")
                        .WithMany("Eventos")
                        .HasForeignKey("IdComplejoPolideportivo")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ComplejoDeporteUnico");

                    b.Navigation("ComplejoPolideportivo");
                });

            modelBuilder.Entity("Demo.Entities.EventoEquipamiento", b =>
                {
                    b.HasOne("Demo.Entities.Equipamiento", "Equipamiento")
                        .WithMany("EventoEquipamiento")
                        .HasForeignKey("IdEquipamiento")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Demo.Entities.Evento", "Evento")
                        .WithMany("EventoEquipamiento")
                        .HasForeignKey("IdEvento")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Equipamiento");

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("Demo.Entities.ComplejoDeporteUnico", b =>
                {
                    b.Navigation("Eventos");
                });

            modelBuilder.Entity("Demo.Entities.ComplejoDeportivo", b =>
                {
                    b.Navigation("ComplejoDeporteUnico");

                    b.Navigation("ComplejoPolideportivo");
                });

            modelBuilder.Entity("Demo.Entities.ComplejoPolideportivo", b =>
                {
                    b.Navigation("Eventos");
                });

            modelBuilder.Entity("Demo.Entities.Equipamiento", b =>
                {
                    b.Navigation("EventoEquipamiento");
                });

            modelBuilder.Entity("Demo.Entities.Evento", b =>
                {
                    b.Navigation("Comisarios");

                    b.Navigation("Equipamiento");

                    b.Navigation("EventoEquipamiento");
                });

            modelBuilder.Entity("Demo.Entities.SedeOlimpica", b =>
                {
                    b.Navigation("ComplejosDeportivo");
                });
#pragma warning restore 612, 618
        }
    }
}
