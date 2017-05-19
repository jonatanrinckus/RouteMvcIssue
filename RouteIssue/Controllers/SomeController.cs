using Microsoft.AspNetCore.Mvc;

namespace RouteIssue.Controllers
{
    public class SomeController : Controller
    {
	    public IActionResult Create()
	    {
		    return View();
	    }

	}
}
