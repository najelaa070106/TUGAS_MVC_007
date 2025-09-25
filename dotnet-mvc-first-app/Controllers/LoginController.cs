using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_first_app.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            if (username == "najla" && password == "123456")
            {
                // simpan session atau claims
                HttpContext.Session.SetString("User", username);

                // redirect ke Dashboard
                return RedirectToAction("Index", "Dashboard");
            }

            ViewBag.Error = "Username atau password salah";
            return View();
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); // hapus semua session
            return RedirectToAction("Index", "Login");
        }
    }
}
