using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YMYP4FirstApi.Business.Abstract;
using YMYP4FirstApi.DataAccess.Abstract;
using YMYP4FirstApi.DataAccess.Concrete.EntityFramework;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.Business.Concrete;
public class CategoryManager : ICategoryService
{
	private ICategoryDal _categoryDal;
	//private EfCategoryDal _category_Dal;

	public CategoryManager(ICategoryDal categoryDal)
	{
		_categoryDal = categoryDal;
	}


	public void Insert(Category entity)
	{
		_categoryDal.Add(entity);
	}

	public void Modify(Category entity)
	{
		_categoryDal.Update(entity);
	}

	public void Remove(Category entity)
	{
		_categoryDal.Delete(entity);
	}

	public List<Category> GetAll()
	{
		return _categoryDal.GetAll();
	}

	public Category GetById(int id)
	{
		return _categoryDal.Get(x => x.Id == id);
	}

	public IQueryable<Category> GetAllQueryable()
	{
		return _categoryDal.GetAllQueryable();
	}

	public IQueryable<object> GetAllWithProducts()
	{
		var categories = _categoryDal.GetAllQueryable().Include(x => x.Products)
			.Select(x => new
			{
				x.Name,
				Products = x.Products.Select(item => new
				{
					item.Name,
					item.Price,
					item.Stock
				}).ToList()
			});
		return categories;
	}
}
