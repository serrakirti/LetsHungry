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
    public class RestaurantController : ControllerBase
    {
        private IRestaurantService _resService;
        private IMapper _mapper;

        public RestaurantController(IRestaurantService resService, IMapper mapper)
        {
            _resService = resService;
            _mapper = mapper;
        }
        [HttpGet] //Select islemleri icin api kullanilan keyword dur.
        public async Task<IActionResult> GetAll()
        {
            var res = await _resService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<RestaurantDto>>(res));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var res = await _resService.GetByIdAsync(id);
            return Ok(_mapper.Map<RestaurantDto>(res));
        }

        [HttpPost]
        public async Task<IActionResult> Save(RestaurantDto resDto)
        {
            var newRes = await _resService.AddAsync(_mapper.Map<Restaurant>(resDto));

            return Created(String.Empty, _mapper.Map<RestaurantDto>(newRes));
        }

        [HttpPut]
        public IActionResult Update(RestaurantDto resDto)
        {
            _resService.Update(_mapper.Map<Restaurant>(resDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var pro = _resService.GetByIdAsync(id).Result;
            _resService.Remove(pro);
            return NoContent();
        }
    }
}
