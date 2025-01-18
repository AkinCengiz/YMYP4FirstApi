using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP4FirstApi.Entity.Abstract;

namespace YMYP4FirstApi.Entity.Concrete;
public class Deneme : IEntity
{
	public int Id { get; set; }
	public string Name { get; set; }

}
