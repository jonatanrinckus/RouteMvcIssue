using System;
using Microsoft.AspNetCore.Mvc;

namespace RouteIssue.Controllers.Api
{
	[Route("Api/Home")]
    public class SomeController : Controller
	{
		public IActionResult Get()
	    {
		    return Ok("Something");
	    }

		[HttpPost]
		public IActionResult Create(object something)
		{
			return Ok();
		}
	}
}

