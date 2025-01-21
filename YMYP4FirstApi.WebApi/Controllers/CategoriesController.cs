using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YMYP4FirstApi.Business.Abstract;
using YMYP4FirstApi.Business.Concrete;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
	private readonly ICategoryService _categoryService;

	public CategoriesController(ICategoryService categoryService)
	{
		_categoryService = categoryService;
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		var categories = _categoryService.GetAll();
		if (categories != null)
		{
			return Ok(categories);
		}

		return NotFound();
	}

	[HttpGet("{id}")]
	public IActionResult GetById(int id)
	{
		var category = _categoryService.GetById(id);
		if (category != null)
		{
			return Ok(category);
		}

		return NotFound();
	}

	[HttpPost]
	public IActionResult Add(Category category)
	{
		_categoryService.Insert(category);
		return Ok(category);
	}

	[HttpPut]
	public IActionResult Update(Category category)
	{
		_categoryService.Modify(category);
		return Ok(category);
	}

	[HttpDelete("{id}")]
	public IActionResult Delete(int id)
	{
		var category = _categoryService.GetById(id);
		if (category != null)
		{
			_categoryService.Remove(category);
			return Ok("Kategori başarıyla silindi...");
		}
		return NotFound("Kategori bulunamadı");
	}

	[HttpGet("[action]")]
	public IActionResult GetAllWithProducts()
	{
		var categories = _categoryService.GetAllQueryable().Include(x => x.Products)
			.Select(x => new
			{
				x.Name,
				Products = x.Products.Select(item => new
				{
					item.Name,
					item.Price,
					item.Stock
				}).ToList()
			}).ToList();
		//var categories = _categoryService.GetAllWithProducts();

		if (categories != null)
		{
			return Ok(categories);
		}

		return NotFound();
	}
}
