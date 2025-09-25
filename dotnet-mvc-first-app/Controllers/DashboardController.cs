using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace dotnet_mvc_first_app.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
