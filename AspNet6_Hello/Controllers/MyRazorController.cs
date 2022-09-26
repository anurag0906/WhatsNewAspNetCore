//using Microsoft.AspNetCore.Mvc;  --> read from global using statement

namespace AspNet6_Hello.Controllers
{
	public class MyRazorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
