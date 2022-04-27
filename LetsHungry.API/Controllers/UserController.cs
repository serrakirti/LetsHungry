using AutoMapper;
using LetsHungry.API.DTOs;
using LetsHungry.Core.IntService;
using LetsHungry.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LetsHungry.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _usService;
        private IMapper _mapper;

        public UserController(IUserService usService, IMapper mapper)
        {
            _usService = usService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var user = await _usService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<UserDto>>(user));
        }

        [HttpPost]
        public async Task<IActionResult> Save(UserDto usDto)
        {
            var newUser = await _usService.AddAsync(_mapper.Map<User>(usDto));

            return Created(String.Empty, _mapper.Map<UserDto>(newUser));
        }
        [HttpPut]
        public IActionResult Update(UserDto usDto)
        {
            var user = _usService.Update(_mapper.Map<User>(usDto));
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var user = _usService.GetByIdAsync(id).Result;
            _usService.Remove(user);
            return NoContent();
        }

        [HttpGet("{id:int}/comments")]
        public async Task<IActionResult> GetWithCommentsById(int id)
        {
            var user = await _usService.GetWithCommentByIdAsync(id);
            return Ok(_mapper.Map<UserWithCommentsDto>(user));
        }

    }
}
