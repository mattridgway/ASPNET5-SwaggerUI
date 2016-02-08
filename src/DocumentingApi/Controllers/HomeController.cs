using Microsoft.AspNet.Mvc;
using System.Collections.Generic;

namespace DocumentingApi.Controllers
{
	public class HomeController : Controller
    {
		public IEnumerable<string> Get()
		{
			return new string[] { "value", "value" };
		}
    }
}
