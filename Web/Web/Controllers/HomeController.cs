// HomeController
using Microsoft.AspNetCore.Mvc;

[Route("")]
public class HomeController : Controller
{
    [HttpGet("")]        // GET /
    public IActionResult Index() => View();

    [HttpGet("about")]   // GET /about
    public IActionResult About() => View();
}
