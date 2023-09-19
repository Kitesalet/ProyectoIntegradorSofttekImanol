﻿using IntegradorSofttekImanol.DAL.DBSeeding;
using IntegradorSofttekImanol.Models.Entities;
using IntegradorSofttekImanol.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IntegradorSofttekImanol.DAL
{
    /// <summary>
    /// Represents the application's database context that manages database tables.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Initializes an instance of AppDbContext
        /// </summary>
        /// <param name="options">DbContextOptions</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {



        }


        //Database tables
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Trabajo> Trabajos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
      
            #region Seeding config

            var seeder = new List<IEntitySeeder>()
            {
                new ProyectoSeeder(),
                new ServicioSeeder(),
                new TrabajoSeeder(),
                new UsuarioSeeder(),
                new RolSeeder()
            };

            foreach(var seed in seeder)
            {
                seed.SeedDatabase(modelBuilder);
            }

            #endregion

            #region Unused Fluent Api relationship settings
            /*        

            modelBuilder.Entity<Trabajo>()
                .HasOne(e => e.Proyecto)
                .WithMany(e => e.Trabajo)
                .HasForeignKey("CodTrabajo");

            modelBuilder.Entity<Trabajo>()
                .HasOne(e => e.Servicio)
                .WithMany(e => e.Trabajo)
                .HasForeignKey("CodServicio");

             */

            /*
                         
            modelBuilder.Entity<Usuario>().HasKey(e => e.CodUsuario);
            modelBuilder.Entity<Proyecto>().HasKey(e => e.CodProyecto);
            modelBuilder.Entity<Trabajo>().HasKey(e => e.CodTrabajo);
            modelBuilder.Entity<Servicio>().HasKey(e => e.CodServicio);

            */
            #endregion

            #region Fluent Api Property Config

            modelBuilder.Entity<Servicio>()
                 .Property(e => e.ValorHora)
                 .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Trabajo>()
                .Property(e => e.valorHora)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Trabajo>()
                .Property(e => e.Costo)
                .HasColumnType("decimal(18, 2)");

            #endregion

            base.OnModelCreating(modelBuilder);


        }

    }
}
