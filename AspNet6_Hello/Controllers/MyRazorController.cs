using Microsoft.AspNetCore.Mvc;

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
