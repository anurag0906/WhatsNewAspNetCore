//using Microsoft.AspNetCore.Mvc;   --> read from global using statement

namespace AspNet6_Hello.Controllers
{
	[ApiController]
	[Route("myhome")]
	public class MyHomeController : ControllerBase
	{
		//public IActionResult Index()
		//{
		//	return View();
		//}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok("Hello world : asp 6");  //enable hot reload on save
		}

		[HttpPost]
		public IActionResult PostData(string someVal)
		{
			return Ok(someVal);
		}
	}
}
