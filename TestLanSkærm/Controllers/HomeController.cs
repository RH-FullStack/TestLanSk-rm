using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestLanSkærm.Models;
using TestLanSkærm.Service;
using TestLanSkærm.ResponseModels;

namespace TestLanSkærm.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly GetAuthTokenGraphQL _authToken;
		public HomeController(ILogger<HomeController> logger, GetAuthTokenGraphQL authToken)
		{
			_logger = logger;
			_authToken = authToken;
		}

		public IActionResult Index()
		{
			
			return View();
		}

		public async Task<IActionResult> SampleFunctionAsync()
		{
			return View();
		}

		public IActionResult Embed()
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