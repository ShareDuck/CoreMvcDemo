using System;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVC.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace NetCoreMVC.Controllers
{
	public class HomeController : Controller
    {
		TestDbContext dbcon;
		public HomeController(IServiceProvider service)
		{
			dbcon = new TestDbContext(service.GetRequiredService<DbContextOptions<TestDbContext>>());
		}

		
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
			var users = dbcon.Users.ToList();
			return View(users);
		}

        public IActionResult Error()
        {
            return View();
        }
    }
}
