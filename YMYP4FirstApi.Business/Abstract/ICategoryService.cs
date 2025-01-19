using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.Business.Abstract;
public interface ICategoryService : IGenericService<Category>
{
	IQueryable<object> GetAllWithProducts();
}
