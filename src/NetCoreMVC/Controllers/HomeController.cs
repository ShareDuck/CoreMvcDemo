using System;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVC.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace NetCoreMVC.Controllers
{
	public class HomeController : Controller
    {

		public HomeController(IServiceProvider service)
		{
			dbcon = new TestDbContext(service.GetRequiredService<DbContextOptions<TestDbContext>>());
		}

		TestDbContext dbcon;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
			

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

		public IActionResult MysqlUser()
		{
			var users = dbcon.Users.ToListAsync();
			return View(users);

		}

        public IActionResult Error()
        {
            return View();
        }
    }
}
