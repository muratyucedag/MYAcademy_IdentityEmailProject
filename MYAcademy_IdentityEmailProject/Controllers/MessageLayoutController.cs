using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_IdentityEmailProject.Controllers
{
    public class MessageLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
