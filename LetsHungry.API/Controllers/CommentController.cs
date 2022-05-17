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
    public class CommentController : ControllerBase
    {
        private ICommentService _comService;
        private IMapper _mapper;

        public CommentController(ICommentService comService, IMapper mapper)
        {
            _comService = comService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var com = await _comService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CommentDto>>(com));
        }
        [HttpPost]
        public async Task<IActionResult> Save(CommentDto comDto)
        {
            var newCom = await _comService.AddAsync(_mapper.Map<Comment>(comDto));

            return Created(String.Empty, _mapper.Map<CommentDto>(newCom));
        }
        [HttpPut]
        public IActionResult Update(CommentDto comDto)
        {
            var com = _comService.Update(_mapper.Map<Comment>(comDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var com = _comService.GetByIdAsync(id).Result;
            _comService.Remove(com);
            return NoContent();
        }

    }
}
