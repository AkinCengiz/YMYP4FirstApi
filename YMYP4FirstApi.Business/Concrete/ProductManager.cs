using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.Business.Abstract;
using YMYP4FirstApi.DataAccess.Abstract;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.Business.Concrete;
public class ProductManager : IProductService
{
	private IProductDal _productDal;

	public ProductManager(IProductDal productDal)
	{
		_productDal = productDal;
	}

	public void Insert(Product entity)
	{
		_productDal.Add(entity);
	}

	public void Modify(Product entity)
	{
		_productDal.Update(entity);
	}

	public void Remove(Product entity)
	{
		_productDal.Delete(entity);
	}

	public List<Product> GetAll()
	{
		return _productDal.GetAll();
	}

	public Product GetById(int id)
	{
		return _productDal.Get(x => x.Id == id);
	}

	public IQueryable<Product> GetAllQueryable()
	{
		return _productDal.GetAllQueryable();
	}

	public List<Product> GetAllByCategory(int categoryId)
	{
		return _productDal.GetAll(x => x.CategoryId == categoryId);
	}

	public List<Product> GetAllByBetweenPrice(decimal min, decimal max)
	{
		return _productDal.GetAll(x => x.Price >= min && x.Price <= max);
	}

	public List<Product> GetAllByHigherThanPrice(decimal price)
	{
		return _productDal.GetAll(x => x.Price > price);
	}

	public List<Product> GetAllByLowerThanPrice(decimal price)
	{
		return _productDal.GetAll(x => x.Price < price);
	}
}
