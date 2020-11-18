using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using TestBase.BLL.Services.Interfaces;
using TestBase.Common.Entities;

namespace TestBase.WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryService categoryService;

        public CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService)
        {
            _logger = logger;
            this.categoryService = categoryService;
        }

        [HttpGet]
        public List<Category> Get()
        {
            return categoryService.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Category> Get(int id)
        {
            var category = categoryService.GetById(id);
            if(category != null)
            {
                return category;
            }

            return BadRequest();
        }

        [HttpPost]
        public IActionResult Post(Category category)
        {
            if(category != null)
            {
                categoryService.Add(category);
                return Ok();
            }
            return BadRequest();
        }
    }
}
