using CodeFirstEfCoreExample.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEfCoreExample.Models
{
	public class IndexViewModel
	{
		public List<Employee> Employees { get; set; }
		public List<Role> Roles { get; set; }
	}
}
