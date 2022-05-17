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
    public class RaitingController : ControllerBase
    {
        private IRaitingService _raitService;
        private IMapper _mapper;

        public RaitingController(IRaitingService raitService, IMapper mapper)
        {
            _raitService = raitService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cat = await _raitService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<RaitingDto>>(cat));
        }
       
        [HttpPost]
        public async Task<IActionResult> Save(RaitingDto raitDto)
        {
            var newRait = await _raitService.AddAsync(_mapper.Map<Raiting>(raitDto));

            return Created(String.Empty, _mapper.Map<RaitingDto>(newRait));
        }
        [HttpPut]
        public IActionResult Update(RaitingDto raitDto)
        {
            var rait = _raitService.Update(_mapper.Map<Raiting>(raitDto));
            return NoContent();
        }

        
    }
}

