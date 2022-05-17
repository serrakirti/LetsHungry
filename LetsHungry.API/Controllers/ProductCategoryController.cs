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
    public class ProductCategoryController : ControllerBase
    {
        private IProductCategoryService _proCatService;
        private IMapper _mapper;

        public ProductCategoryController(IProductCategoryService proCatService, IMapper mapper)
        {
            _proCatService = proCatService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var procat = await _proCatService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductCategoryDto>>(procat));
        }
        [HttpGet("{id:int}/products")]
        public async Task<IActionResult> GetWithProductsById(int id)
        {
            var procat = await _proCatService.GetWithProductByIdAsync(id);
            return Ok(_mapper.Map<ProductCategoryWithProductsDto>(procat));
        }
        [HttpPost]
        public async Task<IActionResult> Save(ProductCategoryDto ProCatDto)
        {
            var newProCat = await _proCatService.AddAsync(_mapper.Map<ProductCategory>(ProCatDto));

            return Created(String.Empty, _mapper.Map<ProductCategoryDto>(newProCat));
        }
        [HttpPut]
        public IActionResult Update(ProductCategoryDto ProCatDto)
        {
            var proCat = _proCatService.Update(_mapper.Map<ProductCategory>(ProCatDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var proCat = _proCatService.GetByIdAsync(id).Result;
            _proCatService.Remove(proCat);
            return NoContent();
        }
    }
}
