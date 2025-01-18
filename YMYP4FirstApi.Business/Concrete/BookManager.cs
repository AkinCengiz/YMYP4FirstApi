using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.Business.Abstract;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.Business.Concrete;
public class BookManager : IBookService
{
	public void Insert(Book entity)
	{
		throw new NotImplementedException();
	}

	public void Modify(Book entity)
	{
		throw new NotImplementedException();
	}

	public void Remove(Book entity)
	{
		throw new NotImplementedException();
	}

	public List<Book> GetAll()
	{
		throw new NotImplementedException();
	}

	public Book GetById(int id)
	{
		throw new NotImplementedException();
	}

	public IQueryable<Book> GetAllQueryable()
	{
		throw new NotImplementedException();
	}
}
