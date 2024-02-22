using Microsoft.AspNetCore.Mvc;

namespace Lingwisticx2.Controllers
{
    public class SpaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vocabulary()
        {
            return View();
        }
    }
}
