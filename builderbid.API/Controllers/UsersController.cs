using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using builderbid.API.Data;
using builderbid.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace builderbid.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IBuilderRepository repo;
        private readonly IMapper mapper;

        public UsersController(IBuilderRepository repo, IMapper mapper)
        {
            this.mapper = mapper;
            this.repo = repo;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await this.repo.GetUsers();
            var usersToReturn = this.mapper.Map<IEnumerable<UserForListDto>>(users);
            return Ok(usersToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await this.repo.GetUser(id);

            var userToReturn = this.mapper.Map<UserForDetailedDto>(user);
            return Ok(userToReturn);
        }
    }
}