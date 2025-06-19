using Microsoft.AspNetCore.Mvc;

namespace LMSApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("home")]
        public IActionResult Index() => View();

        [Route("about")]
        public IActionResult About() => View();

        [Route("contact")]
        public IActionResult Contact() => View();
    }
}
