using System;
using Microsoft.AspNetCore.Mvc;

namespace RouteIssue.Controllers.Api
{
	[Area("Api")]
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

