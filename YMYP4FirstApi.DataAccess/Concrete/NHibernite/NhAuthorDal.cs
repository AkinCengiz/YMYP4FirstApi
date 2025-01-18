using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.DataAccess.Abstract;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.DataAccess.Concrete.NHibernite;
public class NhAuthorDal : IAuthorDal
{
	public void Add(Author entity)
	{
		throw new NotImplementedException();
	}

	public void Update(Author entity)
	{
		throw new NotImplementedException();
	}

	public void Delete(Author entity)
	{
		throw new NotImplementedException();
	}

	public List<Author> GetAll(Expression<Func<Author, bool>> filter = null)
	{
		throw new NotImplementedException();
	}

	public Author Get(Expression<Func<Author, bool>> filter)
	{
		throw new NotImplementedException();
	}

	public IQueryable<Author> GetAllQueryable(Expression<Func<Author, bool>> filter = null)
	{
		throw new NotImplementedException();
	}
}
