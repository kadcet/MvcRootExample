using Microsoft.AspNetCore.Mvc;

namespace MvcRootExample.Controllers
{
    public class CompaniesController : Controller
    {
        

        public IActionResult Anonim()
        {
            return View();
        }
        public IActionResult Limited()
        {
            return View();
        }
        public IActionResult Sahis()
        {
            return View();
        }
    }
}
