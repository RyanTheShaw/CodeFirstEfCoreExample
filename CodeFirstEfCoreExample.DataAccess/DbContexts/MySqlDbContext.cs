using CodeFirstEfCoreExample.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEfCoreExample.DataAccess.DbContexts
{
	public class MySqlDbContext : DbContext
	{
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Role> Roles { get; set; }

		public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options) { }
	}
}
