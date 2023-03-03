using Microsoft.AspNetCore.Mvc;

namespace Bustamante_SportsStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
