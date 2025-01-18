using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.Entity.Abstract;

namespace YMYP4FirstApi.Business.Abstract;
public interface IGenericService<T> where T : class,IEntity, new()
{
	void Insert(T entity);
	void Modify(T entity);
	void Remove(T entity);
	List<T> GetAll();
	T GetById(int id);
	IQueryable<T> GetAllQueryable();
}
