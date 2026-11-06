using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_IdentityEmailProject.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
    }
}