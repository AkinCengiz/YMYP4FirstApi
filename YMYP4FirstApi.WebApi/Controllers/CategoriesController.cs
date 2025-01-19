using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

	[HttpGet("[action]/{id}")]
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
}
