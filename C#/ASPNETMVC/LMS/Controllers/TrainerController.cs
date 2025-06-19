using Microsoft.AspNetCore.Mvc;

namespace LMSApp.Controllers
{
    [Route("trainer")]
    public class TrainerController : Controller
    {
        [Route("profile")]
        public IActionResult UpdateProfile() => View();

        [Route("content")]
        public IActionResult ManageContent() => View();

        [Route("logout")]
        public IActionResult Logout() => RedirectToAction("Index", "Home");
    }
}
