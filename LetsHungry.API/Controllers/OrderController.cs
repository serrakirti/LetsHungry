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
    public class OrderController : ControllerBase
    {
        private IOrderService _orService;
        private IMapper _mapper;

        public OrderController(IOrderService orService, IMapper mapper)
        {
            _orService = orService;
            _mapper = mapper;
        }

        [HttpGet] //Select islemleri icin api kullanilan keyword dur.
        public async Task<IActionResult> GetAll()
        {
            var ord = await _orService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<OrderDto>>(ord));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ord = await _orService.GetByIdAsync(id);
            return Ok(_mapper.Map<OrderDto>(ord));
        }

        [HttpPost]
        public async Task<IActionResult> Save(OrderDto orDto)
        {
            var newOrd = await _orService.AddAsync(_mapper.Map<Order>(orDto));

            return Created(String.Empty, _mapper.Map<OrderDto>(newOrd));
        }

        [HttpPut]
        public IActionResult Update(OrderDto orDto)
        {
            _orService.Update(_mapper.Map<Order>(orDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var pro = _orService.GetByIdAsync(id).Result;
            _orService.Remove(pro);
            return NoContent();
        }
    }
}
