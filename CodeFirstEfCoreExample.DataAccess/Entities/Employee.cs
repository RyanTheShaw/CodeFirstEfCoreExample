using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEfCoreExample.DataAccess.Entities
{
	public class Employee
	{
		
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }


		public Role Role { get; set; }
		public int RoleId { get; set; }
	}
}
