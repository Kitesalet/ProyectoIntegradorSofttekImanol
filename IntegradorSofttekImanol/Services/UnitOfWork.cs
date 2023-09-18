﻿using IntegradorSofttekImanol.DAL;
using IntegradorSofttekImanol.DAL.Repositories;
using IntegradorSofttekImanol.Models.Interfaces;

namespace IntegradorSofttekImanol.Services
{
    /// <summary>
    /// The implemmentation of a unit that manages repositories and databases.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UsuarioRepository UsuarioRepository { get; }
        public ProyectoRepository ProyectoRepository { get; }
        public TrabajoRepository TrabajoRepository { get; }
        public RolRepository RolRepository { get; }
        public ServicioRepository ServicioRepository { get; }

        /// <summary>
        /// Initializes an instance of UnitOfWork using dependency injection with its parameters
        /// </summary>
        /// <param name="context">AppDbContext with DI</param>
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            UsuarioRepository = new UsuarioRepository(context);
            ProyectoRepository = new ProyectoRepository(context);
            TrabajoRepository = new TrabajoRepository(context);
            RolRepository = new RolRepository(context);
            ServicioRepository = new ServicioRepository(context);
       
    }

        /// <inheritdoc/>
        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
