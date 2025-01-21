using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.Entity.Abstract;

namespace YMYP4FirstApi.Entity.Concrete;
public class Author : IEntity
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Email { get; set; }
	public ICollection<Book>? Books { get; set; }
}
