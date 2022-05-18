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
    public class RezervationController : ControllerBase
    {
        private IRezervationService _rezService;
        private IMapper _mapper;

        public RezervationController(IRezervationService rezService, IMapper mapper)
        {
            _rezService = rezService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var rez = await _rezService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<RezervationDto>>(rez));
        }
        [HttpGet("{id:int}/orders")]
        public async Task<IActionResult> GetWithOrdersById(int id)
        {
            var rez = await _rezService.GetWithOrdersByIdAsync(id);
            return Ok(_mapper.Map<RezervationWithOrdersDto>(rez));
        }
        [HttpPost]
        public async Task<IActionResult> Save(RezervationDto rezDto)
        {
            var newRez = await _rezService.AddAsync(_mapper.Map<Rezervation>(rezDto));

            return Created(String.Empty, _mapper.Map<RezervationDto>(newRez));
        }
        [HttpPut]
        public IActionResult Update(RezervationDto rezDto)
        {
            var rez = _rezService.Update(_mapper.Map<Rezervation>(rezDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var rez = _rezService.GetByIdAsync(id).Result;
            _rezService.Remove(rez);
            return NoContent();
        }
    }
}
