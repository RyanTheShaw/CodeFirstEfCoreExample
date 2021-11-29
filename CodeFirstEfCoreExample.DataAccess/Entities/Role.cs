using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEfCoreExample.DataAccess.Entities
{
	/// <summary>
	/// Meant to represent a job role wihin the company.
	/// </summary>
	public class Role
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public RoleType RoleType { get; set; }
	}

	public enum RoleType
	{
		Hourly = 0,
		Salary = 1
	}
}
