using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using YMYP4FirstApi.Business.Abstract;

namespace YMYP4FirstApi.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
	private readonly IProductService _productService;

	public ProductsController(IProductService productService)
	{
		_productService = productService;
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		var products = _productService.GetAll();
		if (products != null)
		{
			return Ok(products);
		}

		return NotFound();
	}

	[HttpGet("id/{id}")]
	public IActionResult GetById(int id)
	{
		var product = _productService.GetById(id);
		if (product != null)
		{
			return Ok(product);
		}

		return NotFound("Ürün bulunamaadı...");
	}

	[HttpGet("[action]/{id}")]
	public IActionResult GetAllByCategoryId(int id)
	{
		var products = _productService.GetAllByCategory(id);
		if (products != null)
		{
			return Ok(products);
		}

		return NotFound();
	}

	[HttpGet("[action]")]
	public IActionResult GetGetAllByBetweenPrice(decimal min, decimal max)
	{
		var products = _productService.GetAllByBetweenPrice(min, max);
		if (products.Count > 0)
		{
			return Ok(products);
		}

		return NotFound("Bu fiyat aralığında ürün bulunamadı...");
	}


}
