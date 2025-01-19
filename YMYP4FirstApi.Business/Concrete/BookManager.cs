using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.Business.Abstract;
using YMYP4FirstApi.DataAccess.Abstract;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.Business.Concrete;
public class BookManager : IBookService
{
	private IBookDal _bookDal;

	public BookManager(IBookDal bookDal)
	{
		_bookDal = bookDal;
	}

	public void Insert(Book entity)
	{
		_bookDal.Add(entity);
	}

	public void Modify(Book entity)
	{
		_bookDal.Update(entity);
	}

	public void Remove(Book entity)
	{
		_bookDal.Delete(entity);
	}

	public List<Book> GetAll()
	{
		return _bookDal.GetAll();
	}

	public Book GetById(int id)
	{
		return _bookDal.Get(x => x.Id == id);
	}

	public IQueryable<Book> GetAllQueryable()
	{
		return _bookDal.GetAllQueryable();
	}
}
