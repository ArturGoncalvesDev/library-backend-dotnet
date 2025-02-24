﻿using AutoMapper;
using Livraria.API.Data;
using Livraria.API.Dtos.Users;
using Livraria.API.Helpers;
using Livraria.API.Models;
using Livraria.API.Services.Users;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Livraria.API.Controllers
{
    /// <summary>
    /// ApiController
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IRepository _repo;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="repo"></param>
        /// <param name="mapper"></param>
        public UserController(IUserService service, IRepository repo, IMapper mapper)
        {
            _userService = service;
            _repo = repo;
            _mapper = mapper;
        }

        /// <summary>
        /// Método responsável por retornar todos os usuários com paginação
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PageParams pageParams)
        {
            var users = await _repo.GetAllUsersAsync(pageParams);
            var usersResult = _mapper.Map<IEnumerable<UserResponseDto>>(users);

            Response.AddPagination(users.CurrentPage, users.PageSize, users.TotalCount, users.TotalPages);

            return Ok(usersResult);
        }

        /// <summary>
        /// Método responsável por retornar apenas um usuário por meio do ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _repo.GetUserById(id);
            if (user == null) return BadRequest("User not found.");

            var userDto = _mapper.Map<UserResponseDto>(user);
            return Ok(userDto);
        }

        /// <summary>
        /// Método responsável em adicionar um novo usuário
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(UserRequestDto model)
        {
            var result = _userService.UserCreate(_mapper.Map<User>(model));

            if (result != null)
            {
                return Created($"/api/v1/user/{result.Id}", _mapper.Map<UserResponseDto>(result));
            }

            return BadRequest("Unable to register user.");
        }

        /// <summary>
        /// Método responsável em atualizar um usuário por meio do ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, UserRequestDto model)
        {
            var result = _userService.UserUpdate(id, _mapper.Map<User>(model));

            if (result != null)
            {
                return Created($"/api/user/{result.Id}", _mapper.Map<UserResponseDto>(result));
            }

            return BadRequest("Could not update user.");
        }

        /// <summary>
        /// Método responsável em deletar um usuário por meio do ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _userService.UserDelete(id);

            if (result != null)
            {
                return Ok("User deleted.");
            }
  
            return BadRequest("Could not delete user.");
        }

    }
}
