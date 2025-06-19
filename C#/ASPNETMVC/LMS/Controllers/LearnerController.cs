using Microsoft.AspNetCore.Mvc;

namespace LMSApp.Controllers
{
    [Route("learner")]
    public class LearnerController : Controller
    {
        [Route("profile")]
        public IActionResult UpdateProfile() => View();

        [Route("search")]
        public IActionResult SearchContent() => View();

        [Route("logout")]
        public IActionResult Logout() => RedirectToAction("Index", "Home");
    }
}
