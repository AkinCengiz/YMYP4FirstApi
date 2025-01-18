using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.DataAccess.Abstract;
using YMYP4FirstApi.Entity.Concrete;

namespace YMYP4FirstApi.DataAccess.Concrete.EntityFramework;
public class EfDenemeDal : EfGenericRepository<Deneme>,IDenemeDal
{
	public EfDenemeDal(FirstApiDbContext context) : base(context)
	{
	}

	public void AddWithCategory(Category category)
	{
		throw new NotImplementedException();
	}

	public void GetLength(Deneme deneme)
	{
		throw new NotImplementedException();
	}

	public void SetLength(Deneme deneme)
	{
		throw new NotImplementedException();
	}

	public string GetName(Deneme deneme)
	{
		throw new NotImplementedException();
	}
}
