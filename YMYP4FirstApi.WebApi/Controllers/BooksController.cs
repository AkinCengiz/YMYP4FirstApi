using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YMYP4FirstApi.Business.Abstract;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
	private readonly IBookService _bookService;

	public BooksController(IBookService bookService)
	{
		_bookService = bookService;
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		var books = _bookService.GetAll();
		if (books.Count > 0)
		{
			return Ok(books);
		}

		return NotFound("Kitaplar bulunamadı...");
	}

	[HttpGet("{id}")]
	public IActionResult GetById(int id)
	{
		var book = _bookService.GetById(id);
		if (book != null)
		{
			return Ok(book);
		}

		return NotFound("Kitap bulunamadı...");
	}

	[HttpGet("[action]")]
	public IActionResult GetBooksWithAuthor()
	{
		var books = _bookService.GetAllQueryable().Include(b => b.Author).Select(x => new
		{
			x.Title,
			x.Author.FirstName,
			x.Author.LastName,
			x.Author.Email
		}).ToList();
		if (books.Count > 0)
		{
			return Ok(books);
		}

		return NotFound("Kitaplar bulunamadı...");
	}

	[HttpPost]
	public IActionResult Add(Book book)
	{
		
		_bookService.Insert(book);
		return Ok(book);
	}
}
