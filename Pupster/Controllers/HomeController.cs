using Microsoft.AspNetCore.Mvc;

namespace Pupster.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
