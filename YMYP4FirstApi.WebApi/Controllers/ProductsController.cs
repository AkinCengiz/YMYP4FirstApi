using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore.Query.Internal;
using YMYP4FirstApi.Business.Abstract;
using YMYP4FirstApi.Entity.Concrete;

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

	[HttpPost]
	public IActionResult Add(Product product)
	{
		_productService.Insert(product);
		return Ok(product);
	}

	[HttpPut]
	public IActionResult Update(Product product)
	{
		_productService.Modify(product);
		return Ok(product);

	}

	[HttpDelete("{id}")]
	public IActionResult Delete(int id)
	{
		var product = _productService.GetById(id);
		if (product != null)
		{
			_productService.Remove(product);
			return Ok("Ürün başarıyla silindi...");
		}

		return NotFound("Ürün bulunamadı...");
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

	[HttpGet("{id}")]
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

	[HttpGet("[action]/{min}/{max}")]
	public IActionResult GetAllByBetweenPrice(decimal min, decimal max)
	{
		var products = _productService.GetAllByBetweenPrice(min, max);
		if (products.Count > 0)
		{
			return Ok(products);
		}

		return NotFound("Bu fiyat aralığında ürün bulunamadı...");
	}

	[HttpGet("[action]/{price}")]
	public IActionResult GetAllByHigherThanPrice(decimal price)
	{
		var products = _productService.GetAllByHigherThanPrice(price);
		if (products.Count == 0)
		{
			return NotFound("Belirtilen fiyattan yüksek fiyatlı ürün bulunamadı...");
		}
		return Ok(products);
	}

	[HttpGet("[action]/{price}")]
	public IActionResult GetAllByLowerThanPrice(decimal price)
	{
		var products = _productService.GetAllByLowerThanPrice(price);
		if (products.Count != 0)
		{
			return Ok(products);
		}

		return NotFound("Belirtilen fiyattan düşük fiyatlı ürün bulunamadı...");
	}


}
