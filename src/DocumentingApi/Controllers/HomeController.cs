using Microsoft.AspNet.Mvc;
using System.Collections.Generic;

namespace DocumentingApi.Controllers
{
	public class HomeController : Controller
    {
		[HttpGet]
		[Route("api/v1/home")]
		public IEnumerable<string> Get(int id)
		{
			return new string[] { "value", "value" };
		}
    }
}
