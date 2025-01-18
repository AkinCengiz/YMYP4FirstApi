using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.DataAccess.Abstract;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.DataAccess.Concrete.EntityFramework;
public class EfCategoryDal : EfGenericRepository<Category>
{
	public EfCategoryDal(FirstApiDbContext context) : base(context)
	{

	}
}
