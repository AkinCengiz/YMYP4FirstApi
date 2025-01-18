using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.DataAccess.Abstract;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.DataAccess.Concrete.AdoNet;
public class AdoProductDal : IProductDal
{
	public void Add(Product entity)
	{
		throw new NotImplementedException();
	}

	public void Update(Product entity)
	{
		throw new NotImplementedException();
	}

	public void Delete(Product entity)
	{
		throw new NotImplementedException();
	}

	public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
	{
		throw new NotImplementedException();
	}

	public Product Get(Expression<Func<Product, bool>> filter)
	{
		throw new NotImplementedException();
	}

	public IQueryable<Product> GetAllQueryable(Expression<Func<Product, bool>> filter = null)
	{
		throw new NotImplementedException();
	}
}
