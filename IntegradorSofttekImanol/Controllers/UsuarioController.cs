﻿using IntegradorSofttekImanol.DAL;
using IntegradorSofttekImanol.Models.DTOs;
using IntegradorSofttekImanol.Models.DTOs.Usuario;
using IntegradorSofttekImanol.Models.Entities;
using IntegradorSofttekImanol.Models.Interfaces;
using IntegradorSofttekImanol.Models.Interfaces.ServiceInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntegradorSofttekImanol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;
        public UsuarioController(IUsuarioService service)
        {
            _service = service; 
        }

        //[Authorize(Policy = "Admin")]
        [HttpGet]
        [Route("usuarios")]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetAllUsuarios()
        {
            return Ok(await _service.GetAllUsuariosAsync());
        }

        [HttpGet]
        [Route("usuarios/{id}")]
        public async Task<ActionResult<UsuarioLoginDto>> GetUsuario(int id)
        {
            
           return Ok(await _service.GetUsuarioByIdAsync(id));
            
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> CreateUsuario(UsuarioCreateDto usuario)
        {

            var user = await _service.CreateUsuarioAsync(usuario);

            return Created("",user);

        }

        [HttpPut]
        [Route("usuario/{id}")]
        public async Task<ActionResult> UpdateUsuario(int id, UsuarioUpdateDto usuario)
        {
            var result = await _service.UpdateUsuario(usuario);

            if(result == true)
            {
                return NoContent();
            }

            return BadRequest(result);
        }

    }
}
