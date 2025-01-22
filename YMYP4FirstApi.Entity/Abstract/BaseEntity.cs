using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMYP4FirstApi.Entity.Abstract;
public abstract class BaseEntity : IEntity
{
	public int Id { get; set; }
	public DateTime CreateAt { get; set; } = DateTime.Now;
	public DateTime? UpdateAt { get; set; }
	public bool IsDeleted { get; set; }
	public bool IsActive { get; set; }
}
