using System;
using Microsoft.AspNetCore.Mvc;

namespace RouteIssue.Controllers.Api
{
	[Area("Api")]
	public class SomeController : Controller
	{
		[ActionName("")]
		public IActionResult Get()
	    {
		    return Ok("Something");
	    }

		[ActionName("{id}")]
		public IActionResult Get(int id)
		{
			return Ok("Something" + id);
		}

		[HttpPost]
		public IActionResult Create(object something)
		{
			return Ok();
		}
	}
}

