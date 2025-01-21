using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YMYP4FirstApi.Business.Abstract;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthorsController : ControllerBase
{
	private readonly IAuthorService _authorService;

	public AuthorsController(IAuthorService authorService)
	{
		_authorService = authorService;
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		var authors = _authorService.GetAll();
		if (authors.Count > 0)
		{
			return Ok(authors);
		}

		return NotFound("Yazarlar bulunamadı...");
	}

	[HttpGet("{id}")]
	public IActionResult GetById(int id)
	{
		var author = _authorService.GetById(id);
		if (author != null)
		{
			return Ok(author);
		}

		return NotFound("Yazar bulunamadı...");
	}

	[HttpGet("[action]/{email}")]
	public IActionResult GetByEmailAddress(string email)
	{
		var author = _authorService.GetByEmailAddress(email);
		if (author != null)
		{
			return Ok(author);
		}

		return NotFound("Yazar bulunamadı...");
	}

	[HttpGet("[action]")]
	public IActionResult GetAllWithBooks()
	{
		var author = _authorService.GetAllQueryable().Include(a => a.Books).Select(a => new
		{
			a.FirstName,
			a.LastName,
			Books = a.Books.Select(b => new
			{
				b.Title
			}).ToList()
		}).ToList();

		if (author != null)
		{
			return Ok(author);
		}

		return NotFound("Yazarlar bulunamadı...");
	}

	[HttpPost]
	public IActionResult Add(Author author)
	{
		_authorService.Insert(author);
		return Ok(author);
	}

	[HttpPut]
	public IActionResult Update(Author author)
	{
		_authorService.Modify(author);
		return Ok(author);
	}

	[HttpDelete("{id}")]
	public IActionResult Delete(int id)
	{
		var author = _authorService.GetById(id);
		if (author != null)
		{
			_authorService.Remove(author);
			return Ok("Yazar başarıyla silindi...");
		}

		return NotFound("Yazar bulunamadı...");
	}
}
