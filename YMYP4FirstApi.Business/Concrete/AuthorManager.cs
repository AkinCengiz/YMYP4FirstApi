using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.Business.Abstract;
using YMYP4FirstApi.DataAccess.Abstract;
using YMYP4FirstApi.DataAccess.Concrete.AdoNet;
using YMYP4FirstApi.DataAccess.Concrete.EntityFramework;
using YMYP4FirstApi.DataAccess.Concrete.NHibernite;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.Business.Concrete;
public class AuthorManager : IAuthorService
{
	private IAuthorDal _authorDal;

	public AuthorManager(EfAuthorDal authorDal)
	{
		_authorDal = authorDal;
	}


	public List<Author> GetAll()
	{
		throw new NotImplementedException();
	}

	public IQueryable<Author> GetAllQueryable()
	{
		throw new NotImplementedException();
	}

	public Author GetByEmailAddress(string email)
	{
		throw new NotImplementedException();
	}

	public Author GetById(int id)
	{
		throw new NotImplementedException();
	}

	public void Insert(Author entity)
	{
		throw new NotImplementedException();
	}

	public void Modify(Author entity)
	{
		throw new NotImplementedException();
	}

	public void Remove(Author entity)
	{
		throw new NotImplementedException();
	}
}
