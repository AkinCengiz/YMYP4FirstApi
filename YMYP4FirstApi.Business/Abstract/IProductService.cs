using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.Business.Abstract;
public interface IProductService : IGenericService<Product>
{
	List<Product> GetAllByCategory(int categoryId);
	List<Product> GetAllByBetweenPrice(decimal min, decimal max);
	List<Product> GetAllByHigherThanPrice(decimal price);
	List<Product> GetAllByLowerThanPrice(decimal price);

}
