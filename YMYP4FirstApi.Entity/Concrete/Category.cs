using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.Entity.Abstract;

namespace YMYP4FirstApi.Entity.Concrete;
public class Category : BaseEntity
{
	public int Id { get; set; }
	public string Name { get; set; }
	public List<Product> Products { get; set; } = new List<Product>();
}
