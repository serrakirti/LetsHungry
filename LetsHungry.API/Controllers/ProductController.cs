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
    public class ProductController : ControllerBase
    {
        private IProductService _proService;
        private IMapper _mapper;
        public ProductController(IProductService proService, IMapper mapper)
        {
            _proService = proService;
            _mapper = mapper;
        }

        [HttpGet] //Select islemleri icin api kullanilan keyword dur.
        public async Task<IActionResult> GetAll()
        {
            var pro = await _proService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(pro));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var pro = await _proService.GetByIdAsync(id);
            return Ok(_mapper.Map<ProductDto>(pro));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto proDto)
        {
            var newPro = await _proService.AddAsync(_mapper.Map<Product>(proDto));

            return Created(String.Empty, _mapper.Map<ProductDto>(newPro));
        }

        [HttpPut]
        public IActionResult Update(ProductDto proDto)
        {
            _proService.Update(_mapper.Map<Product>(proDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var pro = _proService.GetByIdAsync(id).Result;
            _proService.Remove(pro);
            return NoContent();
        }
    }

}
