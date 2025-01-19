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

	public AuthorManager(IAuthorDal authorDal)
	{
		_authorDal = authorDal;
	}


	public List<Author> GetAll()
	{
		return _authorDal.GetAll();
	}

	public IQueryable<Author> GetAllQueryable()
	{
		return _authorDal.GetAllQueryable();
	}

	public Author GetByEmailAddress(string email)
	{
		return _authorDal.Get(x => x.Email == email);
	}

	public Author GetById(int id)
	{
		return _authorDal.Get(x => x.Id == id);
	}

	public void Insert(Author entity)
	{
		_authorDal.Add(entity);
	}

	public void Modify(Author entity)
	{
		_authorDal.Update(entity);
	}

	public void Remove(Author entity)
	{
		_authorDal.Delete(entity);
	}
}
