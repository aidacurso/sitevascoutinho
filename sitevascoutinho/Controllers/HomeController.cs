using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sitevascoutinho.Models;
using sitevascoutinho.Models.Classes;
using System.Diagnostics;

namespace sitevascoutinho.Controllers
{
	public class HomeController : Controller
	{
		private readonly DBContext _context;
		private readonly ILogger<HomeController> _logger;
		public HomeController(ILogger<HomeController> logger, DBContext context)
		{
			_logger = logger;
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _context.GuardarNoticia.ToListAsync());
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