using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.Entity.Abstract;

namespace YMYP4FirstApi.Entity.Concrete;
public class Book : IEntity
{
	public int Id { get; set; }
	public string Title { get; set; }
	public int AuthorId { get; set; }
	public Author? Author { get; set; }
}
