﻿// <auto-generated />
using System;
using IntegradorSofttekImanol.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IntegradorSofttekImanol.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IntegradorSofttekImanol.Models.Entities.Proyecto", b =>
                {
                    b.Property<int>("CodProyecto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codProyecto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodProyecto"), 1L, 1);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("direccion");

                    b.Property<int>("Estado")
                        .HasColumnType("int")
                        .HasColumnName("estado");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaAlta");

                    b.Property<DateTime?>("FechaBaja")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaBaja");

                    b.Property<DateTime?>("FechaUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaUpdate");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.HasKey("CodProyecto");

                    b.ToTable("proyectos");

                    b.HasData(
                        new
                        {
                            CodProyecto = 1,
                            Direccion = "xxxxxxxx",
                            Estado = 2,
                            FechaAlta = new DateTime(2023, 9, 13, 16, 30, 4, 210, DateTimeKind.Local).AddTicks(6548),
                            Nombre = "random"
                        },
                        new
                        {
                            CodProyecto = 2,
                            Direccion = "xxxxxxxx",
                            Estado = 1,
                            FechaAlta = new DateTime(2023, 9, 13, 16, 30, 4, 210, DateTimeKind.Local).AddTicks(6557),
                            Nombre = "random"
                        });
                });

            modelBuilder.Entity("IntegradorSofttekImanol.Models.Entities.Rol", b =>
                {
                    b.Property<int>("codRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codRol");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("codRol"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaAlta");

                    b.Property<DateTime?>("FechaBaja")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaBaja");

                    b.Property<DateTime?>("FechaUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaUpdate");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.HasKey("codRol");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            codRol = 1,
                            Descripcion = "Usuario con derechos maximos",
                            FechaAlta = new DateTime(2023, 9, 13, 16, 30, 4, 210, DateTimeKind.Local).AddTicks(7218),
                            Nombre = "Administrador"
                        },
                        new
                        {
                            codRol = 2,
                            Descripcion = "Usuario con derechos basicos",
                            FechaAlta = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Consultor"
                        });
                });

            modelBuilder.Entity("IntegradorSofttekImanol.Models.Entities.Servicio", b =>
                {
                    b.Property<int>("CodServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codServicio");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodServicio"), 1L, 1);

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descr");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaAlta");

                    b.Property<DateTime?>("FechaBaja")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaBaja");

                    b.Property<DateTime?>("FechaUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaUpdate");

                    b.Property<decimal>("ValorHora")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("valorHora");

                    b.HasKey("CodServicio");

                    b.ToTable("servicios");

                    b.HasData(
                        new
                        {
                            CodServicio = 1,
                            Descr = "xxxxxxxx",
                            Estado = true,
                            FechaAlta = new DateTime(2023, 9, 13, 16, 30, 4, 210, DateTimeKind.Local).AddTicks(6735),
                            ValorHora = 0m
                        });
                });

            modelBuilder.Entity("IntegradorSofttekImanol.Models.Entities.Trabajo", b =>
                {
                    b.Property<int>("CodTrabajo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codTrabajo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodTrabajo"), 1L, 1);

                    b.Property<int>("CantHoras")
                        .HasColumnType("int")
                        .HasColumnName("cantHoras");

                    b.Property<int>("CodProyecto")
                        .HasColumnType("int")
                        .HasColumnName("codProyecto");

                    b.Property<int>("CodServicio")
                        .HasColumnType("int")
                        .HasColumnName("codServicio");

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("costo");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaAlta");

                    b.Property<DateTime?>("FechaBaja")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaBaja");

                    b.Property<DateTime?>("FechaUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaUpdate");

                    b.Property<decimal>("valorHora")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("valorHora");

                    b.HasKey("CodTrabajo");

                    b.HasIndex("CodProyecto");

                    b.HasIndex("CodServicio");

                    b.ToTable("trabajos");

                    b.HasData(
                        new
                        {
                            CodTrabajo = 1,
                            CantHoras = 2,
                            CodProyecto = 1,
                            CodServicio = 1,
                            Costo = 0m,
                            Fecha = new DateTime(2023, 9, 13, 16, 30, 4, 210, DateTimeKind.Local).AddTicks(6806),
                            FechaAlta = new DateTime(2023, 9, 13, 16, 30, 4, 210, DateTimeKind.Local).AddTicks(6809),
                            valorHora = 4m
                        });
                });

            modelBuilder.Entity("IntegradorSofttekImanol.Models.Entities.Usuario", b =>
                {
                    b.Property<int>("CodUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("codUsuario");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodUsuario"), 1L, 1);

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("contrasena");

                    b.Property<int>("Dni")
                        .HasColumnType("int")
                        .HasColumnName("dni");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaAlta");

                    b.Property<DateTime?>("FechaBaja")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaBaja");

                    b.Property<DateTime?>("FechaUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaUpdate");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.Property<int>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("tipo");

                    b.HasKey("CodUsuario");

                    b.HasIndex("Tipo");

                    b.ToTable("usuarios");

                    b.HasData(
                        new
                        {
                            CodUsuario = 1,
                            Contrasena = "random",
                            Dni = 39382743,
                            FechaAlta = new DateTime(2023, 9, 13, 16, 30, 4, 210, DateTimeKind.Local).AddTicks(6869),
                            Nombre = "random",
                            Tipo = 1
                        },
                        new
                        {
                            CodUsuario = 2,
                            Contrasena = "4e151238dcbb465195f49433b8ea408b8889a41d995e25b990b502d3362a602d",
                            Dni = 39382743,
                            FechaAlta = new DateTime(2023, 9, 13, 16, 30, 4, 210, DateTimeKind.Local).AddTicks(7062),
                            Nombre = "randoms",
                            Tipo = 2
                        },
                        new
                        {
                            CodUsuario = 3,
                            Contrasena = "4e151238dcbb465195f49433b8ea408b8889a41d995e25b990b502d3362a602d",
                            Dni = 39382743,
                            FechaAlta = new DateTime(2023, 9, 13, 16, 30, 4, 210, DateTimeKind.Local).AddTicks(7152),
                            Nombre = "randomdd",
                            Tipo = 2
                        });
                });

            modelBuilder.Entity("IntegradorSofttekImanol.Models.Entities.Trabajo", b =>
                {
                    b.HasOne("IntegradorSofttekImanol.Models.Entities.Proyecto", "Proyecto")
                        .WithMany("Trabajo")
                        .HasForeignKey("CodProyecto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntegradorSofttekImanol.Models.Entities.Servicio", "Servicio")
                        .WithMany("Trabajo")
                        .HasForeignKey("CodServicio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");

                    b.Navigation("Servicio");
                });

            modelBuilder.Entity("IntegradorSofttekImanol.Models.Entities.Usuario", b =>
                {
                    b.HasOne("IntegradorSofttekImanol.Models.Entities.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("Tipo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("IntegradorSofttekImanol.Models.Entities.Proyecto", b =>
                {
                    b.Navigation("Trabajo");
                });

            modelBuilder.Entity("IntegradorSofttekImanol.Models.Entities.Rol", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("IntegradorSofttekImanol.Models.Entities.Servicio", b =>
                {
                    b.Navigation("Trabajo");
                });
#pragma warning restore 612, 618
        }
    }
}
