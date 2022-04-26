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
    public class CategoryController : ControllerBase
    {
        private ICategoryService _catService;
        private IMapper _mapper;

        public CategoryController(ICategoryService catService, IMapper mapper)
        {
            _catService = catService;
            _mapper = mapper;
        }
        [HttpGet] 
        public async Task<IActionResult> GetAll()
        {
            var cat = await _catService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(cat));
        }
        [HttpGet("{id:int}/restaurants")]
        public async Task<IActionResult> GetWithRestaurantsById(int id)
        {
            var cat = await _catService.GetWithRestaurantByIdAsync(id);
            return Ok(_mapper.Map<CategoryWithRestaurantsDto>(cat));
        }
        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto catDto)
        {
            var newCat = await _catService.AddAsync(_mapper.Map<Category>(catDto));

            return Created(String.Empty, _mapper.Map<CategoryDto>(newCat));
        }
        [HttpPut]
        public IActionResult Update(CategoryDto catDto)
        {
            var cat = _catService.Update(_mapper.Map<Category>(catDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var cat = _catService.GetByIdAsync(id).Result;
            _catService.Remove(cat);
            return NoContent();
        }
    }
}
