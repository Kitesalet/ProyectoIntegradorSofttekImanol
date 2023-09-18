﻿using IntegradorSofttekImanol.Helpers;
using IntegradorSofttekImanol.Migrations;
using IntegradorSofttekImanol.Models.DTOs.Usuario;
using IntegradorSofttekImanol.Models.Entities;
using IntegradorSofttekImanol.Models.Interfaces.RepoInterfaces;
using Microsoft.EntityFrameworkCore;

namespace IntegradorSofttekImanol.DAL.Repositories
{
    /// <summary>
    /// The implemmentation that defines extra repository operations related to the Usuario entity
    /// </summary>
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Initializes an instance of UsuarioRepository using dependency injection with its parameters
        /// </summary>
        /// <param name="context">AppDbContext with DI</param>
        public UsuarioRepository(AppDbContext context) : base(context)
        {

            _context = context;
           
        }


        /// <summary>
        /// Evaluates if a user exists and check its credentials
        /// </summary>
        /// <param name="dto">AuthenticateDTO</param>
        /// <returns> 
        /// A user object if the authentication is a success
        /// |
        /// A null value if it fails
        /// </returns>
        public async Task<Usuario?> AuthenticateCredentials(UsuarioAuthenticateDTO dto)
        {
           

            return await _context.Usuarios.Include(e => e.Rol)
                                          .SingleOrDefaultAsync(e => e.CodUsuario.ToString() == dto.CodUsuario && e.Contrasena == EncrypterHelper.Encrypter(dto.Contrasena,"d"));

        }

    }
}
