using Microsoft.AspNetCore.Mvc;

namespace GeleceginYazarlarıAspnetcoreMVC101.WEB.Controllers
{
    public class layoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
