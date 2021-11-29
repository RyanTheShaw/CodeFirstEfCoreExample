using CodeFirstEfCoreExample.DataAccess.DbContexts;
using CodeFirstEfCoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEfCoreExample.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private MySqlDbContext _dbContext;

		public HomeController(ILogger<HomeController> logger, MySqlDbContext dbContext)
		{
			_logger = logger;
			_dbContext = dbContext;
		}

		public IActionResult Index()
		{
			IndexViewModel viewModel = new IndexViewModel()
			{
				Employees = _dbContext.Employees.ToList(),
				Roles = _dbContext.Roles.ToList()
			};

			return View(viewModel);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
