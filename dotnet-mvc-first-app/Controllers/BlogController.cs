using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_first_app.Controllers
{
    public class BlogController : Controller
    {
        [Route("my-blog")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
